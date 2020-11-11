using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cis560_proj
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void ux_SearchSelectButton_Click(object sender, EventArgs e)
        {


            this.Hide();
            customer_logcs cl = new customer_logcs();
            cl.Show();
        }

        private void ux_SearchReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            begincs b = new begincs();
            b.ShowDialog();
            
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

            string low = "N'" + ux_SearchLowPrice.Text + "'";
            string high = "N'" + ux_SearchHighPrice.Text + "'";
            string month = "N'" + ux_SearchAverableMonth.Text + "'";
            string score = "N'" + ux_SearchLowPrice.Text + "'";
            string bednum = "N'" + ux_SearchBedNum.Text + "'";
            string city = "N'" + ux_SearchCityName.Text + "'";
            string bus = "N'" + ux_SearchTimeToStation.Text + "'";


            if (ux_SearchWithBalcony.Checked)
            {
                string balcony = "N'WithWasherDryer'";
            }
            if (ux_SearchWithBalcony.Checked)
            {
                string washdryer = "N'ux_SearchWithWasherDryer'";
            }
            if (ux_SearchPetFriendly.Checked)
            {
                string petfriend = "N'WithWasherDryer'";
            }
            if (ux_SearchWithGym.Checked)
            {
                string gym = "N'WithWasherDryer'";
            }
            if (ux_SearchWithPool.Checked)
            {
                string pool = "N'WithWasherDryer'";
            }


        }
    }
}
