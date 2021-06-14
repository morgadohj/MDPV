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



namespace MDPV
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            mostrar();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            texNombre.Text = "";
            texUsuario.Text = "";
            texContraseña.Text = "";
            bguardar.Visible = true;
            guardadCambios.Visible = false;
            


        }
        
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (texNombre.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.conexion.conexionm;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("insertar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", texNombre.Text);
                    cmd.Parameters.AddWithValue("@login", texUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", texContraseña.Text);
                    cmd.Parameters.AddWithValue("@rol", comboRol.Text);
                    cmd.Parameters.AddWithValue("@estado", "activo");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    panel4.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                
            }
        }

        private void mostrar ()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.conexion.conexionm;
                con.Open();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_idusu.Text = dataGridView1.SelectedCells[1].Value.ToString();
            texNombre.Text = dataGridView1.SelectedCells[2].Value.ToString();
            texUsuario.Text = dataGridView1.SelectedCells[3].Value.ToString();
            texContraseña.Text = dataGridView1.SelectedCells[4].Value.ToString();
            comboRol.Text = dataGridView1.SelectedCells[5].Value.ToString();
            panel4.Visible = true;
            bguardar.Visible = false;
            guardadCambios.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bregresar_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;

        }

        private void guardadCambios_Click(object sender, EventArgs e)
        {
            if (texNombre.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.conexion.conexionm;
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("editar_usuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", lbl_idusu.Text);
                    cmd.Parameters.AddWithValue("@nombre", texNombre.Text);
                    cmd.Parameters.AddWithValue("@login", texUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", texContraseña.Text);
                    cmd.Parameters.AddWithValue("@rol", comboRol.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    panel4.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex ==this.dataGridView1.Columns["Eli"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("¿Seguro que desae eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                {
                    SqlCommand cmd;

                    try
               
                       
                    {
                       foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["id_usuario"].Value);
                            string usuario = Convert.ToString(row.Cells["login"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = Conexion.conexion.conexionm;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_usuario", onekey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        mostrar();
                        
                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message);
                    }

            }
            

            } 
        }
    }
}
