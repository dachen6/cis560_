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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void search_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = "";
            


            sql = "select C.Tel,S.StartData from proj.Customers C INNER JOIN Proj.ResideRecords S ON C.CustomerID = S.CustomerID; ";
            


            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output = output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=mssql.cs.ksu.edu;Database=da6;User Id=da6;Password=wanglaoju!2;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
           
            SqlDataAdapter adapter = new SqlDataAdapter();
            string q = query_box.Text;
            SqlCommand cmd = new SqlCommand(q, cnn);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
           
            DataTable dt = new DataTable();

            a.SelectCommand = cmd;
            a.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
