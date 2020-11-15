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
    public partial class CusPagecs : Form
    {
        public CusPagecs()
        {
            InitializeComponent();
        }

        private void ux_CusReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            begincs b = new begincs();
            b.Show();
            
        }

        private void Ux_CusApartmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ux_CusOK_Click(object sender, EventArgs e)
        {
            string id = ux_CusApartmentID.Text;
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            string q = "select [ApartmentID],[BuildingID],[ReviewCount],[AvgReviewScores],[AptNumber],[NumBed],[NumBath],[MonthRent],[Deposit],[Sizesqf],[AvailableDate],[NumOfParking],[FloorType],[FloorColor],[CarpetType],[CarpetColor] from proj.Apartments a where a.ApartmentID = " + id;

            string q1 = "  select b.[Address], b.TotalFloors, b.YearBuilt,b.HeatingType from proj.Buildings b inner join proj.Apartments a on a.BuildingID = b.BuildingID where a.ApartmentID = " + id;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(q, cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand(q1, cnn);
            SqlDataAdapter a1 = new SqlDataAdapter(cmd1);

            DataTable dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);
            DataTable dt1 = new DataTable();

            a1.SelectCommand = cmd1;
            a1.Fill(dt1);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView2.DataSource = dt1;
            dataGridView2.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            score s = new score();
            s.Show();
        }
    }
}
