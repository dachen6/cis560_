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
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void Ux_MoreReturn_Click(object sender, EventArgs e)
        {
            Form bs = new begincs();
            bs.ShowDialog();
            this.Hide();
        }
    }
}
