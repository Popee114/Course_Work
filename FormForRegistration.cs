using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormForRegistration : Form
    {
        public FormForRegistration()
        {
            InitializeComponent();
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (StringIsValid(textBoxRegLogin.Text) == true && StringIsValid(textBoxRegPassword.Text) == true && StringIsValid(textBoxRegConfirmPassword.Text) == true)
            {
                string Regpassword = textBoxRegPassword.Text;
                string RegConfirmpassword = textBoxRegConfirmPassword.Text;
                string com = $"exec Registration '{textBoxRegLogin.Text}', '{textBoxRegPassword.Text}', '{textBoxRegSurname.Text}', '{textBoxRegName.Text}', '{textBoxRegEmail.Text}'";
                if (Regpassword == RegConfirmpassword)
                {
                    textBoxRegConfirmPassword.ForeColor = SystemColors.WindowText;
                    RegUser(com);
                }
                else
                {
                    textBoxRegConfirmPassword.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("В логин или пароль \nвведены недопустимые символы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegUser(string cmd)
        {
            using (SqlConnection connection = new MyConnection().GetConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, connection);
                if (sqlCommand.ExecuteNonQuery() == 2)
                {
                    MessageBox.Show("Аккаунт зарегистрирован!\nНажмите на кнопку 'Войти', чтобы продолжить.", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxRegLogin.Clear();
                    textBoxRegPassword.Clear();
                    textBoxRegSurname.Clear();
                    textBoxRegName.Clear();
                    textBoxRegEmail.Clear();
                    textBoxRegConfirmPassword.Clear();
                    using (FormMain formMain = new FormMain())
                    {
                        formMain.btnFormSignup.Enabled = false;
                        formMain.btnFormRegistration.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Нет..");
                }
                connection.Close();
            }
        }
        public static bool StringIsValid(string str)
        {
            return !string.IsNullOrEmpty(str) && !Regex.IsMatch(str, @"[^a-zA-z\d_]");
        }
    }
}
