using System;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventarios.forms 
{
    public partial class datosEmpresa : Form 
    {
        SQL sql = new SQL();
        string edo;
        string cd;
        Boolean inn = false;
        SqlDataAdapter ciudades;
        DataTable tbCiudades;
        public datosEmpresa()
        {
            InitializeComponent();
        }

        private void datosEmpresa_Load(object sender, EventArgs e)
        {
            sql.connect();
            sql.getConn().Close();
            showData();
        }

        private void showData()
        {
            try
            {
                string queryComm = "SELECT * FROM Control";
                SqlCommand cmd = new SqlCommand(queryComm, sql.getConn());
                SqlDataAdapter dbControl = new SqlDataAdapter(cmd);
                DataSet tbControl = new DataSet();
                dbControl.Fill(tbControl, "Control");
                DataRow reg = tbControl.Tables["Control"].Rows[0];
                txtNombre.Text = Convert.ToString(reg["NombreEmpresa"]);
                txtDomicilio.Text = Convert.ToString(reg["Domicilio"]);
                txtRFC.Text = Convert.ToString(reg["RFC"]);
                txtTelefono.Text = Convert.ToString(reg["Telefono"]);
                txtCp.Text = Convert.ToString(reg["CodigoPostal"]);
                txtCorreo.Text = Convert.ToString(reg["Correo"]);
                txtFactCred.Text = Convert.ToString(reg["FolioVtasCredito"]);
                txtFactCont.Text = Convert.ToString(reg["FolioVtasContado"]);
                txtRemision.Text = Convert.ToString(reg["FolioVtasRemision"]);
                txtFactComp.Text = Convert.ToString(reg["FolioCompras"]);
                txtCotizacion.Text = Convert.ToString(reg["FolioCotizacion"]);
                txtUsuario.Text = Convert.ToString(reg["Usuario"]);
                txtClave.Text = Convert.ToString(reg["Password"]);
                txtIva.Text = Convert.ToString(reg["IVA"]);
                edo = Convert.ToString(reg["Estado"]);
                cd = Convert.ToString(reg["Ciudad"]);
                byte[] byteImg = ((byte[])reg["Logo"]);
                pctLogo.Image = ByteArrayToImage(byteImg);
                SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                DataTable tbEstados = new DataTable();
                estados.Fill(tbEstados);
                for (int m = 0; m < tbEstados.Rows.Count; m++)
                {
                    cboEstado.Items.Add(tbEstados.Rows[m]["Nombre"].ToString());
                    if (Convert.ToString(tbEstados.Rows[m]["Id"]) == Convert.ToString(reg["Estado"]))
                    {
                        edo = tbEstados.Rows[m]["Nombre"].ToString();
                    }
                }
                cboEstado.SelectedItem = edo;
                updateCiudad();

                txtNombre.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        
        public void updateCiudad()
        {
            ciudades = new SqlDataAdapter("SELECT C.Nombre, C.Id FROM Estados E INNER JOIN Ciudades C ON E.Id = C.IdEdo WHERE E.Nombre = '" + Convert.ToString(edo) + "';", sql.getConn());
            tbCiudades = new DataTable();
            ciudades.Fill(tbCiudades);
            string selected = "";
            Boolean flag = false;
            for (int m = 0; m < tbCiudades.Rows.Count; m++)
            {
                cboCiudad.Items.Add(tbCiudades.Rows[m]["Nombre"].ToString());
                if (Convert.ToInt16(tbCiudades.Rows[m]["Id"]) == Convert.ToInt16(cd))
                {
                    selected = tbCiudades.Rows[m]["Nombre"].ToString();
                    flag = true;
                }
                if (flag)
                {
                    cboCiudad.SelectedIndex = 0;
                }
            }
            cboCiudad.SelectedItem = selected;
            tbCiudades.Clear();
            ciudades.Dispose();
        }
        
        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inn)
            {
                cboCiudad.Items.Clear();
                edo = Convert.ToString(cboEstado.SelectedItem);
                updateCiudad();
                try
                {
                    cboCiudad.SelectedIndex = 0;
                }
                catch
                {
                    cboCiudad.Text = "";
                }
            }
            else 
            { 
                inn = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pctLogo.Image = Image.FromFile(imagen);
                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDomicilio.Text == "" || cboEstado.Text == "" || cboCiudad.Text == "" || txtCp.Text == "" || txtRFC.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "" 
                || txtFactComp.Text == "" || txtFactCont.Text == "" || txtFactCred.Text == "" || txtRemision.Text == "" || txtCotizacion.Text == "" || txtIva.Text == "" || txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    SqlCommand cmd = sql.getConn().CreateCommand();
                    int idEdo = 0;
                    int idCd = 0;

                    SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
                    DataTable tbEstados = new DataTable();
                    estados.Fill(tbEstados);
                    for (int m = 0; m < tbEstados.Rows.Count; m++)
                    {
                        if (Convert.ToString(cboEstado.SelectedItem) == tbEstados.Rows[m]["Nombre"].ToString())
                        {
                            idEdo = Convert.ToInt16(tbEstados.Rows[m]["Id"]);
                        }
                    }
                    ciudades = new SqlDataAdapter("SELECT C.Nombre, C.Id FROM Estados E INNER JOIN Ciudades C ON E.Id = C.IdEdo WHERE E.Nombre = '" + Convert.ToString(edo) + "';", sql.getConn());
                    tbCiudades = new DataTable();
                    ciudades.Fill(tbCiudades);
                    for (int m = 0; m < tbCiudades.Rows.Count; m++)
                    {
                        if (Convert.ToString(cboCiudad.SelectedItem) == tbCiudades.Rows[m]["Nombre"].ToString())
                        {
                            idCd = Convert.ToInt16(tbCiudades.Rows[m]["Id"]);
                        }
                    }
                    sql.getConn().Open();
                    cmd.CommandText = "UPDATE Control SET " +
                                     "NombreEmpresa='" + txtNombre.Text + "'," +
                                     "Domicilio='" + txtDomicilio.Text + "'," +
                                     "RFC='" + txtRFC.Text + "'," +
                                     "Telefono='" + txtTelefono.Text + "'," +
                                     "CodigoPostal='" + txtCp.Text + "'," +
                                     "Correo='" + txtCorreo.Text + "'," +
                                     "FolioVtasCredito=" + txtFactCred.Text + "," +
                                     "FolioVtasContado=" + txtFactCont.Text + "," +
                                     "FolioVtasRemision=" + txtRemision.Text + "," +
                                     "FolioCompras=" + txtFactComp.Text + "," +
                                     "FolioCotizacion=" + txtCotizacion.Text + "," +
                                     "Usuario='" + txtUsuario.Text + "'," +
                                     "Password='" + txtClave.Text + "'," +
                                     "IVA='" + txtIva.Text + "'";
                    cmd.ExecuteNonQuery();

                    byte[] byteLogo = ImageToByteArray(pctLogo.Image);
                    string query = "Update Control SET Logo = @Logo";
                    SqlCommand cmdLogo = new SqlCommand(query, sql.getConn());
                    cmdLogo.Parameters.AddWithValue("@Logo", byteLogo);
                    cmdLogo.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Control SET " +
                                    "Estado=" + idEdo + "," +
                                    "Ciudad=" + idCd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado Correctamente");
                    sql.getConn().Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteImg)
        {
            MemoryStream ms = new MemoryStream(byteImg);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
    }
}
