namespace My_First_POS_System_With_DB
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.Productimage = new System.Windows.Forms.PictureBox();
            this.Producttext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Productimage)).BeginInit();
            this.SuspendLayout();
            // 
            // Productimage
            // 
            this.Productimage.Image = ((System.Drawing.Image)(resources.GetObject("Productimage.Image")));
            this.Productimage.Location = new System.Drawing.Point(15, 27);
            this.Productimage.Name = "Productimage";
            this.Productimage.Size = new System.Drawing.Size(236, 203);
            this.Productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Productimage.TabIndex = 0;
            this.Productimage.TabStop = false;
            // 
            // Producttext
            // 
            this.Producttext.AutoSize = true;
            this.Producttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producttext.Location = new System.Drawing.Point(92, 233);
            this.Producttext.Name = "Producttext";
            this.Producttext.Size = new System.Drawing.Size(59, 20);
            this.Producttext.TabIndex = 1;
            this.Producttext.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Producttext);
            this.Controls.Add(this.Productimage);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(264, 286);
            ((System.ComponentModel.ISupportInitialize)(this.Productimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Productimage;
        private System.Windows.Forms.Label Producttext;
    }
}
