
namespace Seller.Views
{
    partial class EditForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewDescription = new System.Windows.Forms.TextBox();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.comboBoxNewType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxAvailability = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип мебели и введите её название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Кресла",
            "Столы",
            "Диваны",
            "Кровати"});
            this.comboBoxType.Location = new System.Drawing.Point(118, 12);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(123, 23);
            this.comboBoxType.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 76);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(229, 23);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(103, 135);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(138, 23);
            this.textBoxNewName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 101);
            this.label3.TabIndex = 12;
            this.label3.Text = "Описание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewDescription
            // 
            this.textBoxNewDescription.Location = new System.Drawing.Point(103, 164);
            this.textBoxNewDescription.Multiline = true;
            this.textBoxNewDescription.Name = "textBoxNewDescription";
            this.textBoxNewDescription.Size = new System.Drawing.Size(138, 101);
            this.textBoxNewDescription.TabIndex = 5;
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Location = new System.Drawing.Point(103, 271);
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(138, 23);
            this.textBoxNewPrice.TabIndex = 6;
            // 
            // comboBoxNewType
            // 
            this.comboBoxNewType.FormattingEnabled = true;
            this.comboBoxNewType.Items.AddRange(new object[] {
            "Кресла",
            "Столы",
            "Диваны",
            "Кровати"});
            this.comboBoxNewType.Location = new System.Drawing.Point(103, 300);
            this.comboBoxNewType.Name = "comboBoxNewType";
            this.comboBoxNewType.Size = new System.Drawing.Size(138, 23);
            this.comboBoxNewType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Тип";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxAvailability
            // 
            this.checkBoxAvailability.AutoSize = true;
            this.checkBoxAvailability.Location = new System.Drawing.Point(103, 329);
            this.checkBoxAvailability.Name = "checkBoxAvailability";
            this.checkBoxAvailability.Size = new System.Drawing.Size(84, 19);
            this.checkBoxAvailability.TabIndex = 8;
            this.checkBoxAvailability.Text = "В наличии";
            this.checkBoxAvailability.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(61, 354);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(164, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 395);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxAvailability);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxNewType);
            this.Controls.Add(this.textBoxNewPrice);
            this.Controls.Add(this.textBoxNewDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "Изменить продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.ComboBox comboBoxNewType;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox textBoxName;
        protected internal System.Windows.Forms.Button buttonFind;
        protected internal System.Windows.Forms.TextBox textBoxNewName;
        protected internal System.Windows.Forms.TextBox textBoxNewDescription;
        protected internal System.Windows.Forms.TextBox textBoxNewPrice;
        protected internal System.Windows.Forms.CheckBox checkBoxAvailability;
        protected internal System.Windows.Forms.Button buttonSave;
    }
}