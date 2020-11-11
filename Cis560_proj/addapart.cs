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

        private void ux_AptSubmit_Click(object sender, EventArgs e)
        {
            string name = ux_AptOwnerName.Text;
            string email = ux_AptOwnerEmail.Text;
            string tel = ux_AptOwnerTel.Text;
            string city = ux_City.Text;
            string street = ux_AptStreet.Text;
            string aptnum = ux_AptAptNum.Text;
            string numbed = ux_AptBedNum.Text;
            string numbeth = ux_AptBathNum.Text;
            string monthrent = ux_AptMonthRent.Text;
            string deposit = ux_AptDeposit.Text;
            string sizesqf = ux_AptSizesqf.Text;
            string averiabletime = ux_AptAvailTime.Text;
            string Follortypr = ux_AptFloorType.Text;
            string floorcolor = ux_AptFloorColor.Text;
            string carprttype = ux_AptCarpetType.Text;
            string carpetclolor = ux_AptCarpetColor.Text;
            string numofparking = ux_AptNumOfParking.Text;




            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql, output = "";

            sql = "INSERT Proj.Cities(  [CityName] , [State],Country) VALUES (N'aaaaaaaaaaaaaaaaaa', N'KS', N'USA'); ";



            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show(output);

            command.Dispose();
            cnn.Close();
        }
    }
}
