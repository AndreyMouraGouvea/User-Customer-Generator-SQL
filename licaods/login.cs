using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licaods
{
    public partial class login : Form
    {
        public static string nivel;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbusuarioTableAdapter.FillLogin(cadastroDataSet.tbusuario, txtLogin.Text, txtSenha.Text);
            if ((txtLogin.Text == "adm" && txtSenha.Text == "123") ||
                tbusuarioBindingSource.Count > 0)
            {
                if (tbusuarioBindingSource.Count > 0) {
                    nivel = cadastroDataSet.tbusuario.Rows[tbusuarioBindingSource.Position][cadastroDataSet.tbusuario.sg_nivelColumn].ToString();
                }else
                {
                    nivel = "1";
                }
                    frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbusuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbusuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tbusuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbusuarioTableAdapter.Fill(this.cadastroDataSet.tbusuario);

        }
    }
}
