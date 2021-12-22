
namespace CookieClicker
{
    partial class Form1
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
            this.noodlePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.noodlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // noodlePictureBox
            // 
            this.noodlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.noodlePictureBox.BackgroundImage = global::CookieClicker.Properties.Resources.pasta1;
            this.noodlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noodlePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noodlePictureBox.Location = new System.Drawing.Point(192, 130);
            this.noodlePictureBox.Name = "noodlePictureBox";
            this.noodlePictureBox.Size = new System.Drawing.Size(200, 200);
            this.noodlePictureBox.TabIndex = 1;
            this.noodlePictureBox.TabStop = false;
            this.noodlePictureBox.Click += new System.EventHandler(this.noodlePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.noodlePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noodlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox noodlePictureBox;
    }
}

