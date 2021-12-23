
namespace Buyer.Views
{
    partial class BuyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fieldFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldAddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fieldPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldFIO
            // 
            this.fieldFIO.Location = new System.Drawing.Point(118, 12);
            this.fieldFIO.Name = "fieldFIO";
            this.fieldFIO.Size = new System.Drawing.Size(100, 23);
            this.fieldFIO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldAddress
            // 
            this.fieldAddress.Location = new System.Drawing.Point(118, 41);
            this.fieldAddress.Name = "fieldAddress";
            this.fieldAddress.Size = new System.Drawing.Size(100, 23);
            this.fieldAddress.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fieldPhoneNumber
            // 
            this.fieldPhoneNumber.Location = new System.Drawing.Point(118, 70);
            this.fieldPhoneNumber.Name = "fieldPhoneNumber";
            this.fieldPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.fieldPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер телефона";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 127);
            this.Controls.Add(this.fieldPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldFIO);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(245, 166);
            this.MinimumSize = new System.Drawing.Size(245, 166);
            this.Name = "BuyForm";
            this.Text = "Купить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox fieldFIO;
        protected internal System.Windows.Forms.TextBox fieldAddress;
        protected internal System.Windows.Forms.TextBox fieldPhoneNumber;
    }
}