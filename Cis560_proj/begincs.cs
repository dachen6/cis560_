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
    public partial class begincs : Form

        
    {
        public begincs()
        {
            InitializeComponent();
        }


        private void Rent_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
            this.Hide();
        }

        private void More_Click(object sender, EventArgs e)
        {
            More m = new More();
            m.Show();
            this.Hide();
        }

        private void ux_BeginLease_Click(object sender, EventArgs e)
        {
            addapart aa = new addapart();
            aa.Show();
            this.Hide();
        }
    }
}
