using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics.CodeAnalysis;

namespace Sistema_Inventarios
{
    public partial class frmFacturas : Form
    {
        SQL sql = new SQL();
        public SqlDataAdapter bdFacturas, bdProdFact, bdClientes, bdProd, bdControl;
        public DataSet tbFacturas, tbProdFact, tbClientes, tbProd, tbControl;

        private void cboProdFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount != 0)
            {
                prodSearch(cboProdFact.Text);
                int index = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows[index].Cells[0].Value = Convert.ToString(regProd["Id"]);
                dgvProductos.Rows[index].Cells[1].Value = Convert.ToString(regProd["Descripcion"]);
                dgvProductos.Rows[index].Cells[2].Value = "1";
                dgvProductos.Rows[index].Cells[3].Value = Convert.ToString(regProd["Descuento"]);
                float precio = 0;
                if (Convert.ToString(regClientes["NivelPrecio"]) == "1")
                {
                    dgvProductos.Rows[index].Cells[4].Value = Convert.ToString(regProd["Precio_1"]);
                }
                else if (Convert.ToString(regClientes["NivelPrecio"]) == "2")
                {
                    dgvProductos.Rows[index].Cells[4].Value = Convert.ToString(regProd["Precio_2"]);
                }
                else
                {
                    dgvProductos.Rows[index].Cells[4].Value = Convert.ToString(regProd["Precio_3"]);
                }
                dgvProductos.Rows[index].Cells[6].Value = Convert.ToString(regProd["Costo"]);
                precio = Convert.ToSingle(dgvProductos.Rows[index].Cells[4].Value);
                float desc = Convert.ToSingle(dgvProductos.Rows[index].Cells[4].Value) * (Convert.ToSingle(dgvProductos.Rows[index].Cells[3].Value) / 100);
                float imp = precio - desc;
                dgvProductos.Rows[index].Cells[5].Value = Convert.ToString(imp);
                if (regProd["Foto"] != DBNull.Value)
                {
                    byte[] byteImg = ((byte[])regProd["Foto"]);
                    pctFotoProducto.Image = ByteArrayToImage(byteImg);
                }
                calcTotales();
            }
            else 
            {
                MessageBox.Show("Agrega un producto primero!");
            }
            btnGuardar.Enabled = true;
            btnEnviar.Enabled = true;
        }

        public DataRow regFacturas, regProdFact, regClientes, regProd, regControl;

        void calcTotales()
        {
            int index = dgvProductos.CurrentRow.Index;
            int cantidad = Convert.ToInt16(dgvProductos.Rows[index].Cells[2].Value);
            int cant = Convert.ToInt16(regProd["Existencia"]);
            if (cantidad > cant)
            {
                MessageBox.Show("Ésta cantidad excede la cantidad existente");
                dgvProductos.Rows[index].Cells[2].Value = cant;
            }
            else
            {
                float descuento = Convert.ToSingle(dgvProductos.Rows[index].Cells[3].Value) / 100;
                float importe = Convert.ToInt16(dgvProductos.Rows[index].Cells[2].Value) * Convert.ToInt16(dgvProductos.Rows[index].Cells[4].Value);
                importe -= importe * descuento;
                dgvProductos.Rows[index].Cells[5].Value = importe;
                float subtotal = 0;
                for (int m = 0; m < dgvProductos.RowCount; m++)
                {
                    subtotal += Convert.ToSingle(dgvProductos.Rows[m].Cells[5].Value);
                }
                txtSubtotal.Text = subtotal.ToString();
                float descuentoTotal = subtotal * (Convert.ToSingle(regClientes["Descuento"]) / 100);
                float iva = (subtotal - descuentoTotal) * (Convert.ToSingle(regControl["IVA"]) / 100);
                float total = subtotal - descuentoTotal + iva;
                txtDescuento.Text = descuentoTotal.ToString();
                txtIva.Text = iva.ToString();
                txtTotal.Text = total.ToString();
            }
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcTotales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int estatus = (Convert.ToInt16(regClientes["Status"]));
            float limiteCredito = (Convert.ToSingle(regClientes["LimiteCredito"]));
            float total = float.Parse(txtTotal.Text);

            if (txtFolio.Text == "" || txtDatosPersonales.Text == "" || txtObservaciones.Text == "")
            {
                MessageBox.Show("LLena todos los campos");
            }
            else if (rdbCredito.Checked == true && estatus == 2 && total > limiteCredito)
            {
                MessageBox.Show("Se excedió el limite de crédito");
            }
            else if (rdbCredito.Checked == true && estatus == 3 || estatus == 4)
            {
                MessageBox.Show("Crédito cancelado o suspendido");
            }
            else
            {
                string query1 = "INSERT INTO FacturasVtas VALUES(" +
                    "@Folio," +
                    "@Tipo," +
                    "@Cliente," +
                    "@Fecha," +
                    "@Observacion," +
                    "@Status," +
                    "@EnvioFactura," +
                    "@Impreso," +
                    "@Timbrado)";
                SqlCommand cmd1 = new SqlCommand(query1, sql.getConn());
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@Folio", Convert.ToInt32(txtFolio.Text));
                if (rdbContado.Checked)
                    cmd1.Parameters.AddWithValue("@Tipo", Convert.ToInt32(1));
                else
                    cmd1.Parameters.AddWithValue("@Tipo", Convert.ToInt32(2));
                cmd1.Parameters.AddWithValue("@Cliente", Convert.ToInt32(regClientes["Id"]));
                cmd1.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(dtpFecha.Value));
                cmd1.Parameters.AddWithValue("@Observacion", Convert.ToString(txtObservaciones.Text));
                cmd1.Parameters.AddWithValue("@Status", Convert.ToInt32(0));
                cmd1.Parameters.AddWithValue("@EnvioFactura", Convert.ToInt32(0));
                cmd1.Parameters.AddWithValue("@Impreso", Convert.ToInt32(0));
                cmd1.Parameters.AddWithValue("@Timbrado", Convert.ToInt32(0));
                int folio = Convert.ToInt32(txtFolio.Text);
                try
                {
                    cmd1.ExecuteScalar();
                    MessageBox.Show("Factura guardada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                string query3 = "";
                if (rdbContado.Checked)
                    query3 = "UPDATE Control SET FolioVtasContado = FolioVtasContado + 1";
                else
                    query3 = "UPDATE Control SET FolioVtasCredito = FolioVtasCredito + 1";
                SqlCommand cmd3 = new SqlCommand(query3, sql.getConn());
                cmd3.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("", sql.getConn());
                for (int m = 0; m < dgvProductos.RowCount; m++)
                {
                    string query2 = "INSERT INTO ProductosVendidos VALUES(" +
                    "@Folio," +
                    "@Tipo," +
                    "@Producto," +
                    "@Cantidad," +
                    "@Descuento," +
                    "@Precio," +
                    "@Costo)";
                    cmd2.CommandText = query2;
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@Folio", folio);
                    if (rdbContado.Checked)
                        cmd2.Parameters.AddWithValue("@Tipo", Convert.ToInt32(1));
                    else
                        cmd2.Parameters.AddWithValue("@Tipo", Convert.ToInt32(2));
                    cmd2.Parameters.AddWithValue("@Producto", Convert.ToInt16(dgvProductos.Rows[m].Cells[0].Value));
                    cmd2.Parameters.AddWithValue("@Cantidad", Convert.ToInt16(dgvProductos.Rows[m].Cells[2].Value));
                    cmd2.Parameters.AddWithValue("@Descuento", Convert.ToSingle(dgvProductos.Rows[m].Cells[3].Value));
                    cmd2.Parameters.AddWithValue("@Precio", Convert.ToSingle(dgvProductos.Rows[m].Cells[4].Value));
                    cmd2.Parameters.AddWithValue("@Costo", Convert.ToSingle(dgvProductos.Rows[m].Cells[6].Value));
                    try
                    {
                        cmd2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar productos: " + ex.Message);
                    }

                }
                tbControl.Clear();
                bdControl.Fill(tbControl, "Control");
                regControl = tbControl.Tables["Control"].Rows[0];
                /*
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = printDocument1;
                ((Form)ppd).WindowState = FormWindowState.Maximized;
                ppd.ShowDialog();
                */
                printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printDocument1.PrinterSettings.PrintFileName = @"C:\facturas-sistema\" + txtFolio.Text.Trim() + ".pdf";
                printDocument1.PrinterSettings.PrintToFile = true;
                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = printDocument1;
                ((Form)ppd).WindowState = FormWindowState.Maximized;
                ppd.ShowDialog();
                printDocument1.Print();
                ((Form)ppd).Close();

                var dir = new DirectoryInfo(@"C:\facturas-sistema\");
                dir.Refresh();
                System.Threading.Thread.Sleep(1000);

                string emisor = Convert.ToString(regControl["Correo"]).Trim();
                string password = Convert.ToString(regControl["PasswordCorreo"]).Trim();
                string asunto = "Factura No. " + txtFolio.Text.Trim();
                string msg = "Se adjunta la factura correspondiente.";
                string receptor = Convert.ToString(regClientes["Correo"]).Trim();
                string adjunto = @"C:\facturas-sistema\" + txtFolio.Text.Trim() + ".pdf";
                enviarCorreo(emisor, password, asunto, msg, receptor, adjunto);
            }
        }
        //
        public static void enviarCorreo(string emisor, string password, string asunto, string msg, string receptor, string adjunto)
        {
            MailMessage mail = new MailMessage();
            mail.To.Clear();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress(emisor);
            mail.To.Add(receptor);
            mail.Subject = asunto;
            mail.Body = msg;
            mail.Attachments.Add(new Attachment(adjunto));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Hotmail = smtp.live.com.mx
            smtp.Port = 587; //Hotmail = 25, 486, 465
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emisor, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);

            mail.Attachments.Clear();
            mail.Dispose();
            MessageBox.Show("Correo enviado correctamente...");
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteImg)
        {
            MemoryStream ms = new MemoryStream(byteImg);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        //Metodo para redimensionar imagen
        private Image resizeImage(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return (Image)destinationImage;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string queryComm = "SELECT * FROM Control";
                SqlCommand cmd = new SqlCommand(queryComm, sql.getConn());
                SqlDataAdapter dbControl = new SqlDataAdapter(cmd);
                DataSet tbControl = new DataSet();
                dbControl.Fill(tbControl, "Control");
                DataRow reg = tbControl.Tables["Control"].Rows[0];
                byte[] byteImg = ((byte[])reg["Logo"]);
                Image img = ByteArrayToImage(byteImg);
                Bitmap imgbitmap = new Bitmap(img);
                Image resizedImage = resizeImage(imgbitmap, 100, 100);
                //Datos Factura 
                e.Graphics.DrawImage(resizedImage, new Point(50, 30));
                e.Graphics.DrawString("Factura No. " + txtFolio.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 150));
                e.Graphics.DrawString("Fecha: ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 170));
                e.Graphics.DrawString(dtpFecha.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, 190));
                e.Graphics.DrawString("Cliente: " + cboCliente.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 150));
                e.Graphics.DrawString(txtDatosPersonales.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(50, 170));
                if (rdbContado.Checked)
                    e.Graphics.DrawString("CONTADO", new Font("Arial Black", 14, FontStyle.Regular), Brushes.Black, new Point(600, 210));
                else
                    e.Graphics.DrawString("CREDITO", new Font("Arial Black", 14, FontStyle.Regular), Brushes.Black, new Point(600, 210));
                e.Graphics.DrawString("Observaciones:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 240));
                e.Graphics.DrawString(txtObservaciones.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(600, 260));
                e.Graphics.DrawRectangle(Pens.Black, 40, 20, 780, 280);
                //Datos Productos
                int i = 300;
                e.Graphics.DrawString("Clave", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, i + 20));
                e.Graphics.DrawString("Producto", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(150, i + 20));
                e.Graphics.DrawString("Cantidad", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(400, i + 20));
                e.Graphics.DrawString("Descuento", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(500, i + 20));
                e.Graphics.DrawString("Precio", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(620, i + 20));
                e.Graphics.DrawString("Importe", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(700, i + 20));
                i += 20;
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    e.Graphics.DrawString(row.Cells["Clave"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(50, i + 20));
                    e.Graphics.DrawString(row.Cells["Descripcion"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(150, i + 20));
                    e.Graphics.DrawString(row.Cells["Cantidad"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(400, i + 20));
                    e.Graphics.DrawString(row.Cells["Descuento"].Value.ToString() + "%", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, i + 20));
                    e.Graphics.DrawString("$" + row.Cells["Precio"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(620, i + 20));
                    e.Graphics.DrawString("$" + row.Cells["Importe"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(700, i + 20));
                    i += 20;
                    e.Graphics.DrawRectangle(Pens.Black, 40, i + 20, 780, (float)0.5);
                }
                //Totales
                Conversores conv = new Conversores();
                decimal total = Convert.ToDecimal(txtTotal.Text);
                string letraTotal = conv.enletras(total.ToString());
                StringFormat sf1 = new StringFormat();
                sf1.Alignment = StringAlignment.Near;
                sf1.LineAlignment = StringAlignment.Near;
                StringFormat sf2 = new StringFormat();
                sf2.Alignment = StringAlignment.Far;
                sf2.LineAlignment = StringAlignment.Far;
                e.Graphics.DrawRectangle(Pens.Black, 40, 320, 780, 620);
                e.Graphics.DrawString("Subtotal:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 980), sf1);
                e.Graphics.DrawString("$" + txtSubtotal.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(800, 1000), sf2);
                e.Graphics.DrawString("Descuento:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 1000), sf1);
                e.Graphics.DrawString("$" + txtDescuento.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(800, 1020), sf2);
                e.Graphics.DrawString("IVA:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 1020), sf1);
                e.Graphics.DrawString("$" + txtIva.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(800, 1040), sf2);
                e.Graphics.DrawString("Total:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, 1040), sf1);
                //e.Graphics.DrawString("$" + txtTotal.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(800, 1060), sf2);
                e.Graphics.DrawString(letraTotal, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(800, 1060), sf2);
                e.Graphics.DrawRectangle(Pens.Black, 40, 960, 780, 120);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarProd_Click(object sender, EventArgs e)
        {
            cboProdFact.Focus();
            cboProdFact.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO FacturasVtas VALUES (" + Convert.ToInt16(regClientes["Id"]) + ",getDate(),'',1,1,0,0,0); SELECT SCOPE_IDENTITY()", sql.connect());
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            txtFolio.Text = Convert.ToString(id);
            txtFolio.Enabled = false;
        }

        private void rdbCredito_CheckedChanged(object sender, EventArgs e)
        {
            txtFolio.Text = Convert.ToString(regControl["FolioVtasCredito"]);
        }

        private void rdbContado_CheckedChanged(object sender, EventArgs e)
        {
            txtFolio.Text = Convert.ToString(regControl["FolioVtasContado"]);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cboCliente.Focus();
            cboCliente.DroppedDown = true;
            cboCliente.SelectedIndex = -1;
            txtDatosPersonales.Text = "";
            txtObservaciones.Text = "";
            txtFolio.Text = "";
            cboProdFact.SelectedIndex = -1;
            txtSubtotal.Text = "";
            txtDescuento.Text = "";
            txtIva.Text = "";
            txtTotal.Text = "";
            dgvProductos.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount != 0)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index);
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Add();
            dgvProductos.ClearSelection();
            dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.Rows.Count - 1].Cells[0];
            cboProdFact.Focus();
            cboProdFact.DroppedDown = true;
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            sql.connect();
            showData();
            //opcionesProd.Enabled = false; 
            //totalesProd.Enabled = false;
            btnEliminar.Enabled = false;
            btnImprimir.Enabled = false;
            cboProdFact.Enabled = false;
            cboCliente.Enabled = false;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= BindingContext[tbClientes, "Clientes"].Count - 1; i++)
            {
                regClientes = tbClientes.Tables["Clientes"].Rows[i];
                if (cboCliente.Text == Convert.ToString(regClientes["RazonSocial"]))
                {
                    txtDatosPersonales.Text = Convert.ToString(regClientes["Domicilio"]) + "\r\n" +
                                       Convert.ToString(regClientes["NombreCiudad"]) + ", " + Convert.ToString(regClientes["NombreEstado"]) + "\r\n" +
                                       "Codigo Postal: " + Convert.ToString(regClientes["CodigoPostal"]) + "\r\n" +
                                       Convert.ToString(regClientes["Telefono"]) + "    " + Convert.ToString(regClientes["RFC"]) + "\r\n" +
                                       Convert.ToString(regClientes["Correo"]) + "\r\n";
                    break;
                }
            }
            if (Convert.ToString(regClientes["Tipo"]) == "1")
            {
                rdbContado.Checked = true;
                txtFolio.Text = Convert.ToString(regControl["FolioVtasContado"]);
            }
            else
            {
                rdbCredito.Checked = true;
                txtFolio.Text = Convert.ToString(regControl["FolioVtasCredito"]);
            }
            opcionesProd.Enabled = true;
            btnAgregarProd.Enabled = true;
            btnEliminarProd.Enabled = true;
            btnModificarProd.Enabled = true;
            cboProdFact.Enabled = true;
            txtDescuento.Text = Convert.ToString(regClientes["Descuento"]) + "%";
            txtObservaciones.ReadOnly = false;
            dgvProductos.Rows.Add();
            cboProdFact.Focus();
            cboProdFact.DroppedDown = true;
        }

        public frmFacturas()
        {
            InitializeComponent();
        }

        void showData()
        {
            SqlCommand cmd = new SqlCommand("SELECT Estados.Id AS IdEdo, Estados.Nombre AS NombreEstado, Clientes.*, Ciudades.Nombre AS NombreCiudad " +
                    "FROM Estados INNER JOIN " +
                    "Clientes ON Estados.Id = Clientes.Estado INNER JOIN " +
                    "Ciudades ON Estados.Id = Ciudades.IdEdo AND Clientes.Ciudad = Ciudades.Id", sql.getConn());
            bdClientes = new SqlDataAdapter(cmd);
            tbClientes = new DataSet();
            bdClientes.Fill(tbClientes, "Clientes");
            for (int m = 0; m < BindingContext[tbClientes, "Clientes"].Count; m++)
            {
                BindingContext[tbClientes, "Clientes"].Position = m;
                regClientes = tbClientes.Tables["Clientes"].Rows[m];
                cboCliente.Items.Add(Convert.ToString(regClientes["RazonSocial"]));
            }

            cmd = new SqlCommand("SELECT * FROM Productos", sql.getConn());
            bdProd = new SqlDataAdapter(cmd);
            tbProd = new DataSet();
            bdProd.Fill(tbProd, "Productos");
            for (int m = 0; m < BindingContext[tbProd, "Productos"].Count; m++)
            {
                BindingContext[tbProd, "Productos"].Position = m;
                regProd = tbProd.Tables["Productos"].Rows[m];
                cboProdFact.Items.Add(Convert.ToString(regProd["NombreCorto"]));
            }

            cmd = new SqlCommand("SELECT * FROM Control", sql.getConn());
            bdControl = new SqlDataAdapter(cmd);
            tbControl = new DataSet();
            bdControl.Fill(tbControl, "Control");
            BindingContext[tbControl, "Control"].Position = 0;
            regControl = tbControl.Tables["Control"].Rows[0];
            txtIva.Text = Convert.ToString(regControl["IVA"]) + "%";
        }

        void prodSearch(string prodName)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", sql.getConn());
            bdProd = new SqlDataAdapter(cmd);
            tbProd = new DataSet();
            bdProd.Fill(tbProd, "Productos");
            for (int m = 0; m < BindingContext[tbProd, "Productos"].Count; m++)
            {
                BindingContext[tbProd, "Productos"].Position = m;
                regProd = tbProd.Tables["Productos"].Rows[m];
                if (prodName == Convert.ToString(regProd["NombreCorto"]))
                {
                    break;
                }
            }
        }
    }
}
