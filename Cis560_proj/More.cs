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
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();




            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            
            string q1 = @"SELECT AVG(A.MonthRent) AS AverageRent, A.NumBed AS NumBed, A.NumBath AS NumBath, C.CityName AS CityName
                        FROM Proj.Apartments A 
                        INNER JOIN Proj.Buildings B ON A.BuildingID = B.BuildingID
                           INNER JOIN Proj.Cities C ON B.CityID = C.CityID
                        GROUP BY A.NumBed, A.NumBath, C.CityName
                        ORDER BY C.CityName, A.NumBed, A.NumBath;
                        ";
            SqlCommand cmd = new SqlCommand(q1, cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();


             q1 = @"DECLARE @AvgRS INT = 
                   (
                      SELECT AVG(A.AvgReviewScores)
                      FROM Proj.Apartments A
                      WHERE A.ReviewCount > 0
	                );

                With AptCTE(ApartmentID, BuildingID, ReviewCount,AvgReviewScores,AptNumber,NumBed,NumBath,MonthRent,Deposit,Sizesqf,AvailableTime,NumOfParking,FloorType,FloorColor,
                CarpetType,CarpetColor, CreatedOn, UpdatedOn) AS
                   (
                      SELECT *
                      FROM Proj.Apartments A 
                      WHERE A.AvgReviewScores > @AvgRS
                   )
                SElECT 
                   (
                      SELECT TOP 1 AC.FloorType AS FloorType
                      FROM AptCTE AC
                      GROUP BY AC.FloorType
                      ORDER BY COUNT(AC.FloorType) DESC) AS FloorType, 
                   (
                      SELECT TOP 1 AC.FloorColor AS FloorColor
                      FROM AptCTE AC
                      GROUP BY AC.FloorColor
                     ORDER BY COUNT(AC.FloorColor) DESC) AS FloorColor,
                   (
                      SELECT TOP 1 AC.CarpetType AS CarpetType
                      FROM AptCTE AC
                      GROUP BY AC.CarpetType
                      ORDER BY COUNT(AC.CarpetType) DESC) AS CarpetType, 
                   (
                      SELECT TOP 1 AC.CarpetColor AS CarpetColor
                      FROM AptCTE AC
                      GROUP BY AC.CarpetColor
                     ORDER BY COUNT(AC.CarpetColor) DESC) AS CarpetColor,
                   (
                      SELECT TOP 1 B.HeatingType AS HeatingType
                      FROM Proj.Buildings B
                         INNER JOIN Proj.Apartments A ON A.BuildingID = B.BuildingID
                            AND A.AvgReviewScores > @AvgRS
                      GROUP BY B.HeatingType
                      ORDER BY COUNT(DISTINCT B.HeatingType) DESC) AS HeatingType
                
                        ";
            cmd = new SqlCommand(q1, cnn);
            a = new SqlDataAdapter(cmd);

            dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

            dataGridView3.DataSource = dt;
            dataGridView3.AutoResizeColumns();

            q1 = @"DECLARE @AvgRS INT = 
                   (
                      SELECT AVG(A.AvgReviewScores)
                      FROM Proj.Apartments A
                      WHERE A.ReviewCount > 0
	                );
                SELECT O.Name, AVG(A.AvgReviewScores) AS AvgReviewScores
                FROM Proj.Owners O
                   INNER JOIN Proj.Buildings B ON O.OwnerID = B.OwnerID
                   INNER JOIN Proj.Apartments A ON B.BuildingID = A.BuildingID
                      AND A.AvgReviewScores >= @AvgRS
                GROUP BY O.Name
                ORDER BY AvgReviewScores DESC

              
                
                        ";
            cmd = new SqlCommand(q1, cnn);
            a = new SqlDataAdapter(cmd);

            dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

            dataGridView2.DataSource = dt;
            dataGridView2.AutoResizeColumns();





            q1 = @"
                SELECT COUNT(ApartmentID) As NumApt, C.CityName AS City
                FROM Proj.Apartments A 
                   INNER JOIN Proj.Buildings B ON B.BuildingID = A.BuildingID
                      AND B.BuildingID IN 
	                     ( 
                            SELECT DISTINCT BuildingID 
                            FROM Proj.BuildingFeatures  
                         )
                   INNER JOIN Proj.Cities C ON B.CityID = C.CityID
                WHERE A.ApartmentID IN 
                   (
                      SELECT DISTINCT ApartmentID 
                      FROM Proj.ApartmentFeatures
                      WHERE FeatureAID= 2
                   )
                GROUP BY C.CityName
                ORDER BY NumApt DESC
                
                        ";
            cmd = new SqlCommand(q1, cnn);
            a = new SqlDataAdapter(cmd);

            dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

            dataGridView4.DataSource = dt;
            dataGridView4.AutoResizeColumns();








        }

        private void Ux_MoreReturn_Click(object sender, EventArgs e)
        {
            Form bs = new begincs();
            bs.ShowDialog();
            this.Hide();
        }
    }
}
