using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data;

namespace Coursework
{
    public partial class Payment : Form
    {
        private static string com;
        private static Point lastPoint;
        public Payment()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panelHighMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panelHighMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void radioButtonNAL_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCARD.Enabled = false;
            textBoxCARD.Clear();
            radioButtonCARD.Checked = false;
        }
        private void radioButtonCARD_MouseClick(object sender, MouseEventArgs e)
        {
            radioButtonNAL.Checked = false;
            textBoxCARD.Enabled = true;
        }
        private void radioButtonPickup_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAddressDelovery.Clear();
            textBoxAddressDelovery.Enabled = false;
            maskedTextBoxDateDelivery.Enabled = false;
        }
        private void radioButtonDelivery_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAddressDelovery.Enabled = true;
            maskedTextBoxDateDelivery.Enabled = true;
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonNAL.Checked == true)
                {
                    if (radioButtonPickup.Checked == true)
                    {
                        com = $" DECLARE @DATE DATE SET @DATE = GETDATE() EXEC NewPurchaseNALNotDelivery {Class.IdAffiliate}, '{Class.numPos}', {Class.amount}, @DATE";
                        workCom(com);
                        com = " INSERT INTO CheckPurchase ([Id_Role], [Surname], [Name], [Products], [Amount], [DatePayment]) VALUES " +
                            "( 2,  " +
                            $"(SELECT TOP 1 [Surname] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"(SELECT TOP 1 [Name] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"'{Class.nameProds}',  " +
                            $"{Class.amount},  " +
                            $"(SELECT TOP 1 Purchase.[DateOfPurchase] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC))";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            int result = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        com = "UPDATE Purchase SET [Id_Check] = (SELECT TOP 1 [Id_CheckKA] FROM CheckPurchase ORDER BY [Id_CheckKA] DESC) WHERE Purchase.[Id_PurchaseNumberKA] = (SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase ORDER BY [Id_PurchaseNumberKA] DESC)";
                        workCom(com);
                    }
                    else
                    {
                        com = $" DECLARE @DATE DATE SET @DATE = GETDATE() EXEC NewPurchaseNALDelivery '{textBoxAddressDelovery.Text}', '{maskedTextBoxDateDelivery.Text}', {Class.IdAffiliate}, '{Class.numPos}', {Class.amount}, @DATE";
                        workCom(com);
                        com = " INSERT INTO CheckPurchase ([Id_Role], [Surname], [Name], [Products], [Amount], [DatePayment], [AddressDelivery], [DateDelivery]) VALUES " +
                            "( 2,  " +
                            $"(SELECT TOP 1 [Surname] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"(SELECT TOP 1 [Name] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"'{Class.nameProds}',  " +
                            $"{Class.amount},  " +
                            $"(SELECT TOP 1 Purchase.[DateOfPurchase] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC), " +
                            $" '{textBoxAddressDelovery.Text}', " +
                            $"@QWER )";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            sqlCommand.Parameters.Add("@QWER", SqlDbType.VarChar).Value = maskedTextBoxDateDelivery.Text;
                            int result = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        com = "UPDATE Purchase SET [Id_Check] = (SELECT TOP 1 [Id_CheckKA] FROM CheckPurchase ORDER BY [Id_CheckKA] DESC) WHERE Purchase.[Id_PurchaseNumberKA] = (SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase ORDER BY [Id_PurchaseNumberKA] DESC)";
                        workCom(com);
                    }
                }
                else
                {
                    if (radioButtonPickup.Checked == true)
                    {
                        com = $" DECLARE @DATE DATE SET @DATE = GETDATE() EXEC NewPurchaseCARDNotDelivery {Class.IdAffiliate}, '{Class.numPos}', {Class.amount}, {textBoxCARD.Text}, @DATE";
                        workCom(com);
                        com = " INSERT INTO CheckPurchase ([Id_Role], [Surname], [Name], [Products], [Amount], [CardPayment], [DatePayment]) VALUES " +
                            "( 2,  " +
                            $"(SELECT TOP 1 [Surname] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"(SELECT TOP 1 [Name] FROM Buyer WHERE [Id_User] = {Class.idUser}),  " +
                            $"'{Class.nameProds}',  " +
                            $"{Class.amount},  " +
                            $"(SELECT TOP 1 Purchase.[CardPayment] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC),  " +
                            $"(SELECT TOP 1 Purchase.[DateOfPurchase] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC))";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            int result = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        com = "UPDATE Purchase SET [Id_Check] = (SELECT TOP 1 [Id_CheckKA] FROM CheckPurchase ORDER BY [Id_CheckKA] DESC) WHERE Purchase.[Id_PurchaseNumberKA] = (SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase ORDER BY [Id_PurchaseNumberKA] DESC)";
                        workCom(com);
                    }
                    else
                    {
                        com = $" DECLARE @DATE DATE SET @DATE = GETDATE() EXEC NewPurchaseCARDDelivery '{textBoxAddressDelovery.Text}', '{maskedTextBoxDateDelivery.Text}', {Class.IdAffiliate}, '{Class.numPos}', {Class.amount}, '{textBoxCARD.Text}', @DATE";
                        workCom(com);
                        com = "INSERT INTO CheckPurchase VALUES " +
                              $"(2, (SELECT TOP 1 [Surname] FROM Buyer WHERE [Id_User] = {Class.idUser}), " +
                              $"(SELECT TOP 1 [Name] FROM Buyer WHERE [Id_User] = {Class.idUser}), " +
                              $"'{Class.nameProds}', " +
                              $"{Class.amount}, " +
                              $"(SELECT TOP 1 Purchase.[CardPayment] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC), " +
                              $"(SELECT TOP 1 Purchase.[DateOfPurchase] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC), " +
                              $"'{textBoxAddressDelovery.Text}', " +
                              $"@QWER)";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            sqlCommand.Parameters.Add("@QWER", SqlDbType.VarChar).Value = maskedTextBoxDateDelivery.Text;
                            int result = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        com = "UPDATE Purchase SET [Id_Check] = (SELECT TOP 1 [Id_CheckKA] FROM CheckPurchase ORDER BY [Id_CheckKA] DESC) WHERE Purchase.[Id_PurchaseNumberKA] = (SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase ORDER BY [Id_PurchaseNumberKA] DESC)";
                        workCom(com);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally 
            {
                {
                    com = $"select Buyer.[Id_PurchaseNumber] from Buyer where Buyer.[Id_Buyer] = {Class.idUser}";
                    string res;
                    using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                        res = Convert.ToString(sqlCommand.ExecuteScalar());
                        sqlConnection.Close();
                    }
                    if (res == "")
                    {
                        com = $"UPDATE Buyer SET [Id_PurchaseNumber] = (SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase ORDER BY Purchase.[Id_PurchaseNumberKA] DESC) WHERE [Id_User] = {Class.idUser}";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            res = Convert.ToString(sqlCommand.ExecuteNonQuery());
                            sqlConnection.Close();
                        }
                    }
                    else
                    {
                        com = "INSERT INTO Buyer VALUES " +
                             $"( { Class.idUser}, ( " +
                                   "SELECT TOP 1[Surname] FROM Buyer " +
                                  $"WHERE[Id_User] = { Class.idUser} " +
                              "), ( "+
                                   "SELECT TOP 1[Name] FROM Buyer " +
                                  $"WHERE[Id_User] = { Class.idUser} " +
                              "), ( " +
                                   "SELECT TOP 1[Email] FROM Buyer " +
                                  $"WHERE[Id_User] = { Class.idUser} " +
                              "), ( " +
                                   "SELECT TOP 1 Purchase.[Id_PurchaseNumberKA] FROM Purchase " +
                                   "ORDER BY Purchase.[Id_PurchaseNumberKA] DESC ))";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            res = Convert.ToString(sqlCommand.ExecuteNonQuery());
                            sqlConnection.Close();
                        }
                    }
                    MessageBox.Show("Покупка совершена!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (radioButtonNAL.Checked == true)
                    {
                        if (radioButtonPickup.Checked == true)
                        {
                            com = "select top 1 RoleUsers.[Role], " +
                                          "CheckPurchase.[Surname],  " +
                                          "CheckPurchase.[Name], " +
                                          "CheckPurchase.[Products],  " +
                                          "CheckPurchase.[Amount], " +
                                          "CheckPurchase.[DatePayment] " +
                               "from CheckPurchase " +
                               "join RoleUsers on CheckPurchase.[Id_Role] = RoleUsers.[Id_UsersRole] " +
                               "order by CheckPurchase.[Id_CheckKA] desc";
                            MyConnection.loadingDataGridView(dataGridView1, com, "CheckPurchase");
                        }
                        else
                        {
                            com = "select top 1 RoleUsers.[Role], " +
                                          "CheckPurchase.[Surname],  " +
                                          "CheckPurchase.[Name], " +
                                          "CheckPurchase.[Products],  " +
                                          "CheckPurchase.[Amount], " +
                                          "CheckPurchase.[AddressDelivery], " +
                                          "CheckPurchase.[DateDelivery] " +
                               "from CheckPurchase " +
                               "join RoleUsers on CheckPurchase.[Id_Role] = RoleUsers.[Id_UsersRole] " +
                               "order by CheckPurchase.[Id_CheckKA] desc";
                            MyConnection.loadingDataGridView(dataGridView1, com, "CheckPurchase");
                        }
                    }
                    else
                    {
                        if (radioButtonPickup.Checked == true)
                        {
                            com = "select top 1 RoleUsers.[Role], " +
                                          "CheckPurchase.[Surname],  " +
                                          "CheckPurchase.[Name], " +
                                          "CheckPurchase.[Products],  " +
                                          "CheckPurchase.[Amount], " +
                                          "CheckPurchase.[CardPayment], " +
                                          "CheckPurchase.[DatePayment] " +
                               "from CheckPurchase " +
                               "join RoleUsers on CheckPurchase.[Id_Role] = RoleUsers.[Id_UsersRole] " +
                               "order by CheckPurchase.[Id_CheckKA] desc";
                            MyConnection.loadingDataGridView(dataGridView1, com, "CheckPurchase");
                        }
                        else
                        {
                            com = "select top 1 RoleUsers.[Role], " +
                                          "CheckPurchase.[Surname],  " +
                                          "CheckPurchase.[Name], " +
                                          "CheckPurchase.[Products],  " +
                                          "CheckPurchase.[Amount], " +
                                          "CheckPurchase.[CardPayment], " +
                                          "CheckPurchase.[DatePayment], " +
                                          "CheckPurchase.[AddressDelivery], " +
                                          "CheckPurchase.[DateDelivery] " +
                               "from CheckPurchase " +
                               "join RoleUsers on CheckPurchase.[Id_Role] = RoleUsers.[Id_UsersRole] " +
                               "order by CheckPurchase.[Id_CheckKA] desc";
                            MyConnection.loadingDataGridView(dataGridView1, com, "CheckPurchase");
                        }
                    }
                    Class.flag = true;
                    buttonCheck.Enabled = true;
                    buttonBuy.Enabled = false;
                }
            }
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }
        private void textBoxCARD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void workCom(string cmd)
        {
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                int res;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                res = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
