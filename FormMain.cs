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
    public partial class FormMain : Form
    {
        private static string com;
        public FormMain()
        {
            InitializeComponent();
            btnFormSignup.Enabled = false;
            btnFormRegistration.Enabled = true;
        }
        private int roleUser;
        private void btnFormRegistration_Click(object sender, EventArgs e)
        {
            Class.openChildForm(new FormForRegistration(), panel);
            btnFormRegistration.Enabled = false;
            textBoxLoginUser.Clear();
            textBoxPasswordUser.Clear();
            textBoxLoginUser.Visible = false;
            textBoxPasswordUser.Visible = false;
            labelLogin.Visible = false;
            labelPassword.Visible = false;
            btnSingup.Visible = false;
            btnFormSignup.Enabled = true;
        }
        private void btnFormSignup_Click(object sender, EventArgs e)
        {
            Class.closingChildForm(new FormForRegistration());
            btnFormSignup.Enabled = false;
            textBoxLoginUser.Visible = true;
            textBoxPasswordUser.Visible = true;
            labelLogin.Visible = true;
            labelPassword.Visible = true;
            btnSingup.Visible = true;
            btnFormRegistration.Enabled = true;
        }
        private void btnSingup_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxLoginUser.Text;
            string passwordUser = textBoxPasswordUser.Text;
            com = "SELECT * FROM Users WHERE [Login] = @uL AND [Password] = @uP";

            AccountLogin(com, loginUser, passwordUser);

            com = "SELECT [Id_Role] FROM Users WHERE [Login] = @uL AND [Password] = @uP";
            roleUser = RoleUser(com, loginUser, passwordUser);
            switch (roleUser)
            {
                case (1):
                    LoadingFormAdmin();
                    break;
                case (2):
                    LoadingFormUser(loginUser, passwordUser);
                    break;
                default:
                    break;
            }
        }
        private void AccountLogin(string cmd, string login, string pass) {
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                DataTable table = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass;


                if (textBoxLoginUser.Text == "" || textBoxPasswordUser.Text == "")
                {
                    MessageBox.Show("Заполните поля");
                }
                else
                {
                    dataAdapter.SelectCommand = sqlCommand;
                    dataAdapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден или некорректно введены данные!");
                    }
                }
                connection.Close();
            }
            com = "SELECT Buyer.[Id_User] FROM Buyer join Users on Buyer.[Id_User] = Users.[Id_UserKA] WHERE [Login] = @uL AND [Password] = @uP";
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass;
                Class.idUser = Convert.ToInt32(sqlCommand.ExecuteScalar());
                connection.Close();
            }
            com = "SELECT Buyer.[Id_Buyer] FROM Buyer join Users on Buyer.[Id_User] = Users.[Id_UserKA] WHERE [Login] = @uL AND [Password] = @uP";
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass;
                Class.idBuyer = Convert.ToInt32(sqlCommand.ExecuteScalar());
                connection.Close();
            }
        }
        private int RoleUser(string cmd, string login, string pass)
        {
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                int temp;
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass;
                temp = Convert.ToInt32(sqlCommand.ExecuteScalar()); // Роль
                connection.Close();
                return temp;
            }

        }
        private void LoadingFormAdmin()
        {
            Administration formAdmin = new Administration();
            formAdmin.Owner = this;
            OpenFormMain(formAdmin);
            formAdmin.Show();
        }
        private void LoadingFormUser(string login, string pass)
        {
            com = "SELECT [Id_UserKA] FROM Users WHERE [Login] = @uL AND [Password] = @uP";
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, connection);
                sqlCommand.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
                sqlCommand.Parameters.Add("@uP", SqlDbType.VarChar).Value = pass;
                Class.idUser = Convert.ToInt32(sqlCommand.ExecuteScalar()); // Роль
                connection.Close();
            }
            User formUser = new User();
            formUser.Owner = this;
            OpenFormMain(formUser);
            formUser.Show();
        }
        public void OpenFormMain(Form form)
        {
            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                MessageBox.Show("До свидания!", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
                textBoxLoginUser.Clear();
                textBoxPasswordUser.Clear();
            };
        }
    }
}
