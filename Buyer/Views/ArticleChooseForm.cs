using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buyer.Contexts;
using Buyer.Models;
using Buyer.Views;

namespace Buyer.Views
{
    public partial class ArticleChooseForm : Form
    {
        FurnitureContext dbFurniture=new();
        OrderContext dbOrder=new();
        int[] ArticleID;
        int CurrentID = 1;

        string CurrentType;
        public ArticleChooseForm()
        {
            InitializeComponent();

            dbFurniture.Furnitures.Load();
            dbOrder.Orders.Load();

            ArticleID = new int[dbFurniture.Furnitures.Local.Count];                        
        }        

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            CurrentType = this.Text;
            int count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == CurrentType)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }

            if (CurrentID > 1)
                CurrentID--;
            switch (CurrentType)
            {
                case "Кресла":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Столы":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Диваны":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Кровати":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {           
            CurrentType = this.Text;
            int count = 0;
            for (int i = 0; i < dbFurniture.Furnitures.Local.Count; i++)
            {
                if (dbFurniture.Furnitures.Find(i + 1).Type == CurrentType)
                {
                    ArticleID[count] = i + 1;
                    count++;
                }

            }

            if (CurrentID < count)
            {
                CurrentID++;
            }
            switch (CurrentType)
            {
                case "Кресла":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Столы":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Диваны":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
                case "Кровати":
                    {
                        labelNumber.Text = string.Format("{0}/{1}", CurrentID, count);
                        labelName.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Title;
                        labelDescription.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Description;
                        labelPrice.Text = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Price.ToString();
                        string isAvailable = dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).isAvailable.ToString();
                        if (isAvailable == "True")
                        {
                            labelStatus.Text = "В наличии";
                            buttonBuy.Enabled = true;
                        }
                        else
                        {
                            labelStatus.Text = "Нет в наличии";
                            buttonBuy.Enabled = false;
                        }
                        pictureBox1.Image = ByteToImage(dbFurniture.Furnitures.Find(ArticleID[CurrentID - 1]).Picture);
                        break;
                    }
            }
        }        

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Order order = new();
            BuyForm buyForm = new();
            buyForm.ShowDialog();
            order.BuyerName = buyForm.fieldFIO.Text;
            order.Address = buyForm.fieldAddress.Text;
            order.PhoneNumber = buyForm.fieldPhoneNumber.Text;
            order.ProductName = dbFurniture.Furnitures.Find(ArticleID[CurrentID-1]).Title;
            order.Price = dbFurniture.Furnitures.Find(ArticleID[CurrentID-1]).Price;
            order.Status = "In queue";
            if (order.BuyerName != "" && order.PhoneNumber != "" && order.Address != "")
            {
                dbOrder.Orders.Add(order);
                dbOrder.SaveChanges();
            }
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
