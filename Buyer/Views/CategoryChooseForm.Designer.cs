
namespace Buyer
{
    partial class CategoryChooseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChairs = new System.Windows.Forms.Button();
            this.buttonSofas = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.buttonBeds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChairs
            // 
            this.buttonChairs.Location = new System.Drawing.Point(12, 12);
            this.buttonChairs.Name = "buttonChairs";
            this.buttonChairs.Size = new System.Drawing.Size(89, 48);
            this.buttonChairs.TabIndex = 0;
            this.buttonChairs.Text = "Кресла";
            this.buttonChairs.UseVisualStyleBackColor = true;
            this.buttonChairs.Click += new System.EventHandler(this.buttonChairs_Click);
            // 
            // buttonSofas
            // 
            this.buttonSofas.Location = new System.Drawing.Point(12, 66);
            this.buttonSofas.Name = "buttonSofas";
            this.buttonSofas.Size = new System.Drawing.Size(89, 48);
            this.buttonSofas.TabIndex = 1;
            this.buttonSofas.Text = "Диваны";
            this.buttonSofas.UseVisualStyleBackColor = true;
            this.buttonSofas.Click += new System.EventHandler(this.buttonSofas_Click);
            // 
            // buttonTables
            // 
            this.buttonTables.Location = new System.Drawing.Point(107, 12);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(89, 48);
            this.buttonTables.TabIndex = 2;
            this.buttonTables.Text = "Столы";
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // buttonBeds
            // 
            this.buttonBeds.Location = new System.Drawing.Point(107, 66);
            this.buttonBeds.Name = "buttonBeds";
            this.buttonBeds.Size = new System.Drawing.Size(89, 48);
            this.buttonBeds.TabIndex = 3;
            this.buttonBeds.Text = "Кровати";
            this.buttonBeds.UseVisualStyleBackColor = true;
            this.buttonBeds.Click += new System.EventHandler(this.buttonBeds_Click);
            // 
            // CategoryChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(206, 126);
            this.Controls.Add(this.buttonBeds);
            this.Controls.Add(this.buttonTables);
            this.Controls.Add(this.buttonSofas);
            this.Controls.Add(this.buttonChairs);
            this.Name = "CategoryChooseForm";
            this.Text = "Категории";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChairs;
        private System.Windows.Forms.Button buttonSofas;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.Button buttonBeds;
    }
}

