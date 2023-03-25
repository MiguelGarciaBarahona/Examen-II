using Datos;
using Entidades;
using System;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }
        string validar;
        private void NevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            CodigoCliTextBox.Focus();
            validar = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigoCliTextBox.Enabled = true;
            NombreCliTextBox.Enabled = true;
            DomicilioTextBox.Enabled = true;
            CorreoClieTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;

        }
        private void BloquearControles()
        {
            CodigoCliTextBox.Enabled = false;
            NombreCliTextBox.Enabled = false;
            DomicilioTextBox.Enabled = false;
            CorreoClieTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
        }
        private void Limpiar()
        {
            CodigoCliTextBox.Clear();
            NombreCliTextBox.Clear();
            DomicilioTextBox.Clear();
            CorreoClieTextBox.Clear();
            TelefonoTextBox.Clear();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            BloquearControles();
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (validar == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoCliTextBox.Text))
                {
                    errorProvider1.SetError(CodigoCliTextBox, "Ingrese Un Codigo");
                    CodigoCliTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombreCliTextBox.Text))
                {
                    errorProvider1.SetError(NombreCliTextBox, "Ingrese El Nombre");
                    NombreCliTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(DomicilioTextBox.Text))
                {
                    errorProvider1.SetError(DomicilioTextBox, "Ingrese El Domicilio");
                    DomicilioTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(CorreoClieTextBox.Text))
                {
                    errorProvider1.SetError(CorreoClieTextBox, "Ingrese El Correo");
                    CorreoClieTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(TelefonoTextBox.Text))
                {
                    errorProvider1.SetError(TelefonoTextBox, "Ingrese Telefono");
                    TelefonoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                //base de datos

                Clientes cliente = new Clientes();
                cliente.CodCliente = CodigoCliTextBox.Text;
                cliente.NombreClie = NombreCliTextBox.Text;
                cliente.DireccionClie = DomicilioTextBox.Text;
                cliente.correoclie = CorreoClieTextBox.Text;
                cliente.Telefono = TelefonoTextBox.Text;


            }
            else if (validar == "Modificar")
            {

            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            TipoOperacion = "Modificar";
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñaTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                CorreoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                RolComboBox.Text = UsuariosDataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                est.Checked = Convert.ToBoolean(UsuariosDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] miFoto = UsuarioDB.devolverFoto(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                if (miFoto.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotoPictureBox.Image = System.Drawing.Bitmap.FromStream(ms);
                }

                HabilitarControles();
            }
            else
            {

                MessageBox.Show("Seleccione un Registro");
            }
        }
    }
}
