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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text + progressBar1.Value + "%";

            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                form2 form = new form2();

                this.Visible = false;
            }
        }
    }
}
