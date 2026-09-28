namespace WindowsFormsApp22.Proizvodi
{
    partial class PrikazSlikeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrikazSlikeFrm));
            this.pictureBoxSlikaProizvoda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSlikaProizvoda
            // 
            this.pictureBoxSlikaProizvoda.Location = new System.Drawing.Point(53, 30);
            this.pictureBoxSlikaProizvoda.Name = "pictureBoxSlikaProizvoda";
            this.pictureBoxSlikaProizvoda.Size = new System.Drawing.Size(698, 390);
            this.pictureBoxSlikaProizvoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSlikaProizvoda.TabIndex = 0;
            this.pictureBoxSlikaProizvoda.TabStop = false;
            // 
            // PrikazSlikeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxSlikaProizvoda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrikazSlikeFrm";
            this.Text = "Prikaz slike - ZARA";
            this.Load += new System.EventHandler(this.PrikazSlikeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaProizvoda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSlikaProizvoda;
    }
}