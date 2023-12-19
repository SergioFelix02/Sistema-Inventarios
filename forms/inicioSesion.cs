using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Sistema_Inventarios.forms
{
    public partial class inicioSesion : Form
    {
        SQL sql = new SQL();
        int intentos = 3;

        public inicioSesion()
        {
            InitializeComponent(); 
        } 
      
        private void Login_Load(object sender, EventArgs e)
        {
            sql.connect();
            try
            {
                string queryComm = "SELECT * FROM Control";
                SqlCommand cmd = new SqlCommand(queryComm, sql.getConn());
                SqlDataAdapter dbControl = new SqlDataAdapter(cmd);
                DataSet tbControl = new DataSet();
                dbControl.Fill(tbControl, "Control"); 
                DataRow reg = tbControl.Tables["Control"].Rows[0];
                byte[] byteImg = ((byte[])reg["Logo"]);
                pictureBox1.Image = ByteArrayToImage(byteImg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
         
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryComm = "SELECT Usuario, Password FROM Control";
                SqlCommand cmd = new SqlCommand(queryComm, sql.getConn());
                SqlDataAdapter dbControl = new SqlDataAdapter(cmd);
                DataSet tbControl = new DataSet();
                dbControl.Fill(tbControl, "Control");
                DataRow reg = tbControl.Tables["Control"].Rows[0];
                if (intentos == 0)
                {
                    MessageBox.Show("Se acabaron los intentos...");
                    txtUsuario.Enabled = false;
                    txtContra.Enabled = false;
                    txtUsuario.Text = "";
                    txtContra.Text = "";
                }
                else if (txtUsuario.Text == Convert.ToString(reg["Usuario"]) && (txtContra.Text == Convert.ToString(reg["Password"])))
                {
                    ventanaPrincipal ventanaPrincipal = new ventanaPrincipal();
                    this.Hide();
                    ventanaPrincipal.ShowDialog();
                    Dispose();
                    Close();
                }
                else
                {
                    intentos--;
                    MessageBox.Show("Datos Incorrectos!!!. Te quedan " + intentos + " intentos...");
                    txtUsuario.Text = "";
                    txtContra.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public System.Drawing.Image ByteArrayToImage(byte[] byteImg)
        {
            MemoryStream ms = new MemoryStream(byteImg);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
    }
}
