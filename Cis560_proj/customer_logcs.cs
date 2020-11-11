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
    public partial class customer_logcs : Form
    {
        public customer_logcs()
        {
            InitializeComponent();
        }

        private void Ux_LogReturn_Click(object sender, EventArgs e)
        {
            begincs sch = new begincs();
            sch.ShowDialog();
            this.Hide();
        }

        private void Ux_LogSignUp_Click(object sender, EventArgs e)
        {
            Signup su = new Signup();
            su.ShowDialog();
            this.Hide();
        }

        private void Ux_LogSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                string email = "N'" + ux_LogUserEmail.Text + "'";
                string password = ux_LogPassword.Text;


                string connetionString;
                SqlConnection cnn;
                connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                string sql, output = "";



                sql = "select * from proj.Customers C ";
                sql += "where C.Email = " + email + "and C.PasswordHash = " + password + ";";



                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetValue(0).ToString();
                }
                MessageBox.Show(output);
                dataReader.Close();
                command.Dispose();
                cnn.Close();
                this.Hide();
                CusPagecs cs = new CusPagecs();
                cs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong username or password");
            }

        }
    }
}
