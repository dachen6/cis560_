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
    public partial class score : Form
    {
        public score()
        {
            InitializeComponent();
        }

        private void Ux_ScoreReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            begincs b = new begincs();
            b.Show();
        }

        private void Ux_ScoreOK_Click(object sender, EventArgs e)
        {
            String score = ux_score.Text;

            if (ux_score.Text == "")
            {
                MessageBox.Show("Please input score to submit");
            }

            else
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql, output = "";
          


                sql = "select C.ReviewCount,C.AvgReviewScores from proj.Apartments C where C.ApartmentID = " + ux_apartId.Text;



                command = new SqlCommand(sql, cnn);



                dataReader = command.ExecuteReader();


                double count = 1.0;
                double scores = 1.0;
                while (dataReader.Read())

                {
                    count = Convert.ToDouble(dataReader.GetValue(0));
                    scores = Convert.ToDouble(dataReader.GetValue(1));
                }



                
                string newScore = $"{((count * scores) + Convert.ToDouble(score)) / (count + 1):0.00}";
                string newCount = (count + 1).ToString();

                dataReader.Close();

                sql = @"UPDATE proj.Apartments SET AvgReviewScores = " + newScore + ", ReviewCount = " + newCount + @", UpdatedOn = SYSDATETIMEOFFSET()
                FROM proj.Apartments C where C.ApartmentID = " + ux_apartId.Text;

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();


                command.Dispose();
                cnn.Close();
            }
            }

        private void score_Load(object sender, EventArgs e)
        {
   

            

            }
    }
}
