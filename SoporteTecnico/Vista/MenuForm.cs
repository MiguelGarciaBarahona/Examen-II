using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm userform = new UsuariosForm();
            userform.MdiParent = this;
            userform.Show();
        }

        private void ClientesToolStripButton_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.MdiParent = this;
            clienteForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
