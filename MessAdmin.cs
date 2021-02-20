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

namespace Coursework
{
    public partial class MessAdmin : Form
    {
        private static string com;
        private static int idMess, res;
        public MessAdmin()
        {
            InitializeComponent();
        }
        private void MessAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Вы, как и покупатель, видите \nтолько последнее сообщение. Старайтесь уместить свои мысли в одно сообщение.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            com = "SELECT DISTINCT Buyer.[Id_User], CONCAT(Buyer.[Surname], ' ', Buyer.[Name]) 'Чел' FROM Buyer WHERE [Id_Buyer] != 1";
            MyConnection.comboBoxLoading(comboBoxBuyer, com, "Чел");
        }
        private void comboBoxBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = comboBoxBuyer.SelectedIndex + 2;
            com = $"SELECT TOP 1 [MessageB] FROM MessageBuyer join Buyer on MessageBuyer.[Id_Buyer] = Buyer.[Id_Buyer] WHERE Buyer.[Id_User] = {id} ORDER BY MessageBuyer.[Id_BuyerMessKA] DESC";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                try
                {
                    richTextBoxMessBuyer.Text = Convert.ToString(sqlCommand.ExecuteScalar());
                    richTextBoxMessAdmin.Enabled = true;
                    buttonSendMess.Enabled = true;
                    com = $"SELECT TOP 1 MessageBuyer.[Id_BuyerMessKA] FROM MessageBuyer join Buyer on MessageBuyer.[Id_Buyer] = Buyer.[Id_Buyer] WHERE Buyer.[Id_User] = {comboBoxBuyer.SelectedIndex + 2} ORDER BY [MessageB] DESC";
                    sqlCommand.CommandText = com;
                    idMess = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
                catch
                {
                    MessageBox.Show("Сообщений нет!");
                }
                sqlConnection.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendMess_Click(object sender, EventArgs e)
        {
            if (richTextBoxMessAdmin.Text.Length != 0)
            {
                com = $"INSERT INTO MessageAdmin VALUES ({idMess}, '{richTextBoxMessAdmin.Text}')";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    res = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Вы ничего не написали!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
