using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seller.Contexts;
using Seller.Models;

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
                _order.Status = "Accepted";
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
                _order.Status = "Completed";
                dbOrder.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Заказ завершен");
            }
        }
    }
}
