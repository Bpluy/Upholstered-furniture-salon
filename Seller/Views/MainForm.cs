using Seller.Contexts;
using Seller.Models;
using Seller.Views;
using System;
using System.Data.Entity;
using System.IO;
using System.Windows.Forms;

namespace Seller
{
    public partial class MainForm : Form
    {
        FurnitureContext dbFurniture;
        OrderContext dbOrder;
        OpenFileDialog fileDialog=null;
        byte[] picture;
        public MainForm()
        {
            InitializeComponent();

            dbFurniture = new();
            dbFurniture.Furnitures.Load();

            dbOrder = new();
            dbOrder.Orders.Load();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.buttonChooseImage.Click += buttonChooseImage_Click;
            addForm.openFileDialog1 = new();
            fileDialog = addForm.openFileDialog1;
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            Furniture furniture = new();
            furniture.Title = addForm.fieldTitle.Text;
            furniture.Price = Convert.ToInt32(addForm.fieldPrice.Text);
            furniture.Description = addForm.fieldDescription.Text;
            furniture.Picture = picture;
            furniture.isAvailable = true;
            furniture.Type = addForm.comboBoxType.Text;
            dbFurniture.Furnitures.Add(furniture);
            dbFurniture.SaveChanges();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            if(fileDialog.ShowDialog()==DialogResult.OK)
            {
                var fs = new FileStream(fileDialog.FileName,FileMode.Open);
                picture = new byte[fs.Length];
                fs.Read(picture, 0, picture.Length);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            EditForm editForm = new();
            editForm.ShowDialog();
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            ShowOrders showOrders = new();
            showOrders.ShowDialog();
        }
    }
}
