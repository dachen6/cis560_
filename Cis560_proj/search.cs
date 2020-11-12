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

            string balcony = "null";
            string washdryer = "null";
            string petfriend = "null";
            string gym = "null";
            string pool = "null";
            string bednum = "null";

            string low = "N'" + ux_SearchLowPrice.Text + "'";

            if(low.Equals("N''"))
            {
                low = "null";
            }
            string high = "N'" + ux_SearchHighPrice.Text + "'";
            if (high.Equals("N''"))
            {
                high = "null";
            }
            string month = "N'" + ux_SearchAverableMonth.Text + "'";
            if (month.Equals("N''"))
            {
                month = "null";
            }
            string score = "N'" + ux_SearchLowPrice.Text + "'";
            if (score.Equals("N''"))
            {
                score = "null";
            }
             bednum = ux_SearchBedNum.Text ;
            if (bednum.Equals(""))
            {
                bednum = "null";
            }

            string city = "N'" + ux_SearchCityName.Text + "'";
            if (city.Equals("N''"))
            {
                city = "null";
            }
            string bus =  ux_SearchTimeToStation.Text;
            if (bus.Equals(""))
            {
                bus = "null";
            }
            string beth = numbeth.Text;
            if (beth.Equals(""))
            {
                beth = "null";
            }
            string averiableData = "'2020-" + ux_SearchAverableMonth.Text + "-" + date.Text+"'";

            if(ux_SearchAverableMonth.Text == "" || date.Text == "")
            {
                averiableData = "null";
            }
            if (ux_SearchWithBalcony.Checked)
            {
                 balcony = "1";
            }
            if (ux_SearchWithBalcony.Checked)
            {
                 washdryer = "2";
            }
            if (ux_SearchPetFriendly.Checked)
            {
                 petfriend = "3";
            }
            if (ux_SearchWithGym.Checked)
            {
                 gym = "1";
            }
            if (ux_SearchWithPool.Checked)
            {
                pool = "2";
            }


            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            string q = @"

            WITH QCTE(ApartmentID, BuildingID, ReviewCount, AvgReviewScores, AptNumber, NumBed, NumBath, MonthRent, Deposit, Sizesqf, AvailableDate,
                       NumOfParking, FloorType, FloorColor, CarpetType, CarpetColor) AS
               (
                  SELECT A.ApartmentID, A.BuildingID, A.ReviewCount, A.AvgReviewScores, A.AptNumber, A.NumBed, A.NumBath,
                  A.MonthRent, A.Deposit, A.Sizesqf, A.AvailableDate, A.NumOfParking, A.FloorType, A.FloorColor, A.CarpetType, A.CarpetColor
            
                  FROM Proj.Apartments A
            
                     INNER JOIN Proj.Buildings B ON A.BuildingID = B.BuildingID
            
                  WHERE(" + low + @" <= A.MonthRent and A.MonthRent <= " + high + @" OR " + high + @" IS NULL)
            
                     AND(A.NumBed = " + bednum + @" OR " + bednum + @" IS NULL)
            
                     AND(A.NumBath = " + beth + @" OR " + beth + @" IS NULL)
            
                     AND(A.AvailableDate >= " + averiableData + @" OR " + averiableData + @" IS NULL)
            
                     AND(((" + balcony + @" IS NULL) AND(" + washdryer + @" IS NULL) AND(" + petfriend + @" IS NULL)) OR A.ApartmentID IN
                       (
                        SELECT DISTINCT A1.ApartmentID
                        FROM Proj.ApartmentFeatures A1
         
                           INNER JOIN Proj.ApartmentFeatures A2 ON A1.ApartmentID = A2.ApartmentID
         
                           INNER JOIN Proj.ApartmentFeatures A3 ON A2.ApartmentID = A3.ApartmentID
         
                        WHERE (A1.FeatureAID = " + balcony + @" OR " + balcony + @" IS NULL)

                  AND(A2.FeatureAID = " + washdryer + @" OR " + washdryer + @" IS NULL)

                  AND(A3.FeatureAID = " + petfriend + @" OR " + petfriend + @" IS NULL)
              ))
         AND(((" + gym + @" IS NULL) AND(" + pool + @" IS NULL)) OR B.BuildingID IN
            (
             SELECT DISTINCT B1.BuildingID
             FROM Proj.BuildingFeatures B1

                INNER JOIN Proj.BuildingFeatures B2 ON B1.BuildingID = B2.BuildingID

             WHERE (B1.FeatureBID = " + gym + @" OR " + gym + @" IS NULL)

                  AND(B2.FeatureBID = " + pool + @" OR " + pool + @" IS NULL)
              ))
   )
SELECT Q.ApartmentID AS ApartmentID, B.Address AS Address, CityName AS City, Q.NumBed AS NumOfBedroom, Q.NumBath AS NumOfBathroom, 
       Q.MonthRent AS MonthRent, Q.AvailableDate AS AvailableDate, Q.AvgReviewScores AS AvgReviewScores, B.TimeToBusStop
FROM QCTE Q
   INNER JOIN Proj.Buildings B ON Q.BuildingID = B.BuildingID
   INNER JOIN Proj.Cities C ON B.CityID = C.CityID
WHERE(C.CityName = " + city + @" OR " + city + @" IS NULL)
   AND(B.TimeToBusStop = " + bus + @" OR " + bus + @" IS NULL)
ORDER BY ApartmentID, C.CityName, MonthRent ASC";

            //MessageBox.Show(q);

            SqlCommand cmd = new SqlCommand(q, cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

        
            ux_SearchResultTable.DataSource = dt;
            ux_SearchResultTable.AutoResizeColumns();
          

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
