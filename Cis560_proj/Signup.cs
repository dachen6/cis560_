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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Ux_SignUpOK_Click(object sender, EventArgs e)
        {
            String Name ="N'" + ux_SignUpName.Text + "'";
            String email = "N'" + ux_SignUpEmail.Text + "'";
            String Tel = "N'" + ux_SignUpTel.Text + "'";
            String password = ux_SignUpPassword.Text ;

            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql, output = "";

            sql = "INSERT Proj.Customers([Name], Email,PasswordHash,Tel) VALUES  ";
            sql += Name + email + Tel + password.GetHashCode().ToString() + "); ";


            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show(output);

            command.Dispose();
            cnn.Close();

        }

        private void Ux_SignUpReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
