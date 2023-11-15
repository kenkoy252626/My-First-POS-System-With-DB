namespace My_First_POS_System_With_DB.Admin
{
    partial class AddItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Additem = new System.Windows.Forms.Button();
            this.combocategory = new System.Windows.Forms.ComboBox();
            this.itemstock = new System.Windows.Forms.TextBox();
            this.itemprice = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.Selectimage = new System.Windows.Forms.Button();
            this.pictureitem = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.itemShow = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureitem)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Additem);
            this.panel1.Controls.Add(this.combocategory);
            this.panel1.Controls.Add(this.itemstock);
            this.panel1.Controls.Add(this.itemprice);
            this.panel1.Controls.Add(this.itemname);
            this.panel1.Controls.Add(this.Selectimage);
            this.panel1.Controls.Add(this.pictureitem);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 359);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CATEGORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ITEMSTOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ITEMPRICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ITEMNAME";
            // 
            // Additem
            // 
            this.Additem.Location = new System.Drawing.Point(639, 246);
            this.Additem.Name = "Additem";
            this.Additem.Size = new System.Drawing.Size(227, 47);
            this.Additem.TabIndex = 7;
            this.Additem.Text = "ADD";
            this.Additem.UseVisualStyleBackColor = true;
            this.Additem.Click += new System.EventHandler(this.Additem_Click);
            // 
            // combocategory
            // 
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "BURGER",
            "CHICKEN",
            "DRINKS"});
            this.combocategory.Location = new System.Drawing.Point(682, 212);
            this.combocategory.Name = "combocategory";
            this.combocategory.Size = new System.Drawing.Size(131, 21);
            this.combocategory.TabIndex = 6;
            // 
            // itemstock
            // 
            this.itemstock.Location = new System.Drawing.Point(620, 155);
            this.itemstock.Multiline = true;
            this.itemstock.Name = "itemstock";
            this.itemstock.Size = new System.Drawing.Size(257, 38);
            this.itemstock.TabIndex = 4;
            // 
            // itemprice
            // 
            this.itemprice.Location = new System.Drawing.Point(620, 101);
            this.itemprice.Multiline = true;
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(257, 38);
            this.itemprice.TabIndex = 3;
            // 
            // itemname
            // 
            this.itemname.Location = new System.Drawing.Point(620, 40);
            this.itemname.Multiline = true;
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(257, 40);
            this.itemname.TabIndex = 2;
            // 
            // Selectimage
            // 
            this.Selectimage.Location = new System.Drawing.Point(74, 246);
            this.Selectimage.Name = "Selectimage";
            this.Selectimage.Size = new System.Drawing.Size(227, 45);
            this.Selectimage.TabIndex = 1;
            this.Selectimage.Text = "SELECT IMAGE";
            this.Selectimage.UseVisualStyleBackColor = true;
            this.Selectimage.Click += new System.EventHandler(this.Selectimage_Click_1);
            // 
            // pictureitem
            // 
            this.pictureitem.BackColor = System.Drawing.Color.White;
            this.pictureitem.Location = new System.Drawing.Point(74, 40);
            this.pictureitem.Name = "pictureitem";
            this.pictureitem.Size = new System.Drawing.Size(227, 187);
            this.pictureitem.TabIndex = 0;
            this.pictureitem.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.itemShow);
            this.panel2.Location = new System.Drawing.Point(38, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 278);
            this.panel2.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(728, 23);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(257, 40);
            this.search.TabIndex = 13;
            // 
            // itemShow
            // 
            this.itemShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemShow.Location = new System.Drawing.Point(63, 78);
            this.itemShow.Name = "itemShow";
            this.itemShow.Size = new System.Drawing.Size(1001, 174);
            this.itemShow.TabIndex = 0;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1192, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddItems";
            this.Text = " b";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureitem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combocategory;
        private System.Windows.Forms.TextBox itemstock;
        private System.Windows.Forms.TextBox itemprice;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Button Selectimage;
        private System.Windows.Forms.PictureBox pictureitem;
        private System.Windows.Forms.DataGridView itemShow;
        private System.Windows.Forms.Button Additem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
    }
}