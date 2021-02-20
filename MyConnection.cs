using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    class MyConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection() { 
                ConnectionString = "Data Source=DESKTOP-1L7Q3KJ;Initial Catalog=testsuka;Integrated Security=True"
            };
        }
        public static void comboBoxLoading(ComboBox comboBox, string cmd, string column)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox.Items.Add(sqlDataReader[column]);
                }
                sqlConnection.Close();
            }
        }
        public static void loadingDataGridView(DataGridView dataGridView, string cmd, string table)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, sqlConnection);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, table);
                dataGridView.DataSource = dataSet.Tables[table].DefaultView;
            }
        }
        public static void textBoxLoading(TextBox textBox, string cmd)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                SqlDataReader rd;
                rd = sqlCommand.ExecuteReader();
                while (rd.Read())
                {
                    textBox.Text = rd[0].ToString();
                }
                sqlConnection.Close();
            }
        }
        public static void richTextBoxLoading(RichTextBox richTextBox, string cmd)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                SqlDataReader rd;
                rd = sqlCommand.ExecuteReader();
                while (rd.Read())
                {
                    richTextBox.Text = rd[0].ToString();
                }
                sqlConnection.Close();
            }
        }
        public static void listBoxOrder(ListBox listBox, string cmd)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                SqlDataReader rd;
                rd = sqlCommand.ExecuteReader();
                while (rd.Read())
                {
                    listBox.Items.Add(rd[0].ToString());
                }
                sqlConnection.Close();
            }
        }
    }
}
