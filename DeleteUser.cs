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
    public partial class DeleteUser : Form
    {
        private static string com;
        private static int res;
        public DeleteUser()
        {
            InitializeComponent();
        }
        private void DeleteUser_Load(object sender, EventArgs e)
        {
            refrch();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            com = $"EXEC DeleteUser {Int32.Parse(textBoxIdUser.Text)}";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                res = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь удален!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
            textBoxIdUser.Clear();
            refrch();

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxIdUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        public void refrch()
        {
            com = "SELECT DISTINCT [Id_UserKA], [Login], [Password], [Surname], [Name] FROM Users join Buyer on Users.[Id_UserKA] = Buyer.[Id_User]";
            MyConnection.loadingDataGridView(dataGridViewUsers, com, "Users");
        }
    }
}
