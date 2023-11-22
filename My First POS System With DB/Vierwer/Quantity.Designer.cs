namespace My_First_POS_System_With_DB.Vierwer
{
    partial class QuantityInputDialog
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
            this.textBoxQunatity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQunatity
            // 
            this.textBoxQunatity.Location = new System.Drawing.Point(219, 79);
            this.textBoxQunatity.Name = "textBoxQunatity";
            this.textBoxQunatity.Size = new System.Drawing.Size(335, 22);
            this.textBoxQunatity.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuantityInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxQunatity);
            this.Name = "QuantityInputDialog";
            this.Text = "Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQunatity;
        private System.Windows.Forms.Button button1;
    }
}