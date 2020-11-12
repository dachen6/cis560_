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

            string balcony = null;
            string washdryer = null;
            string petfriend = null;
            string gym = null;
            string pool = null;


            string low = "N'" + ux_SearchLowPrice.Text + "'";
            string high = "N'" + ux_SearchHighPrice.Text + "'";
            string month = "N'" + ux_SearchAverableMonth.Text + "'";
            string score = "N'" + ux_SearchLowPrice.Text + "'";
            int bednum = Convert.ToInt16(ux_SearchBedNum.Text);
            string city = "N'" + ux_SearchCityName.Text + "'";
            string bus = "N'" + ux_SearchTimeToStation.Text + "'";
            int  beth = atoi(numbeth.Text);
            string averiableData = "2020-" + ux_SearchAverableMonth.Text + "-" + date.Text;

            if (ux_SearchWithBalcony.Checked)
            {
                 balcony = 1;
            }
            if (ux_SearchWithBalcony.Checked)
            {
                 washdryer = 2;
            }
            if (ux_SearchPetFriendly.Checked)
            {
                 petfriend = 3;
            }
            if (ux_SearchWithGym.Checked)
            {
                 gym = 1;
            }
            if (ux_SearchWithPool.Checked)
            {
                pool = 2;
            }

            string sql;



            sql = "WITH QCTE(ApartmentID, BuildingID, ReviewCount, AvgReviewScores, AptNumber, NumBed, NumBath, MonthRent, Deposit, Sizesqf, AvailableDate,";
            sql += "NumOfParking, FloorType, FloorColor, CarpetType, CarpetColor) AS";
            sql += "(SELECT A.ApartmentID, A.BuildingID, A.ReviewCount, A.AvgReviewScores, A.AptNumber, A.NumBed, A.NumBath,";
            sql += " A.MonthRent, A.Deposit, A.Sizesqf, A.AvailableDate, A.NumOfParking, A.FloorType, A.FloorColor, A.CarpetType, A.CarpetColor";
            sql += "FROM Proj.Apartments A";
            sql += "INNER JOIN Proj.Buildings B ON A.BuildingID = B.BuildingID";
            sql += " WHERE(@Rentlo <= A.MonthRent and A.MonthRent <= @Renthi OR @Renthi IS NULL)";
            sql += "AND(A.NumBed = @NumBed OR @NumBed IS NULL)";
            sql += "AND(A.NumBath = @NumBath OR @NumBath IS NULL)";


            sql += "AND(A.AvailableDate >= @AvailableDate OR @AvailableDate IS NULL)";

            sql += " AND(((@FeatureA1 IS NULL) AND(@FeatureA2 IS NULL) AND(@FeatureA3 IS NULL)) OR A.ApartmentID IN";
            sql += "(SELECT DISTINCT A1.ApartmentID";
            sql += " FROM Proj.ApartmentFeatures A1";
            sql += "INNER JOIN Proj.ApartmentFeatures A2 ON A1.ApartmentID = A2.ApartmentID";
            sql += "INNER JOIN Proj.ApartmentFeatures A3 ON A2.ApartmentID = A3.ApartmentID";
            sql += "WHERE (A1.FeatureAID = @FeatureA1 OR @FeatureA1 IS NULL)";

            sql += "AND(A2.FeatureAID = @FeatureA2 OR @FeatureA2 IS NULL)";

            sql += "AND(A3.FeatureAID = @FeatureA3 OR @FeatureA3 IS NULL)))";
            sql += " AND(((@FeatureB1 IS NULL) AND(@FeatureB2 IS NULL)) OR B.BuildingID IN(";
            sql += " SELECT DISTINCT B1.BuildingID";
            sql += "FROM Proj.BuildingFeatures B1";

            sql += "INNER JOIN Proj.BuildingFeatures B2 ON B1.BuildingID = B2.BuildingID";
            sql += "WHERE (B1.FeatureBID = @FeatureB1 OR @FeatureB1 IS NULL)";

            sql += "AND(B2.FeatureBID = @FeatureB2 OR @FeatureB2 IS NULL))))";
            sql += "SELECT Q.ApartmentID AS ApartmentID, B.Address AS Address, CityName AS City, Q.NumBed AS NumOfBedroom, Q.NumBath AS NumOfBathroom, ";
            sql += " Q.MonthRent AS MonthRent, Q.AvailableDate AS AvailableDate, Q.AvgReviewScores AS AvgReviewScores, B.TimeToBusStop";
            sql += "FROM QCTE Q";
            sql += "INNER JOIN Proj.Buildings B ON Q.BuildingID = B.BuildingID";
            sql += "INNER JOIN Proj.Cities C ON B.CityID = C.CityID";
            sql += "WHERE(C.CityName = @CityName OR @CityName IS NULL)";
            sql += "AND(B.TimeToBusStop = @Bus OR @Bus IS NULL)";
            sql += "ORDER BY ApartmentID, C.CityName, MonthRent ASC";

            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            command = new SqlCommand(sql, cnn);



            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            ux_SearchResultTable.DataSource = dt;
            ux_SearchResultTable.AutoResizeColumns();

            command.Dispose();
            cnn.Close();

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
