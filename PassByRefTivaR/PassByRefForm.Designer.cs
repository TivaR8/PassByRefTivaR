namespace PassByRefTivaR
{
    partial class frmPassByRef
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
            this.lblAboveText = new System.Windows.Forms.Label();
            this.picImages = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboveText
            // 
            this.lblAboveText.AutoSize = true;
            this.lblAboveText.Location = new System.Drawing.Point(99, 30);
            this.lblAboveText.Name = "lblAboveText";
            this.lblAboveText.Size = new System.Drawing.Size(139, 13);
            this.lblAboveText.TabIndex = 0;
            this.lblAboveText.Text = "Click on Image to change it.";
            this.lblAboveText.MouseLeave += new System.EventHandler(this.lblAboveText_MouseLeave);
            this.lblAboveText.MouseHover += new System.EventHandler(this.lblAboveText_MouseHover);
            // 
            // picImages
            // 
            this.picImages.Image = global::PassByRefTivaR.Properties.Resources.AC;
            this.picImages.Location = new System.Drawing.Point(74, 78);
            this.picImages.Name = "picImages";
            this.picImages.Size = new System.Drawing.Size(191, 261);
            this.picImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImages.TabIndex = 1;
            this.picImages.TabStop = false;
            this.picImages.Click += new System.EventHandler(this.picImages_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.picImages);
            this.Controls.Add(this.lblAboveText);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Reference By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.picImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboveText;
        private System.Windows.Forms.PictureBox picImages;
    }
}

