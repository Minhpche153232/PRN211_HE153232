namespace PRN211_HE153232
{
    partial class Edit
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty2 = new System.Windows.Forms.NumericUpDown();
            this.txtCategory2 = new System.Windows.Forms.ComboBox();
            this.txtPrice2 = new System.Windows.Forms.NumericUpDown();
            this.txtDes2 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(197, 286);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.Size = new System.Drawing.Size(150, 27);
            this.txtQty2.TabIndex = 15;
            // 
            // txtCategory2
            // 
            this.txtCategory2.FormattingEnabled = true;
            this.txtCategory2.Location = new System.Drawing.Point(197, 348);
            this.txtCategory2.Name = "txtCategory2";
            this.txtCategory2.Size = new System.Drawing.Size(151, 28);
            this.txtCategory2.TabIndex = 14;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(197, 227);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(150, 27);
            this.txtPrice2.TabIndex = 13;
            // 
            // txtDes2
            // 
            this.txtDes2.Location = new System.Drawing.Point(197, 90);
            this.txtDes2.Multiline = true;
            this.txtDes2.Name = "txtDes2";
            this.txtDes2.Size = new System.Drawing.Size(282, 102);
            this.txtDes2.TabIndex = 12;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(197, 21);
            this.txtName2.Multiline = true;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(282, 38);
            this.txtName2.TabIndex = 11;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 465);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty2);
            this.Controls.Add(this.txtCategory2);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtDes2);
            this.Controls.Add(this.txtName2);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.txtQty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown txtQty2;
        private ComboBox txtCategory2;
        private NumericUpDown txtPrice2;
        private TextBox txtDes2;
        private TextBox txtName2;
    }
}