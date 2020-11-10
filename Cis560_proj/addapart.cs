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
    public partial class addapart : Form
    {
        public addapart()
        {
            InitializeComponent();
            ux_City.Items.Add("Dodge_city");
            ux_City.Items.Add("Garden_city");
            ux_City.Items.Add("Haysville");
            ux_City.Items.Add("Kansas_city");
            ux_City.Items.Add("Emporia");
            ux_City.Items.Add("Olathe");
            ux_City.Items.Add("Salina");
            ux_City.Items.Add("Topeka");
            ux_City.Items.Add("Lawrence");
            ux_City.Items.Add("Manhattan");
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Begin_Click(object sender, EventArgs e)
        {
            begincs b = new begincs();
            b.Show();
            this.Hide();
        }
    }
}
