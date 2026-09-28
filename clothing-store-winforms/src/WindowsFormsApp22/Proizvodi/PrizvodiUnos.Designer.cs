namespace WindowsFormsApp22.Proizvodi
{
    partial class PrizvodiUnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrizvodiUnos));
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cbxVelicina = new System.Windows.Forms.ComboBox();
            this.cbxBoja = new System.Windows.Forms.ComboBox();
            this.cbxKategorije = new System.Windows.Forms.ComboBox();
            this.pictureBoxslikaproizvoda = new System.Windows.Forms.PictureBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxslikaproizvoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(509, 290);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(191, 20);
            this.slikaInput.TabIndex = 0;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNaziv.Location = new System.Drawing.Point(180, 206);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(180, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtCijena
            // 
            this.txtCijena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCijena.Location = new System.Drawing.Point(180, 342);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(180, 20);
            this.txtCijena.TabIndex = 2;
            // 
            // cbxVelicina
            // 
            this.cbxVelicina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxVelicina.FormattingEnabled = true;
            this.cbxVelicina.Location = new System.Drawing.Point(180, 294);
            this.cbxVelicina.Name = "cbxVelicina";
            this.cbxVelicina.Size = new System.Drawing.Size(180, 21);
            this.cbxVelicina.TabIndex = 3;
            // 
            // cbxBoja
            // 
            this.cbxBoja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxBoja.FormattingEnabled = true;
            this.cbxBoja.Location = new System.Drawing.Point(180, 398);
            this.cbxBoja.Name = "cbxBoja";
            this.cbxBoja.Size = new System.Drawing.Size(180, 21);
            this.cbxBoja.TabIndex = 4;
            // 
            // cbxKategorije
            // 
            this.cbxKategorije.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbxKategorije.FormattingEnabled = true;
            this.cbxKategorije.Location = new System.Drawing.Point(180, 248);
            this.cbxKategorije.Name = "cbxKategorije";
            this.cbxKategorije.Size = new System.Drawing.Size(180, 21);
            this.cbxKategorije.TabIndex = 5;
            // 
            // pictureBoxslikaproizvoda
            // 
            this.pictureBoxslikaproizvoda.Location = new System.Drawing.Point(509, 176);
            this.pictureBoxslikaproizvoda.Name = "pictureBoxslikaproizvoda";
            this.pictureBoxslikaproizvoda.Size = new System.Drawing.Size(191, 93);
            this.pictureBoxslikaproizvoda.TabIndex = 6;
            this.pictureBoxslikaproizvoda.TabStop = false;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.ForeColor = System.Drawing.Color.Black;
            this.lblPoruka.Location = new System.Drawing.Point(506, 327);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(93, 13);
            this.lblPoruka.TabIndex = 78;
            this.lblPoruka.Text = "Neispravan format";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(142, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 42);
            this.button3.TabIndex = 79;
            this.button3.Text = "SPREMI PODATKE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.Black;
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajSliku.Location = new System.Drawing.Point(509, 360);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(191, 39);
            this.btnDodajSliku.TabIndex = 80;
            this.btnDodajSliku.Text = "DODAJ SLIKU";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Velicna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Boja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PrizvodiUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(899, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.pictureBoxslikaproizvoda);
            this.Controls.Add(this.cbxKategorije);
            this.Controls.Add(this.cbxBoja);
            this.Controls.Add(this.cbxVelicina);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.slikaInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrizvodiUnos";
            this.Text = "Unos proizvoda - ZARA";
            this.Load += new System.EventHandler(this.PrizvodiUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxslikaproizvoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cbxVelicina;
        private System.Windows.Forms.ComboBox cbxBoja;
        private System.Windows.Forms.ComboBox cbxKategorije;
        private System.Windows.Forms.PictureBox pictureBoxslikaproizvoda;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}