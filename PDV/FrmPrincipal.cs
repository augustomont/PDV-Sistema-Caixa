using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            PDV.Menu.Cadastro.FrmFuncionarios frm = new Menu.Cadastro.FrmFuncionarios();
            frm.ShowDialog();
        }
    }
}
