using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cis560_proj
{
    public partial class customer_logcs : Form
    {
        public customer_logcs()
        {
            InitializeComponent();
        }

        private void Ux_LogReturn_Click(object sender, EventArgs e)
        {
            Form sch = new search();
            sch.ShowDialog();
            this.Hide();
        }

        private void Ux_LogSignUp_Click(object sender, EventArgs e)
        {
            Form su = new Signup();
            su.ShowDialog();
            this.Hide();
        }

        private void Ux_LogSignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
