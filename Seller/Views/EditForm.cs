using Seller.Contexts;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Seller.Views
{
    public partial class EditForm : Form
    {
        FurnitureContext dbFurniture = new();
        int count=0;
        public EditForm()
        {
            InitializeComponent();
            dbFurniture.Furnitures.Load();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string _type, _name;
            _type = comboBoxType.Text;
            _name = textBoxName.Text;
            for(int i=0;i<dbFurniture.Furnitures.Local.Count;i++)
            {
                if(dbFurniture.Furnitures.Find(i+1).Title==_name&& dbFurniture.Furnitures.Find(i + 1).Type==_type)
                {
                    textBoxNewName.Text = dbFurniture.Furnitures.Find(i + 1).Title;
                    count = i + 1;
                    textBoxNewDescription.Text = dbFurniture.Furnitures.Find(i + 1).Description;
                    textBoxNewPrice.Text = dbFurniture.Furnitures.Find(i + 1).Price.ToString();
                    comboBoxNewType.Text = dbFurniture.Furnitures.Find(i + 1).Type;
                    checkBoxAvailability.Checked = dbFurniture.Furnitures.Find(i + 1).isAvailable;                    
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            dbFurniture.Furnitures.Find(count).Title = textBoxNewName.Text;
            dbFurniture.Furnitures.Find(count).Description = textBoxNewDescription.Text;
            dbFurniture.Furnitures.Find(count).Type = comboBoxNewType.Text;
            dbFurniture.Furnitures.Find(count).isAvailable = checkBoxAvailability.Checked;
            dbFurniture.SaveChanges();
        }
    }
}
