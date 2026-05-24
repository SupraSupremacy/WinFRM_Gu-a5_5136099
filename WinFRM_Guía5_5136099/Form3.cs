using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFRM_Guía5_5136099
{
    public partial class Form3 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        public Form3()
        {
            InitializeComponent();

            conexion cn = new conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
        }

        public void LlenarComboClientes()
        {
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id_Cliente FROM CLIENTES", conn);
                da.Fill(ds, "CLIENTES");

                cbCliente.DataSource = ds.Tables[0];
                cbCliente.DisplayMember = "id_Cliente";
                cbCliente.ValueMember = "id_Cliente";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LlenarComboClientes();
        }



        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya un cliente seleccionado
                if (cbCliente.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cliente");
                    return;
                }

                conn.Open();
                string insertPedido = "INSERT INTO PEDIDOS (id_Cliente, CantidadPedido, FechaPedido) VALUES (@id_Cliente, @CantidadPedido, @FechaPedido)";
                insert1 = new SqlCommand(insertPedido, conn);

                // Usar SelectedValue para obtener el ID del cliente
                insert1.Parameters.AddWithValue("@id_Cliente", cbCliente.SelectedValue);
                insert1.Parameters.AddWithValue("@CantidadPedido", (int)nUDcant.Value);
                insert1.Parameters.AddWithValue("@FechaPedido", dTime1.Text);

                insert1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registro agregado...", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                cbCliente.SelectedIndex = -1;
                nUDcant.Value = 0;
                dTime1.Text = "";
                lbNombreC.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue != null && cbCliente.SelectedValue != cbCliente.Text)
            {
                try
                {
                    int idCliente = (int)cbCliente.SelectedValue;
                    conn.Open();
                    string query = "SELECT NombreCliente FROM CLIENTES WHERE id_Cliente = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    string nombre = cmd.ExecuteScalar()?.ToString() ?? "";
                    conn.Close();

                    lbNombreC.Visible = true;
                    lbNombreC.Text = nombre;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar nombre: " + ex.Message);
                }
            }
        }

        private void btnLimpiarP_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedIndex = -1;
            nUDcant.Value = 0;
            dTime1.Text = "";
            lbNombreC.Text = "";
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }
    }
}