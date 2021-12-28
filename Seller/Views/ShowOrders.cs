using Seller.Contexts;
using Seller.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Seller.Views
{
    public partial class ShowOrders : Form
    {
        OrderContext dbOrder = new();
        public ShowOrders()
        {
            InitializeComponent();
            dbOrder.Orders.Load();
            dataGridView1.DataSource = dbOrder.Orders.Local.ToBindingList();
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].HeaderCell.Value = "ФИО покупателя";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].HeaderCell.Value = "Наименование товара";
            dataGridView1.Columns[2].Width = 230;
            dataGridView1.Columns[3].HeaderCell.Value = "Цена";
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].HeaderCell.Value = "Адрес покупателя";
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].HeaderCell.Value = "Номер телефона";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderCell.Value = "Статус заказа";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if(!converted)
                {
                    return;
                }

                Order _order = dbOrder.Orders.Find(id);
                _order.Status = "Принят";
                dbOrder.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Заказ принят");
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (!converted)
                {
                    return;
                }

                Order _order = dbOrder.Orders.Find(id);
                _order.Status = "Завершен";
                dbOrder.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Заказ завершен");
            }
        }
    }
}
