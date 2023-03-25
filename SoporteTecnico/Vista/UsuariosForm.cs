using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        string validar;
        DataTable dt = new DataTable();
        UsuarioDB usuarioDB = new UsuarioDB();
        Usuario user = new Usuario();


        private void NevoButton_Click(object sender, EventArgs e)
        {
            CodigoTextBox.Focus();
            HabilitarControles();
            validar = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ContraseñaTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            RolComboBox.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            AdjuntarButton.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ContraseñaTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            RolComboBox.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            AdjuntarButton.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ContraseñaTextBox.Clear();
            CorreoTextBox.Clear();
            RolComboBox.Text = string.Empty;
            EstaActivocheckBox.Checked = false;
            FotoPictureBox.Image = null;
        }


        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (validar == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese Un Codigo");
                    CodigoTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(NombreTextBox, "Ingrese Un Nombre");
                    NombreTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
                {
                    errorProvider1.SetError(ContraseñaTextBox, "Ingrese Una Contraseña");
                    ContraseñaTextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolComboBox.Text))
                {
                    errorProvider1.SetError(RolComboBox, "Elija Un Rol");
                    RolComboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contraseña = ContraseñaTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotoPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    user.Foto = ms.GetBuffer();

                }

                bool inserto = usuarioDB.Insentar(user);

                if (inserto)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    traerusuarios();
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("No se Guardo el Registro");
                }


            }
            else if (validar == "Modificar")
            {
                user.CodigoUsuario = CodigoTextBox.Text;
                user.Nombre = NombreTextBox.Text;
                user.Contraseña = ContraseñaTextBox.Text;
                user.Rol = RolComboBox.Text;
                user.Correo = CorreoTextBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotoPictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();

                    FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    user.Foto = ms.GetBuffer();
                }


                bool modifico = usuarioDB.editar(user);
                if (modifico)
                {
                    LimpiarControles();
                    DesabilitarControles();
                    traerusuarios();
                    MessageBox.Show("Registro Actualizado Corectamente");

                }
                else
                {
                    MessageBox.Show("No se puedo actualizar el Registro");
                }
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            validar = "Modificar";
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ContraseñaTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Contraseña"].Value.ToString();
                CorreoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                RolComboBox.Text = UsuariosDataGridView.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivocheckBox.Checked = Convert.ToBoolean(UsuariosDataGridView.CurrentRow.Cells["EstaActivo"].Value);

                byte[] miFoto = usuarioDB.devolverFoto(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

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

        private void AdjuntarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            DialogResult result = dialogo.ShowDialog();

            if (result == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(dialogo.FileName);
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            traerusuarios();
        }

        private void traerusuarios()
        {
            dt = usuarioDB.DevolverUsuarios();
            UsuariosDataGridView.DataSource = dt;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Confirmar Eliminacio", "advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    bool elimino = usuarioDB.Eliminar(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                    if (elimino)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        traerusuarios();
                        MessageBox.Show("Registro Eliminado");

                    }
                    else
                    {
                        MessageBox.Show("No Se Pudo Eliminar el Registro");
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar Un Registro");
            }
        }
    }
}
