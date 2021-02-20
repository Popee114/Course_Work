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
    public partial class MessBuyer : Form
    {
        private static Point lastPoint;
        private static string com;
        public MessBuyer()
        {
            InitializeComponent();
        }
        private void panelHighMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panelHighMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void buttonClosing_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MessBuyer_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Администратор, как и вы, видит \nтолько последнее сообщение. Старайтесь уместить свои мысли в одно сообщение.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            com = $"SELECT TOP 1 [Message] FROM MessageAdmin join MessageBuyer on MessageAdmin.[Id_BuyerMess] = MessageBuyer.[Id_BuyerMessKA] join Buyer on MessageBuyer.[Id_Buyer] = Buyer.[Id_Buyer] WHERE Buyer.[Id_User] = {Class.idUser} ORDER BY MessageAdmin.[Id_MessAdmin] DESC";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                try
                {
                    richTextBoxMessBuyer.Enabled = true;
                    richTextBoxMessAdmin.Text = Convert.ToString(sqlCommand.ExecuteScalar());
                }
                catch
                {

                }
                sqlConnection.Close();
            }
            com = $"SELECT TOP 1 [MessageB] FROM MessageBuyer join Buyer on MessageBuyer.[Id_Buyer] = Buyer.[Id_Buyer] WHERE Buyer.[Id_User] = {Class.idUser} ORDER BY MessageBuyer.[Id_BuyerMessKA] DESC";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                try
                {
                    richTextBoxMessBuyer.Text = Convert.ToString(sqlCommand.ExecuteScalar());
                    buttonSendMess.Enabled = true;
                    com = $"SELECT TOP 1 MessageBuyer.[Id_BuyerMessKA] FROM MessageBuyer join Buyer on MessageBuyer.[Id_Buyer] = Buyer.[Id_Buyer] WHERE Buyer.[Id_User] = {Class.idUser} ORDER BY [MessageB] DESC";
                    sqlCommand.CommandText = com;
                }
                catch
                {

                }
                sqlConnection.Close();
            }
        }
        private void buttonSendMess_Click(object sender, EventArgs e)
        {
            string str = richTextBoxMessBuyer.Text;
            com = $"INSERT INTO MessageBuyer ([Id_Buyer],[MessageB]) VALUES ( {Class.idBuyer}, '{str}')";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                int qw;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                qw = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
