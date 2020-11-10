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
            country.Items.Add("Dodge_city");
            country.Items.Add("Garden_city");
            country.Items.Add("Haysville");
            country.Items.Add("Kansas_city");
            country.Items.Add("Emporia");
            country.Items.Add("Olathe");
            country.Items.Add("Salina");
            country.Items.Add("Topeka");
            country.Items.Add("Lawrence");
            country.Items.Add("Manhattan");
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
