namespace My_First_POS_System_With_DB.Admin
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.label1 = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cashier = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // flow
            // 
            this.flow.BackColor = System.Drawing.Color.White;
            this.flow.Location = new System.Drawing.Point(176, 42);
            this.flow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(1207, 683);
            this.flow.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Login.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.Login.ForeColor = System.Drawing.Color.GhostWhite;
            this.Login.Location = new System.Drawing.Point(12, 231);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Login.Size = new System.Drawing.Size(159, 49);
            this.Login.TabIndex = 13;
            this.Login.Text = "Account";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(12, 427);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Transaction";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cashier
            // 
            this.cashier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cashier.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.cashier.ForeColor = System.Drawing.Color.GhostWhite;
            this.cashier.Location = new System.Drawing.Point(12, 358);
            this.cashier.Name = "cashier";
            this.cashier.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cashier.Size = new System.Drawing.Size(159, 49);
            this.cashier.TabIndex = 15;
            this.cashier.Text = "Cashier";
            this.cashier.UseVisualStyleBackColor = false;
            this.cashier.Click += new System.EventHandler(this.cashier_Click);
            // 
            // items
            // 
            this.items.BackColor = System.Drawing.Color.LightSkyBlue;
            this.items.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.items.ForeColor = System.Drawing.Color.GhostWhite;
            this.items.Location = new System.Drawing.Point(12, 295);
            this.items.Name = "items";
            this.items.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.items.Size = new System.Drawing.Size(159, 49);
            this.items.TabIndex = 16;
            this.items.Text = "Items";
            this.items.UseVisualStyleBackColor = false;
            this.items.Click += new System.EventHandler(this.items_Click_1);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logout.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.logout.ForeColor = System.Drawing.Color.GhostWhite;
            this.logout.Location = new System.Drawing.Point(31, 670);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.logout.Size = new System.Drawing.Size(124, 55);
            this.logout.TabIndex = 17;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.button5.ForeColor = System.Drawing.Color.GhostWhite;
            this.button5.Location = new System.Drawing.Point(43, 615);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.button5.Size = new System.Drawing.Size(102, 49);
            this.button5.TabIndex = 18;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1431, 765);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.items);
            this.Controls.Add(this.cashier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cashier;
        private System.Windows.Forms.Button items;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}