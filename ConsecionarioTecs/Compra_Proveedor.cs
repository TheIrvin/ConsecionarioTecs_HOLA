using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsecionarioTecs
{
    public partial class Compra_Proveedor: Form
    {
        public Compra_Proveedor()
        {
            InitializeComponent();
        }
        Conexion_BDD conSQL = new Conexion_BDD();
        string cadena;
        int tipo; 

        Gestionar_Proveedores_DGV frm_gestProveedor;  

        public Compra_Proveedor(int t, Gestionar_Proveedores_DGV parentForm)
        {
            tipo = t;
            frm_gestProveedor = parentForm;  
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_compra_Proveedor_Click(object sender, EventArgs e)
        {
            ProeevInfo_MotoComp_a_Enseñar Enviar = new ProeevInfo_MotoComp_a_Enseñar(conSQL);
            
               
            int idProveedor = Enviar.InsertarProveedor(
                txtBox_PVD_nombreEmpresa.Text, txtBox_PVD_contacto.Text, txtBox_PVD_dirección.Text, txtBox_PVD_Ciudad.Text,
                txtBox_PVD_Región.Text, txtBox_PVD_codigoPostal.Text, cBox_País.Text, txtBox_PVD_RUC.Text,
                txtBox_PVD_teléfono.Text, txtBox_PVD_Email.Text
            );

            byte[] imagenMoto = null;
            if (picBox_PVD_fotoMoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picBox_PVD_fotoMoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenMoto = ms.ToArray();
                }
            }

            Enviar.agregarMoto(
                txtBox_PVD_idMoto.Text,
                idProveedor,
                txtBox_PVD_modeloMoto.Text,
                txtBox_PVD_marcaMoto.Text,
                int.Parse(txtBox_PVD_añoMoto.Text),
                decimal.Parse(txtBox_PVD_precioMoto.Text),
                (int)upDown_PVD_Ganancia.Value,
                int.Parse(cBox_IVA_Vender.SelectedItem.ToString()),
                int.Parse(txtBox_PVD_totalMotos.Text),
                imagenMoto
            );

            if (frm_gestProveedor != null)
            {
                frm_gestProveedor.dgv_Gestionar_Proveedor.DataSource = conSQL.retornaRegistros("SELECT * FROM Enseñar_Motos;");
                frm_gestProveedor.pnl_btn_Nuevo_proveedor.Visible = false;
            }

            this.Close();
        }
        private void LimpiarCampos()
        {
            txtBox_PVD_idMoto.Clear();
            txtBox_PVD_nombreEmpresa.Clear();
            txtBox_PVD_contacto.Clear();
            txtBox_PVD_dirección.Clear();
            txtBox_PVD_Ciudad.Clear();
            txtBox_PVD_Región.Clear();
            txtBox_PVD_codigoPostal.Clear();
            cBox_País.SelectedIndex = -1;
            txtBox_PVD_RUC.Clear();
            txtBox_PVD_teléfono.Clear();
            txtBox_PVD_Email.Clear();
            txtBox_PVD_modeloMoto.Clear();
            txtBox_PVD_marcaMoto.Clear();
            txtBox_PVD_añoMoto.Clear();
            txtBox_PVD_precioMoto.Clear();
            upDown_PVD_Ganancia.Value = upDown_PVD_Ganancia.Minimum;
            cBox_IVA_Vender.SelectedIndex = -1;
            txtBox_PVD_totalMotos.Clear();
            picBox_PVD_fotoMoto.Image = null;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Compra_Proveedor_Load(object sender, EventArgs e)
        {
            txtBox_PVD_idMoto.BringToFront();
            txtBox_PVD_nombreEmpresa.BringToFront();
            txtBox_PVD_RUC.BringToFront();
            txtBox_PVD_dirección.BringToFront();
            txtBox_PVD_contacto.BringToFront();
            txtBox_PVD_Email.BringToFront();
            txtBox_PVD_teléfono.BringToFront();
            txtBox_PVD_modeloMoto.BringToFront();
            txtBox_PVD_marcaMoto.BringToFront();
            txtBox_PVD_añoMoto.BringToFront();
            txtBox_PVD_precioMoto.BringToFront();
            txtBox_PVD_totalMotos.BringToFront();
        }

        private void txtBox_PVD_RUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txtBox_PVD_teléfono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_PVD_totalMotos_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_aggImagen_ventaMoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picBox_PVD_fotoMoto.Image = new Bitmap(openFileDialog.FileName);
                picBox_PVD_fotoMoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtBox_PVD_añoMoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBox_PVD_precioMoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtBox_PVD_idMoto_Leave(object sender, EventArgs e)
        {
            if (txtBox_PVD_idMoto.Text.Length != 4)
            {
                MessageBox.Show("Ingrese un ID de 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_PVD_idMoto.Focus();
            }
        }

        private void txtBox_PVD_idMoto_TextChanged(object sender, EventArgs e)
        {
            string idMoto = txtBox_PVD_idMoto.Text.Trim();

            // ✅ Verifica si el usuario ingresó 4 caracteres
            if (idMoto.Length == 4)
            {
                ProeevInfo_MotoComp_a_Enseñar Enviar = new ProeevInfo_MotoComp_a_Enseñar(conSQL);

                // ✅ Si el ID ya existe, muestra un mensaje
                if (Enviar.VerificarID_Moto(idMoto))
                {
                    MessageBox.Show("El ID de la moto ya está registrado. Ingrese un ID diferente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtBox_PVD_idMoto.Focus(); // 🔥 Vuelve a enfocar el TextBox
                    txtBox_PVD_idMoto.SelectAll(); // 🔥 Selecciona el texto para que el usuario lo cambie
                }
            }
        }

        private void txtBox_PVD_nombreEmpresa_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtBox_PVD_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBox_PVD_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBox_PVD_Región_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta letras.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBox_PVD_codigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtBox_PVD_nombreEmpresa_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBox_PVD_dirección_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBox_PVD_teléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtBox_PVD_RUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
