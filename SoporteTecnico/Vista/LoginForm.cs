using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (UuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UuarioTextBox, "Ingrese Un Usuario");
                UuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ContraseñaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ContraseñaTextBox, "Ingrese Una Contraseña");
                ContraseñaTextBox.Clear();
                ContraseñaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //base de datos aqui
            Login login = new Login(UuarioTextBox.Text, ContraseñaTextBox.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Autenticar(login);

            if (usuario != null)
            {

                if (usuario.EstaActivo)
                {
                    //MOstramos menu
                    MenuForm menuFormulario = new MenuForm();
                    Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("Datos de Usuario Incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {

            }




        }

        private void MostrarContraseñaButton_Click(object sender, EventArgs e)
        {
            if (ContraseñaTextBox.PasswordChar == '*')
            {
                ContraseñaTextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñaTextBox.PasswordChar = '*';
            }

        }
    }
}
