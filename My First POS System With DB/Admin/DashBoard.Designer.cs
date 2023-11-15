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
            this.label1 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Button();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.items = new System.Windows.Forms.Button();
            this.casheirs = new System.Windows.Forms.Button();
            this.transaction = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // account
            // 
            this.account.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(11, 113);
            this.account.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(137, 58);
            this.account.TabIndex = 2;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            // 
            // flow
            // 
            this.flow.BackColor = System.Drawing.Color.White;
            this.flow.Location = new System.Drawing.Point(152, 19);
            this.flow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(1192, 671);
            this.flow.TabIndex = 3;
            // 
            // items
            // 
            this.items.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items.Location = new System.Drawing.Point(11, 190);
            this.items.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(137, 58);
            this.items.TabIndex = 4;
            this.items.Text = "Items";
            this.items.UseVisualStyleBackColor = true;
            this.items.Click += new System.EventHandler(this.Items_Click);
            // 
            // casheirs
            // 
            this.casheirs.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casheirs.Location = new System.Drawing.Point(11, 273);
            this.casheirs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.casheirs.Name = "casheirs";
            this.casheirs.Size = new System.Drawing.Size(137, 58);
            this.casheirs.TabIndex = 5;
            this.casheirs.Text = "Casheirs";
            this.casheirs.UseVisualStyleBackColor = true;
            // 
            // transaction
            // 
            this.transaction.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction.Location = new System.Drawing.Point(11, 352);
            this.transaction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(137, 58);
            this.transaction.TabIndex = 6;
            this.transaction.Text = "Transaction";
            this.transaction.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(26, 540);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 58);
            this.logout.TabIndex = 8;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(26, 465);
            this.print.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(100, 58);
            this.print.TabIndex = 7;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1368, 718);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.print);
            this.Controls.Add(this.transaction);
            this.Controls.Add(this.casheirs);
            this.Controls.Add(this.items);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.Button items;
        private System.Windows.Forms.Button casheirs;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button print;
    }
}