using Buyer.Contexts;
using Buyer.Views;
using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Buyer
{
    public partial class CategoryChooseForm : Form
    {
        FurnitureContext dbFurniture;
        OrderContext dbOrder;
        int[] ArticleID;
        int count = 0;
        ArticleChooseForm article;
        public CategoryChooseForm()
        {
            InitializeComponent();

            dbFurniture = new();
            dbOrder = new();

            dbFurniture.Furnitures.Load();
            dbOrder.Orders.Load();
            ArticleID = new int[dbFurniture.Furnitures.Local.Count];
        }

        private void buttonChairs_Click(object sender, EventArgs e)
        {
            ArticleChooseForm article = new();
            article.Text = "Кресла";            
            count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == article.Text)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }
            article.labelNumber.Text = string.Format("1/{0}", count);
            article.labelName.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Title;
            article.labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Description;
            article.labelPrice.Text = string.Format("{0}", dbFurniture.Furnitures.Find(ArticleID[0]).Price.ToString());
            string isAvailable = dbFurniture.Furnitures.Find(ArticleID[0]).isAvailable.ToString();
            if (isAvailable == "True")
            {
                article.labelStatus.Text = "В наличии";
                article.buttonBuy.Enabled = true;
            }
            else
            {
                article.labelStatus.Text = "Нет в наличии";
                article.buttonBuy.Enabled = false;
            }
            article.pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[0]).Picture);
            article.ShowDialog(this);


        }
        private void buttonSofas_Click(object sender, EventArgs e)
        {
            ArticleChooseForm article = new();
            article.Text = "Диваны";
            count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == article.Text)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }
            article.labelNumber.Text = string.Format("1/{0}", count);
            article.labelName.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Title;
            article.labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Description;
            article.labelPrice.Text = string.Format("{0}", dbFurniture.Furnitures.Find(ArticleID[0]).Price.ToString());
            string isAvailable = dbFurniture.Furnitures.Find(ArticleID[0]).isAvailable.ToString();
            if (isAvailable == "True")
            {
                article.labelStatus.Text = "В наличии";
                article.buttonBuy.Enabled = true;
            }
            else
            {
                article.labelStatus.Text = "Нет в наличии";
                article.buttonBuy.Enabled = false;
            }
            article.pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[0]).Picture);
            article.ShowDialog(this);
        }

        private void buttonBeds_Click(object sender, EventArgs e)
        {
            ArticleChooseForm article = new();
            article.Text = "Кровати";
            count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == article.Text)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }
            article.labelNumber.Text = string.Format("1/{0}", count);
            article.labelName.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Title;
            article.labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Description;
            article.labelPrice.Text = string.Format("{0}", dbFurniture.Furnitures.Find(ArticleID[0]).Price.ToString());
            string isAvailable = dbFurniture.Furnitures.Find(ArticleID[0]).isAvailable.ToString();
            if (isAvailable == "True")
            {
                article.labelStatus.Text = "В наличии";
                article.buttonBuy.Enabled = true;
            }
            else
            {
                article.labelStatus.Text = "Нет в наличии";
                article.buttonBuy.Enabled = false;
            }
            article.pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[0]).Picture);
            article.ShowDialog(this);
        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            article = new();
            article.Text = "Столы";
            count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == article.Text)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }
            article.labelNumber.Text = string.Format("1/{0}", count);
            article.labelName.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Title;
            article.labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[0]).Description;
            article.labelPrice.Text = string.Format("{0}", dbFurniture.Furnitures.Find(ArticleID[0]).Price.ToString());
            bool isAvailable = dbFurniture.Furnitures.Find(ArticleID[0]).isAvailable;
            if(isAvailable==true)
            {
                article.labelStatus.Text = "В наличии";
                article.buttonBuy.Enabled = true;
            }
            else
            {
                article.labelStatus.Text = "Нет в наличии";
                article.buttonBuy.Enabled = false;
            }
            article.pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[0]).Picture);

            article.ShowDialog(this);
        }
        public static Bitmap ByteToImage(byte[] Byte)
        {
            MemoryStream mStream = new();
            byte[] pData = Byte;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }                
    }
}
