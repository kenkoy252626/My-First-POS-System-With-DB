namespace My_First_POS_System_With_DB.Vierwer
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Register = new System.Windows.Forms.LinkLabel();
            this.admin = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.passText = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LogPanel);
            this.panel1.Location = new System.Drawing.Point(80, 98);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12);
            this.panel1.Size = new System.Drawing.Size(909, 414);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogPanel
            // 
            this.LogPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogPanel.Controls.Add(this.linkLabel2);
            this.LogPanel.Controls.Add(this.Register);
            this.LogPanel.Controls.Add(this.admin);
            this.LogPanel.Controls.Add(this.Login);
            this.LogPanel.Controls.Add(this.pictureBox3);
            this.LogPanel.Controls.Add(this.pictureBox2);
            this.LogPanel.Controls.Add(this.showPass);
            this.LogPanel.Controls.Add(this.passText);
            this.LogPanel.Controls.Add(this.PassBox);
            this.LogPanel.Controls.Add(this.userText);
            this.LogPanel.Controls.Add(this.UserBox);
            this.LogPanel.Controls.Add(this.label4);
            this.LogPanel.Controls.Add(this.label3);
            this.LogPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogPanel.Location = new System.Drawing.Point(0, 0);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(385, 424);
            this.LogPanel.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(274, 390);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(27, 388);
            this.Register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(122, 13);
            this.Register.TabIndex = 16;
            this.Register.TabStop = true;
            this.Register.Text = "Add a Cashier Account?";
            this.Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Register_LinkClicked);
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.admin.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.admin.ForeColor = System.Drawing.Color.GhostWhite;
            this.admin.Location = new System.Drawing.Point(118, 325);
            this.admin.Name = "admin";
            this.admin.Padding = new System.Windows.Forms.Padding(10);
            this.admin.Size = new System.Drawing.Size(151, 49);
            this.admin.TabIndex = 13;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Login.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.Login.ForeColor = System.Drawing.Color.GhostWhite;
            this.Login.Location = new System.Drawing.Point(118, 270);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(10);
            this.Login.Size = new System.Drawing.Size(151, 49);
            this.Login.TabIndex = 12;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(55, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.ForeColor = System.Drawing.Color.Blue;
            this.showPass.Location = new System.Drawing.Point(252, 244);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(119, 20);
            this.showPass.TabIndex = 9;
            this.showPass.Text = "ShowPassword";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.passText.Enabled = false;
            this.passText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.passText.Location = new System.Drawing.Point(164, 208);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(95, 21);
            this.passText.TabIndex = 8;
            this.passText.Text = "PASSWORD";
            this.passText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.PassBox.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PassBox.Location = new System.Drawing.Point(100, 201);
            this.PassBox.Multiline = true;
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.Size = new System.Drawing.Size(242, 37);
            this.PassBox.TabIndex = 7;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.userText.Enabled = false;
            this.userText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.userText.Location = new System.Drawing.Point(164, 132);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(92, 21);
            this.userText.TabIndex = 6;
            this.userText.Text = "USERNAME";
            this.userText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.UserBox.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UserBox.Location = new System.Drawing.Point(100, 125);
            this.UserBox.Multiline = true;
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(242, 37);
            this.UserBox.TabIndex = 5;
            this.UserBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(32, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 62);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CASHIER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.75F);
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(458, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "STORE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Elephant", 50.75F);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(338, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "KENKS";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1050, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel Register;
    }
}