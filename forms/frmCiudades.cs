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

namespace Sistema_Inventarios
{
    public partial class frmCiudades : Form 
    {
        public frmCiudades()
        {
            InitializeComponent(); 
        }

        public SqlCommand cmd;
        SQL sql = new SQL();
        int pos = 0;
        public SqlDataAdapter bdCiudades;
        public DataSet tbCiudades;
        public DataRow regCiudades;
        string edo;

        public void showData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ciudades", sql.connect());
            bdCiudades = new SqlDataAdapter(cmd);
            tbCiudades = new DataSet();
            bdCiudades.Fill(tbCiudades, "Ciudades");
            if (pos > BindingContext[tbCiudades, "Ciudades"].Count - 1)
            {
                pos -= 1;
            }
            else if (pos <= 0)
            {
                pos = 0;
            }
            BindingContext[tbCiudades, "Ciudades"].Position = pos;
            regCiudades = tbCiudades.Tables["Ciudades"].Rows[pos];
            TxtId.Text = Convert.ToString(regCiudades["Id"]);
            TxtNombre.Text = Convert.ToString(regCiudades["Nombre"]);
            //CboEstado.Text = Convert.ToString(regCiudades["IdEdo"]);

            CboEstado.SelectedItem = Convert.ToString(regCiudades["IdEdo"]);
            SqlDataAdapter estados = new SqlDataAdapter("SELECT Nombre, Id FROM Estados", sql.getConn());
            DataTable tbEstados = new DataTable();
            estados.Fill(tbEstados);
            CboEstado.Items.Clear();
            for (int m = 0; m < tbEstados.Rows.Count; m++)
            {
                CboEstado.Items.Add(tbEstados.Rows[m]["Nombre"].ToString());
                if (Convert.ToString(tbEstados.Rows[m]["Id"]) == Convert.ToString(regCiudades["IdEdo"]))
                {
                    edo = tbEstados.Rows[m]["Nombre"].ToString();
                }
            }
            CboEstado.SelectedItem = edo;
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            pos += 1;
            showData();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            pos -= 1;
            showData();
        }
         
        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            try
            {
                pos = BindingContext[tbCiudades, "Ciudades"].Count - 1;
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    int idEdo = 1;
                    string str2 = "SELECT * FROM Estados";
                    SqlCommand cmd2 = new SqlCommand(str2, sql.connect());
                    SqlDataAdapter bd2 = new SqlDataAdapter(cmd2);
                    DataSet tb2 = new DataSet();
                    bd2.Fill(tb2, "Control");
                    for (int m = 0; m < tb2.Tables["Control"].Rows.Count; m++)
                    {
                        DataRow Reg2 = tb2.Tables["Control"].Rows[m];
                        if (Convert.ToString(Reg2["Nombre"]) == Convert.ToString(CboEstado.SelectedItem))
                        {
                            idEdo = Convert.ToInt32(Reg2["Id"]);
                        }
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE Ciudades SET " +
                                      "Nombre='" + TxtNombre.Text +
                                      "',IdEdo=" + idEdo +
                                      " WHERE Id=" + TxtId.Text, sql.connect());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Actualizados Correctamente");
                    //TBControl.Clear(BDControl, "Control");
                    //DataRow Registro = TBControl.Tables["Control"].Rows[pos];
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } 
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar a esta ciudad?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int idCiu = Convert.ToInt32(TxtId.Text);
                    SqlCommand cmd = new SqlCommand("DELETE FROM Ciudades WHERE Id = " + idCiu + ";", sql.connect());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos Eliminados Correctamente");
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Llena todos los campos.");
            }
            else
            {
                try
                {
                    if (BtnRegistrar.Text == "&Registrar")
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Ciudades VALUES (1,'') ; SELECT SCOPE_IDENTITY()", sql.getConn());
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        TxtNombre.Text = "";
                        BtnPrimero.Enabled = false;
                        BtnUltimo.Enabled = false;
                        BtnSiguiente.Enabled = false;
                        BtnAnterior.Enabled = false;
                        BtnEliminar.Enabled = false;
                        BtnActualizar.Enabled = false;
                        BtnSalir.Enabled = false;
                        CboEstado.SelectedIndex = 0;
                        //CboEstado.Enabled = true;
                        TxtId.Text = Convert.ToString(id);
                        BtnRegistrar.Text = "Aceptar";
                    }
                    else
                    {
                        int idEdo = 1;
                        string str2 = "SELECT * FROM Estados";
                        SqlCommand cmd2 = new SqlCommand(str2, sql.connect());
                        SqlDataAdapter bd2 = new SqlDataAdapter(cmd2);
                        DataSet tb2 = new DataSet();
                        bd2.Fill(tb2, "Estados");
                        for (int m = 0; m < tb2.Tables["Estados"].Rows.Count; m++)
                        {
                            DataRow Reg2 = tb2.Tables["Estados"].Rows[m];
                            if (Convert.ToString(Reg2["Nombre"]) == Convert.ToString(CboEstado.SelectedItem))
                            {
                                idEdo = Convert.ToInt32(Reg2["Id"]);
                            }
                        }
                        SqlCommand cmd = new SqlCommand ("UPDATE Ciudades SET " +
                                          "Nombre='" + TxtNombre.Text +
                                          "',IdEdo=" + idEdo +
                                          " WHERE Id=" + TxtId.Text, sql.connect());
                        cmd.ExecuteNonQuery();
                        showData();
                        MessageBox.Show("Datos Guardados Correctamente");
                        BtnPrimero.Enabled = true;
                        BtnUltimo.Enabled = true;
                        BtnSiguiente.Enabled = true;
                        BtnAnterior.Enabled = true;
                        BtnEliminar.Enabled = true;
                        BtnActualizar.Enabled = true;
                        BtnSalir.Enabled = true;
                        //CboEstado.Enabled = false;
                        BtnRegistrar.Text = "&Registrar";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }      
        }

        private void Frm_Ciudades_Load(object sender, EventArgs e)
        {
            /*
            string StrControl = "SELECT * FROM Estados";
            cmd = new SqlCommand(StrControl, sql.connect());
            BDControl = new SqlDataAdapter(cmd);
            TBControl = new DataSet();
            BDControl.Fill(TBControl, "Control");
            for (int m = 0; m < TBControl.Tables["Control"].Rows.Count; m++)
            {
                Registro = TBControl.Tables["Control"].Rows[m];
                CboEstado.Items.Add(Convert.ToString(Registro["Nombre"]));
            }
            StrControl = "SELECT C.Id, C.Nombre, E.Nombre AS Edo, E.Id AS IdEdo FROM Ciudades C INNER JOIN Estados E ON C.IdEdo = E.Id";
            cmd = new SqlCommand(StrControl, sql.connect());
            BDControl = new SqlDataAdapter(cmd);
            TBControl = new DataSet();
            BDControl.Fill(TBControl, "Control");

            Registro = TBControl.Tables["Control"].Rows[0];
            visualizaDatos();
            */
            showData();
        }
        /*
        public void visualizaDatos()
        {
            BDControl.Dispose();
            TBControl.Dispose();
            BDControl = new SqlDataAdapter(cmd);
            TBControl = new DataSet();
            BDControl.Fill(TBControl, "Control");
            TxtNombre.Text = Convert.ToString(Registro["Nombre"]);
            TxtId.Text = Convert.ToString(Registro["Id"]);
            try
            {
                CboEstado.SelectedItem = Convert.ToString(Registro["Edo"]);
            }
            catch
            {
                CboEstado.SelectedIndex = -1;
            }
        }
        */
    }
}
