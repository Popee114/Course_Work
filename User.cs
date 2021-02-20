using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class User : Form
    {
        private static string com, prodName, tempStr = "", tempStr1 = "";
        private static Point lastPoint;
        private static Image newImage;
        private static double amount = 0, tempDouble;
        private static int affiliateId, indexItem, result, tempInt, i = 0;
        private static List<string> sizeList = new List<string>();
        private static List<string> positionProd = new List<string>();
        private static List<string> nameProd = new List<string>();
        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            com = $"SELECT TOP 1 CONCAT([Surname], ' ', [Name]) FROM Buyer WHERE [Id_User] = {Class.idUser}";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                labelName.Text = Convert.ToString(sqlCommand.ExecuteScalar());
                sqlConnection.Close();
            }
            com = $"select count(*) from Buyer where [Id_User] = {Class.idUser} AND [Id_PurchaseNumber] IS NOT NULL";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                textBoxNumOrder.Text = Convert.ToString(sqlCommand.ExecuteScalar());
                sqlConnection.Close();
            }
            com = "SELECT [Type] FROM ProductType";
            MyConnection.comboBoxLoading(comboBoxChooseType, com, "Type");
            com = "select [ProductName] from TableProdImg";
            MyConnection.comboBoxLoading(comboBoxChooseProd, com, "ProductName");
            com = "SELECT [NameAffiliate] FROM Affiliate";
            MyConnection.comboBoxLoading(comboBoxAffiliate, com, "NameAffiliate");
        }
        private void buttonClosing_Click(object sender, EventArgs e)
        {
            Close();
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
        private void buttonMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void buttonViewImg_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseType.SelectedIndex == -1 && comboBoxChooseProd.Text.Length != 0)
            {
                getImageBinaryFromDb(comboBoxChooseProd);
                pictureBoxViewProd.Image = newImage;
            }
            else if (comboBoxChooseType.Text.Length != 0 && comboBoxChooseProd.Text.Length != 0)
            {
                getImageBinaryFromDb(comboBoxChooseType, prodName);
                pictureBoxViewProd.Image = newImage;
            }
            else
            {
                MessageBox.Show("Ничего не выбранно!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupBoxBasket.Enabled == false)
            {
                comboBoxChooseType.SelectedIndex = -1;
                comboBoxChooseProd.SelectedIndex = -1;
                MessageBox.Show("Выберите филиал покупки!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBoxChooseType.Text.Length > 0)
                {
                    int idType = comboBoxChooseType.SelectedIndex + 1;
                    com = $"SELECT [ProductName] FROM TableProdImg WHERE [Id_Type] = {idType}";
                    comboBoxChooseProd.Items.Clear();
                    comboBoxSizeBuy.SelectedIndex = -1;
                    comboBoxSizeBuy.Items.Clear();
                    textBoxPriceProd.Clear();
                    richTextBox.Clear();
                    MyConnection.comboBoxLoading(comboBoxChooseProd, com, "ProductName");
                }
            }
        }
        private void buttonChat_Click(object sender, EventArgs e)
        {
            MessBuyer messBuyer = new MessBuyer(); 
            messBuyer.Owner = this;
            OpenForm(messBuyer);
            messBuyer.Show();
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int j = 0;
            List<int> tempList = new List<int>();
            bool flag = true;
            foreach (string item in positionProd)
            {
                tempStr1 = item.Substring(0, item.Length - 2);
                tempInt = Int32.Parse(tempStr1);
                com = $"SELECT Warehouse.[NumberOfProduct] FROM Warehouse WHERE [Id_Position] = {tempInt}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection()) 
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    sqlConnection.Close();
                }
                if (result == 0)
                {
                    tempList.Add(j);
                }
                j++;
            }
            foreach (int item in tempList)
            {
                tempStr1 = positionProd[item].Substring(0, positionProd[item].Length - 2);
                tempInt = Int32.Parse(tempStr1);
                com = $"SELECT Product.[PriceOfUnit] FROM Product join Warehouse on Product.[Id_ProductKA] = Warehouse.[Id_Product] WHERE Warehouse.[Id_Position] = {tempInt}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    sqlConnection.Close();
                }
                amount -= result;
            }
            foreach (int item in tempList)
            {
                positionProd.RemoveAt(item);
                sizeList.RemoveAt(item);
                listBoxProds.Items.RemoveAt(item);
                flag = false;
            }
            if (flag == false)
            {
                MessageBox.Show("Вещи, которых нет на складе, \nбыли удалены.", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listBoxProds.Items.Count == 0)
            {
                MessageBox.Show("Ничего невыбрано.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string item in listBoxProds.Items)
                {
                    nameProd.Add(item + ", ");
                }
                foreach (string item in nameProd)
                {
                    Class.nameProds += item;
                }
                foreach (string item in positionProd)
                {
                    tempStr += item;
                }
                Class.numPos = tempStr;
                Class.IdAffiliate = affiliateId;
                Class.amount = amount;
                Payment payment = new Payment();
                payment.Owner = this;
                OpenForm(payment);
                payment.Show();
            }
        }
        private void comboBoxChooseProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodName = comboBoxChooseProd.Text;
            com = "SELECT DISTINCT [Size] FROM Product " + 
                  "join Warehouse on Product.[Id_ProductKA] = Warehouse.[Id_Product]" +
                  "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                  "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                  $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND " +
                        $"TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' AND " +
                        $"Product.[ProductName] = '{comboBoxChooseProd.Text}' AND " + 
                        $"Warehouse.[Id_Affiliate] = {affiliateId}";
            comboBoxSizeBuy.SelectedIndex = -1;
            comboBoxSizeBuy.Items.Clear();
            textBoxPriceProd.Clear();
            richTextBox.Clear();
            MyConnection.comboBoxLoading(comboBoxSizeBuy, com, "Size");
            com = "SELECT TOP 1 [PriceOfUnit] FROM Product " +
                  "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                  "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                  $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND " +
                        $"TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' AND " +
                        $"Product.[ProductName] = '{comboBoxChooseProd.Text}'";
            MyConnection.textBoxLoading(textBoxPriceProd, com);
            com = "SELECT TOP 1 [Descriprion] FROM Product " +
                  "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                  "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                  $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND " +
                        $"TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' AND " +
                        $"Product.[ProductName] = '{comboBoxChooseProd.Text}'";
            MyConnection.richTextBoxLoading(richTextBox, com);
        }
        private void buttonAddBasket_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseType.Text.Length == 0 || comboBoxChooseProd.Text.Length == 0 || comboBoxSizeBuy.Text.Length == 0)
            {
                MessageBox.Show("Ничего не выбранно!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                com = "SELECT Product.[ProductName] " +
                 "FROM Product " +
                 "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                 "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' " +
                  $"AND Product.[ProductName] = '{comboBoxChooseProd.Text}' " +
                  $"AND Product.[Size] = '{comboBoxSizeBuy.Text}'";
                MyConnection.listBoxOrder(listBoxProds, com);
                com = "SELECT Product.[PriceOfUnit] " +
                      "FROM Product " +
                      "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                      "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                     $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' " +
                       $"AND Product.[ProductName] = '{comboBoxChooseProd.Text}' " +
                       $"AND Product.[Size] = '{comboBoxSizeBuy.Text}'";
                MyConnection.textBoxLoading(textBoxAmount, com);
                com = "SELECT Warehouse.[Id_Position] FROM Product " +
                    "join Warehouse on Product.[Id_ProductKA] = Warehouse.[Id_Product] " +
                    "join ProductType on Product.[Id_ProductType] = ProductType.[Id_ProductTypeKA] " +
                    "join TableProdImg on ProductType.[Id_ProductTypeKA] = TableProdImg.[Id_Type] " +
                    $"WHERE TableProdImg.[Id_Type] = {comboBoxChooseType.SelectedIndex + 1} AND TableProdImg.[ProductName] = '{comboBoxChooseProd.Text}' " +
                       $"AND Product.[ProductName] = '{comboBoxChooseProd.Text}' " +
                       $"AND Product.[Size] = '{comboBoxSizeBuy.Text}' " + 
                       $"AND Warehouse.[Id_Affiliate] = {affiliateId}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    tempInt = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    sqlConnection.Close();
                }
                positionProd.Add(tempInt.ToString() + ", ");
                sizeList.Add(comboBoxSizeBuy.Text + ", ");
                amount += Double.Parse(textBoxAmount.Text);
                textBoxAmount.Text = amount.ToString();
                i++;
            }
        }
        private void comboBoxAffiliate_SelectedIndexChanged(object sender, EventArgs e)
        {
            affiliateId = comboBoxAffiliate.SelectedIndex + 1;
            groupBoxBasket.Enabled = true;
            amount = 0;
            textBoxAmount.Text = amount.ToString();
            listBoxProds.Items.Clear();
            comboBoxChooseType.SelectedIndex = -1;
            comboBoxChooseProd.SelectedIndex = -1;
            comboBoxSizeBuy.SelectedIndex = -1;
            textBoxPriceProd.Clear();
            richTextBox.Clear();
        }
        private void buttonRemoveListProd_Click(object sender, EventArgs e)
        {
            indexItem = listBoxProds.SelectedIndex;
            prodName = listBoxProds.Items[indexItem].ToString();
            sizeList.RemoveAt(indexItem);
            positionProd.RemoveAt(indexItem);
            i--;
            listBoxProds.Items.RemoveAt(indexItem);
            com = "SELECT Product.[PriceOfUnit] " +
                  "FROM Product " +
                  $"WHERE [ProductName] = '{prodName}'";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                tempDouble = Convert.ToDouble(sqlCommand.ExecuteScalar());
                result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            amount -= tempDouble;
            textBoxAmount.Text = amount.ToString();
        }
        private static void getImageBinaryFromDb(ComboBox comboBox)
        {
            List<byte[]> iScreen = new List<byte[]>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"SELECT [img] FROM TableProdImg WHERE [Id] = {comboBox.SelectedIndex + 1}"; // наша запись в БД под id=1, поэтому в запросе "WHERE [id] = 1"
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                byte[] iTrimByte = null;
                while (sqlReader.Read()) // считываем и вносим в лист результаты
                {
                    iTrimByte = (byte[])sqlReader["img"]; // читаем строки с изображениями
                    iScreen.Add(iTrimByte);
                }
                sqlConnection.Close();
            }
            // конвертируем бинарные данные в изображение
            byte[] imageData = iScreen[0]; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
            MemoryStream ms = new MemoryStream(imageData);
            newImage = Image.FromStream(ms);
        }
        private static void getImageBinaryFromDb(ComboBox comboBox1, string comboBox2)
        {
            List<byte[]> iScreen = new List<byte[]>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"SELECT [img] FROM TableProdImg WHERE [Id_Type] = {comboBox1.SelectedIndex + 1} AND [ProductName] = '{comboBox2}'"; // наша запись в БД под id=1, поэтому в запросе "WHERE [id] = 1"
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                byte[] iTrimByte = null;
                //string cmd = $"UPDATE Product SET [Img] = {imgByte} WHERE [Id_ProductKA] = {idProd}";
                while (sqlReader.Read()) // считываем и вносим в лист результаты
                {
                    iTrimByte = (byte[])sqlReader["img"]; // читаем строки с изображениями
                    iScreen.Add(iTrimByte);
                }
                sqlConnection.Close();
            }
            // конвертируем бинарные данные в изображение
            byte[] imageData = iScreen[0]; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
            MemoryStream ms = new MemoryStream(imageData);
            newImage = Image.FromStream(ms);
        }
        public void OpenForm(Form form)
        {
            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                this.Show();
                if (Class.flag == true)
                {
                    foreach (string item in positionProd)
                    {
                        tempStr = item.Substring(0, item.Length - 2);
                        tempInt = Int32.Parse(tempStr);
                        com = $"UPDATE Warehouse SET [NumberOfProduct] = [NumberOfProduct] - 1 WHERE [Id_Position] = {tempInt}";
                        using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                        {
                            sqlConnection.Open();
                            SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                            result = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                    }
                    comboBoxAffiliate.SelectedIndex = -1;
                    comboBoxChooseType.SelectedIndex = -1;
                    comboBoxChooseProd.SelectedIndex = -1;
                    comboBoxSizeBuy.SelectedIndex = -1;
                    richTextBox.Clear();
                    textBoxAmount.Clear();
                    textBoxPriceProd.Clear();
                    listBoxProds.Items.Clear();
                    positionProd.Clear();
                    nameProd.Clear();
                    Class.nameProds = "";
                    Class.numPos = "";
                    sizeList.Clear();
                    amount = 0;
                    tempDouble = 0;
                    affiliateId = 0;
                    indexItem = 0;
                    result = 0;
                    tempInt = 0;
                    i = 0;
                    com = "";
                    prodName = "";
                    tempStr = "";
                    pictureBoxViewProd.Image = null;
                }
            };
        }
    }
}