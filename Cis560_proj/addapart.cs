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
            this.Hide();
            begincs b = new begincs();
            b.Show();
           
        }

        private void ux_AptSubmit_Click(object sender, EventArgs e)
        {
            if (ux_AptOwnerName.Text.Equals("") || ux_AptOwnerEmail.Text.Equals("") || ux_AptOwnerTel.Text.Equals("") ||
                ux_City.Text.Equals("") || ux_AptBuiltYear.Text.Equals("") || ux_AptTotalFloors.Text.Equals("") ||
                ux_AptStreet.Text.Equals("") || ux_AptAptNum.Text.Equals("") || ux_AptBedNum.Text.Equals("") ||
                ux_AptBathNum.Text.Equals("") || ux_AptMonthRent.Text.Equals("") || ux_AptDeposit.Text.Equals("") ||
                ux_AptSizesqf.Text.Equals("") || ux_AptAvailTime.Text.Equals("") || ux_AptFloorType.Text.Equals("") ||
                ux_AptFloorColor.Text.Equals("") || ux_AptCarpetType.Text.Equals("") || ux_AptCarpetColor.Text.Equals("") ||
                ux_AptNumOfParking.Text.Equals("") || ux_HeatingType.Text.Equals(""))
            {
                MessageBox.Show("Every blank need to be filled.");
            }
            else if(!int.TryParse(ux_AptOwnerTel.Text, out int value))
            {
                MessageBox.Show("Tel should be number");
            }
            else
            {
                string name = "N'" + ux_AptOwnerName.Text + "'";
                string email = "N'" + ux_AptOwnerEmail.Text + "'";
                string tel = "N'" + ux_AptOwnerTel.Text + "'";
                string cityid = "";
                string builtyear = ux_AptBuiltYear.Text;
                string totalfloor = ux_AptTotalFloors.Text;
                string street = "N'" + ux_AptStreet.Text + "'";
                string aptnum = ux_AptAptNum.Text;
                string numbed = ux_AptBedNum.Text;
                string numbeth = ux_AptBathNum.Text;
                string monthrent = ux_AptMonthRent.Text;
                string deposit = ux_AptDeposit.Text;
                string sizesqf = ux_AptSizesqf.Text;
                string averiabletime = "N'" + ux_AptAvailTime.Text + "'";
                string floortypr = "N'" + ux_AptFloorType.Text + "'";
                string floorcolor = "N'" + ux_AptFloorColor.Text + "'";
                string carpettype = "N'" + ux_AptCarpetType.Text + "'";
                string carpetclolor = "N'" + ux_AptCarpetColor.Text + "'";
                string numofparking = ux_AptNumOfParking.Text;
                string heattype = "N'" + ux_HeatingType.Text + "'";
                string timeToBusStop = "N'" + ux_AptTimeToBusStop.Text + "'";

                //---------string city to int cityID
                if (ux_City.Text.Equals("Wichita"))
                {
                    cityid = "0";
                }
                else if (ux_City.Text.Equals("Overland_Park"))
                {
                    cityid = "1";
                }
                else if (ux_City.Text.Equals("Kansas_City"))
                {
                    cityid = "2";
                }
                else if (ux_City.Text.Equals("Olathe"))
                {
                    cityid = "3";
                }
                else if (ux_City.Text.Equals("Topeka"))
                {
                    cityid = "4";
                }
                else if (ux_City.Text.Equals("Lawrence"))
                {
                    cityid = "5";
                }
                else if (ux_City.Text.Equals("Shawnee"))
                {
                    cityid = "6";
                }
                else if (ux_City.Text.Equals("Lenexa"))
                {
                    cityid = "7";
                }
                else if (ux_City.Text.Equals("Manhattan"))
                {
                    cityid = "8";
                }
                else
                {
                    cityid = "9";
                }


                string connetionString;
                SqlConnection cnn;
                connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
                cnn = new SqlConnection(connetionString);

                //----------get OwnerID----------
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";
                string output= "";
                string OName = "";
                string Tel = "";
                sql = "select O.OwnerID, O.[Name], O.Tel from proj.Owners O ";
                sql += "where O.Email = " + email + ";";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                    OName = dataReader.GetValue(1).ToString();
                    Tel = dataReader.GetValue(2).ToString();
                }



                dataReader.Close();

                if(output.Equals(""))
                {
                    sql = "INSERT proj.Owners([Name], Email, Tel) VALUES(";
                    sql += "N'" + ux_AptOwnerName.Text + "' , N'" + ux_AptOwnerEmail.Text + "' ," + ux_AptOwnerTel.Text + ");";

                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();





                    sql = "";
                    output = "";
                    OName = "";
                    Tel = "";

                    sql = "select O.OwnerID, O.[Name], O.Tel from proj.Owners O ";
                    sql += "where O.Email = " + email + ";";

                    command = new SqlCommand(sql, cnn);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        output = dataReader.GetValue(0).ToString();
                        OName = dataReader.GetValue(1).ToString();
                        Tel = dataReader.GetValue(2).ToString();
                    }

                }


                command.Dispose();
                cnn.Close();
                string ownerid = output;

                //----------insert Building----------
                cnn.Open();
                adapter = new SqlDataAdapter();
                output = "";
                sql = "";

                sql = "INSERT proj.Buildings(OwnerID, Address, CityID, YearBuilt, TotalFloors, HeatingType, TimeToBusStop) VALUES(";
                sql += ownerid + ", " + street + ", " + cityid + ", " + builtyear + ", " + totalfloor + ", " + heattype + ", " + timeToBusStop + ");";

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();



                command.Dispose();
                cnn.Close();

                //----------get BuildingID----------
                cnn.Open();
                adapter = new SqlDataAdapter();
                output = "";
                sql = "";

                sql = "select B.BuildingID from proj.Buildings B ";
                sql += "where B.Address = " + street + " and B.CityID = " + cityid + ";";

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }

                dataReader.Close();
                command.Dispose();
                cnn.Close();
                string buildingid = output;

                //----------insert Apartment----------
                cnn.Open();
                adapter = new SqlDataAdapter();
                output = "";
                sql = "";

                sql = "INSERT proj.Apartments(BuildingID, ReviewCount, AvgReviewScores, AptNumber, NumBed, NumBath, MonthRent, Deposit, Sizesqf, AvailableDate, NumOfParking, FloorType, FloorColor, CarpetType, CarpetColor) VALUES(";
                sql += buildingid + ", 0, 0, " + aptnum + ", " + numbed + ", " + numbeth + ", " + monthrent + ", " + deposit + ", " + sizesqf + ", " + averiabletime + ", " + numofparking + ", " + floortypr + ", " + floorcolor + ", " + carpettype + ", " + carpetclolor + ");";

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();


                command.Dispose();
                cnn.Close();
                MessageBox.Show("Upload Successful!");
                begincs b = new begincs();
                b.Show();
                this.Hide();
            }
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
