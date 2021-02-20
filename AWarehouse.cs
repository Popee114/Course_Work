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
    public partial class AWarehouse : Form
    {
        private static int count = 0;
        private static string path;
        public AWarehouse()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
        private void AWarehouse_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void btnWareHouseEditPrice_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Double.Parse(textBoxWareHouseEditPrice.Text);
                int index = comboBoxWareHouseEditPrice.SelectedIndex + 1;
                string com = $"EXEC UpdatePrice {price}, {index}";
                int result;
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    result = sqlCommand.ExecuteNonQuery();
                    if (!result.Equals(0))
                    {
                        MessageBox.Show("Цена изменена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sqlConnection.Close();
                }
                comboBoxWareHouseEditPrice.SelectedIndex = -1;
                textBoxWareHouseEditPrice.Text = null;
                refresh();
            }
            catch
            {
                MessageBox.Show("Что-то не заполненно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonResetComboBox_Click(object sender, EventArgs e)
        {
            comboBoxIdAffiliateTable.SelectedIndex = -1;
            comboBoxViewWareHouseItem.SelectedIndex = -1;
            string com = $"SELECT [Id_Position], Affiliate.[NameAffiliate], [ProductName], [Type], [NameCompany], [PriceOfUnit], [NumberOfProduct] FROM WarehouseInfo join Affiliate on WarehouseInfo.[Id_Affiliate] = Affiliate.[Id_AffiliateKA]";
            MyConnection.loadingDataGridView(dataGridViewxViewWareHouseItem, com, "WarehouseInfo");
        }
        private void buttonViewTable_Click(object sender, EventArgs e)
        {
            int idProd, idAffiliate;
            string com;
            if (comboBoxViewWareHouseItem.SelectedIndex == -1 && comboBoxIdAffiliateTable.SelectedIndex == -1)
            {
                MessageBox.Show("Не одно поле не выбранно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxViewWareHouseItem.SelectedIndex == -1)
            {
                idAffiliate = comboBoxIdAffiliateTable.SelectedIndex + 1;
                com = $"SELECT [Id_Position],[ProductName],[Type],[NameCompany],[PriceOfUnit],[NumberOfProduct] FROM WarehouseInfo WHERE [Id_Affiliate] = {idAffiliate}";
                MyConnection.loadingDataGridView(dataGridViewxViewWareHouseItem, com, "WarehouseInfo");
            }
            else if(comboBoxIdAffiliateTable.SelectedIndex == -1)
            {
                idProd = comboBoxViewWareHouseItem.SelectedIndex + 1;
                com = $"SELECT [Id_Position], Affiliate.[NameAffiliate], [ProductName],[Type],[NameCompany],[PriceOfUnit],[NumberOfProduct] FROM WarehouseInfo join Affiliate on WarehouseInfo.[Id_Affiliate] = Affiliate.[Id_AffiliateKA] WHERE [Id_ProductKA] = {idProd}";
                MyConnection.loadingDataGridView(dataGridViewxViewWareHouseItem, com, "WarehouseInfo");
            }
            else
            {
                idProd = comboBoxViewWareHouseItem.SelectedIndex + 1;
                idAffiliate = comboBoxIdAffiliateTable.SelectedIndex + 1;
                com = $"SELECT [Id_Position],[ProductName],[Type],[NameCompany],[PriceOfUnit],[NumberOfProduct] FROM WarehouseInfo WHERE [Id_Affiliate] = {idAffiliate} AND [Id_ProductKA] = {idProd}";
                MyConnection.loadingDataGridView(dataGridViewxViewWareHouseItem, com, "WarehouseInfo");
            }
        }
        private void btnWareHousePlus_Click(object sender, EventArgs e)
        {
            count++;
            labelWareHouseNumProduct.Text = count.ToString();
        }
        private void btnWareHouseMinus_Click(object sender, EventArgs e)
        {
 
            if (count < 0)
            {
                count = 0;
                labelWareHouseNumProduct.Text = count.ToString();
                MessageBox.Show("Значение не может быть отрицательным!", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                count--;
                labelWareHouseNumProduct.Text = count.ToString();
            }
        }
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            int idProd, idAffiliate, numProd, result = 0;
            string com;
            try
            {
                idProd = comboBoxAddProd.SelectedIndex + 1;
                idAffiliate = comboBoxAffiliateAddProd.SelectedIndex + 1;
                numProd = Int32.Parse(labelWareHouseNumProduct.Text);
                com = $"select * from Warehouse Where [Id_Product] = {idProd} AND [Id_Affiliate] = {idAffiliate}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet, "Warehouse");
                    DataTable dataTable = dataSet.Tables["Warehouse"];
                    result = dataTable.Rows.Count;
                    sqlConnection.Close();
                }
                if (result > 0)
                {
                    com = $"UPDATE Warehouse SET [NumberOfProduct] = [NumberOfProduct] + {numProd} WHERE [Id_Product] = {idProd} AND [Id_Affiliate] = {idAffiliate}";
                    using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                        result = sqlCommand.ExecuteNonQuery();
                        if (!result.Equals(0))
                        {
                            MessageBox.Show("Доставлено!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        sqlConnection.Close();
                    }
                }
                else
                {
                    com = $"declare @DATE DATE SET @DATE = GETDATE() EXEC NewDelivery @DATE, {idProd}, {idAffiliate}, {numProd}";
                    using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                        result = sqlCommand.ExecuteNonQuery();
                        if (!result.Equals(0))
                        {
                            MessageBox.Show("Доставлено!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        sqlConnection.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не одно поле не выбранно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                count = 0;
                comboBoxAddProd.SelectedIndex = -1;
                comboBoxAffiliateAddProd.SelectedIndex = -1;
                labelWareHouseNumProduct.Text = count.ToString();
                numProd = 0;
                refresh();
            }
        }
        private void buttonSupplierOrder_Click(object sender, EventArgs e)
        {
            double priceProd = Double.Parse(textBoxPriceProd.Text);
            string dateDelivery = maskedTextBoxDateDelivery.Text;
            int numProd = Int32.Parse(textBoxNumProd.Text);
            string desProd = richTextBoxDescriprion.Text;
            string cmd =  $"DECLARE @QWE varbinary(MAX)" +
                          $"SET @QWE = (SELECT * FROM OpenRowSet (BULK '{path}', SINGLE_BLOB) AS Файл)" +
                          $"EXEC NewProduct '{textBoxNameProd.Text}', '{textBoxSizeProd.Text}', {comboBoxSelectType.SelectedIndex + 1}, {priceProd}, @QWE, @DESPROD;" +
                          $"EXEC NewDeliveryNewProduct @QWER, {comboBoxIdSupplier.SelectedIndex + 1}, {comboBoxIdAffiliate.SelectedIndex + 1}, {numProd}" +
                          $"INSERT INTO TableProdImg VALUES ( {comboBoxSelectType.SelectedIndex + 1}, '{textBoxNameProd.Text}', @QWE)";
            using (SqlConnection sqlConnection = new MyConnection().GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.Add("@DESPROD", SqlDbType.VarChar).Value = desProd;
                sqlCommand.Parameters.Add("@QWER", SqlDbType.VarChar).Value = dateDelivery;
                int result = sqlCommand.ExecuteNonQuery();
                if (!result.Equals(0))
                {
                    MessageBox.Show("Товар внесен.");
                    refresh();
                }
                sqlConnection.Close();
            }
            textBoxNameProd.Clear();
            textBoxSizeProd.Clear();
            textBoxPriceProd.Clear();
            maskedTextBoxDateDelivery.Clear();
            textBoxNumProd.Clear();
            richTextBoxDescriprion.Clear();
        }
        private void buttonLoadingImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.JPG)|*.jpg";
            openFileDialog.Title = "Загрузить файл.";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName.ToString();
                checkBox.Checked = true;
            }
        }
        private void textBoxPriceProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void textBoxNumProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void textBoxWareHouseEditPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void refresh()
        {
            comboBoxWareHouseEditPrice.Items.Clear();
            comboBoxAddProd.Items.Clear();
            comboBoxViewWareHouseItem.Items.Clear();
            comboBoxIdSupplier.Items.Clear();
            comboBoxIdAffiliate.Items.Clear();
            comboBoxSelectType.Items.Clear();
            comboBoxIdAffiliateTable.Items.Clear();
            comboBoxAffiliateAddProd.Items.Clear();
            string com = "SELECT * FROM ProductSize";
            MyConnection.comboBoxLoading(comboBoxWareHouseEditPrice, com, "Продукт с размером"); //Price
            MyConnection.comboBoxLoading(comboBoxAddProd, com, "Продукт с размером"); //NumProd
            MyConnection.comboBoxLoading(comboBoxViewWareHouseItem, com, "Продукт с размером"); //TableProd
            com = "SELECT [NameCompany] FROM Supplier";
            MyConnection.comboBoxLoading(comboBoxIdSupplier, com, "NameCompany"); //Supplier
            com = "SELECT [NameAffiliate] FROM Affiliate";
            MyConnection.comboBoxLoading(comboBoxIdAffiliate, com, "NameAffiliate"); //Affiliate
            com = "SELECT [Type] FROM ProductType";
            MyConnection.comboBoxLoading(comboBoxSelectType, com, "Type"); //TypeProd
            com = "SELECT [NameAffiliate] FROM Affiliate";
            MyConnection.comboBoxLoading(comboBoxIdAffiliateTable, com, "NameAffiliate");
            com = "SELECT [NameAffiliate] FROM Affiliate";
            MyConnection.comboBoxLoading(comboBoxAffiliateAddProd, com, "NameAffiliate"); //Affiliate
            com = $"SELECT [Id_Position], Affiliate.[NameAffiliate], [ProductName], [Type], [NameCompany], [PriceOfUnit], [NumberOfProduct] FROM WarehouseInfo join Affiliate on WarehouseInfo.[Id_Affiliate] = Affiliate.[Id_AffiliateKA]";
            MyConnection.loadingDataGridView(dataGridViewxViewWareHouseItem, com, "WarehouseInfo");
        }
    }
}
