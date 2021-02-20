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
    public partial class AOrders : Form
    {
        private static string com;
        private static int idBuyer;
        private static int result;
        public AOrders()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AOrders_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void buttonShowBuyer_Click(object sender, EventArgs e)
        {
            if (comboBoxOrdersUserChoose.SelectedIndex == -1)
            {
                MessageBox.Show("Ничего не выбранно!","Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idBuyer = comboBoxOrdersUserChoose.SelectedIndex + 2;
                com = $"SELECT * FROM PurchaseView WHERE PurchaseView.[Номер покупателя] = {idBuyer}";
                MyConnection.loadingDataGridView(dataGridViewOrdersProducts, com, "PurchaseView");
                comboBoxOrdersUserChoose.SelectedIndex = -1;
            }
        }
        private void buttonConfirmationOrder_Click(object sender, EventArgs e)
        {
            if (textBoxIdBuyerOrder.Text != null && checkBoxOrdersStatus.Checked == true)
            {
                idBuyer = Int32.Parse(textBoxIdBuyerOrder.Text);
                com = $"UPDATE PurchaseView SET PurchaseView.[Статус оплаты] = '{checkBoxOrdersStatus.Checked}' WHERE PurchaseView.[Номер покупателя] = {idBuyer}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    result = sqlCommand.ExecuteNonQuery();
                    if (!result.Equals(0))
                    {
                        MessageBox.Show("Оплачено!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Покупатель не найден!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
                textBoxIdBuyerOrder.Text = null;
                checkBoxOrdersStatus.Checked = false;
                refresh();
            }
            else
            {
                MessageBox.Show("Что-то не заполнено!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIdBuyerOrder.Text = null;
                checkBoxOrdersStatus.Checked = false;
            }
        }
        private void buttonResetOrder_Click(object sender, EventArgs e)
        {
            com = "SELECT * FROM PurchaseView";
            MyConnection.loadingDataGridView(dataGridViewOrdersProducts, com, "Buyer");
        }
        private void buttonDeliveryToBuyer_Click(object sender, EventArgs e)
        {
            if (comboBoxDeliveryChoose.SelectedIndex == -1)
            {
                MessageBox.Show("Ничего не выбранно!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                idBuyer = comboBoxDeliveryChoose.SelectedIndex + 2;
                com = $"SELECT [Номер доставки], [Ф.И.], [Адрес доставки], [Дата доставки], [Статус доставки]  FROM DeliveryToBuyerView WHERE DeliveryToBuyerView.[Id_Buyer] = {idBuyer}";
                MyConnection.loadingDataGridView(dataGridViewOrdersDelivery, com, "DeliveryToBuyerView");
                comboBoxDeliveryChoose.SelectedIndex = -1;
            }
        }
        private void buttonResetDelivery_Click(object sender, EventArgs e)
        {
            com = "SELECT [Номер доставки], [Ф.И.], [Адрес доставки], [Дата доставки], [Статус доставки] FROM DeliveryToBuyerView";
            MyConnection.loadingDataGridView(dataGridViewOrdersDelivery, com, "DeliveryToBuyerView");
        }
        private void buttonConfirmationDelivery_Click(object sender, EventArgs e)
        {
            if (textBoxIdDelivery.Text != null && checkBoxDeliveryStatus.Checked == true)
            {
                idBuyer = Int32.Parse(textBoxIdDelivery.Text);
                com = $"UPDATE DeliveryToBuyerView SET DeliveryToBuyerView.[Статус Доставки] = '{checkBoxDeliveryStatus.Checked}' WHERE  DeliveryToBuyerView.[Номер доставки] = {idBuyer}";
                using (SqlConnection sqlConnection = new MyConnection().GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(com, sqlConnection);
                    result = sqlCommand.ExecuteNonQuery();
                    if (!result.Equals(0))
                    {
                        MessageBox.Show("Доставлено!", "Уведомление.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Покупатель не найден!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sqlConnection.Close();
                }
                textBoxIdDelivery.Text = null;
                checkBoxDeliveryStatus.Checked = false;
                refresh();
            }
            else
            {
                MessageBox.Show("Что-то не заполнено!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIdDelivery.Text = null;
                checkBoxDeliveryStatus.Checked = false;
            }
        }
        private void textBoxIdBuyerOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void textBoxIdDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {
            Class.notАigure(e);
        }
        private void refresh()
        {
            com = "SELECT CONCAT(Buyer.[Surname], ' ', Buyer.[Name]) AS 'Ф.И.' FROM Buyer WHERE Buyer.[Id_Buyer] != 1";
            MyConnection.comboBoxLoading(comboBoxOrdersUserChoose, com, "Ф.И.");
            MyConnection.comboBoxLoading(comboBoxDeliveryChoose, com, "Ф.И.");
            com = "SELECT COUNT(*) FROM Purchase";
            MyConnection.textBoxLoading(textBoxOrders, com);
            com = "SELECT * FROM PurchaseView";
            MyConnection.loadingDataGridView(dataGridViewOrdersProducts, com, "PurchaseView");
            com = "SELECT [Номер доставки], [Ф.И.], [Адрес доставки], [Дата доставки], [Статус доставки] FROM DeliveryToBuyerView";
            MyConnection.loadingDataGridView(dataGridViewOrdersDelivery, com, "DeliveryToBuyerView");
        }
    }
}
