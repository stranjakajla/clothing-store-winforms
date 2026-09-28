using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using servis_project.Data;
using servis_project;
using WindowsFormsApp22.Slike;
using System.Configuration;
using System.IO;

namespace WindowsFormsApp22.Proizvodi
{
    public partial class PrizvodiUnos : Form
    {

        public servis_project.Proizvod proizvod = new servis_project.Proizvod();
        public PrizvodiUnos()
        {
            InitializeComponent();
        }

        private void PrizvodiUnos_Load(object sender, EventArgs e)
        {
            lblPoruka.Visible = false;
            UcitajBoje();
            UcitajKategroije();
            UcitajVelicine();
        }

        private void UcitajVelicine()
        {

            cbxVelicina.DataSource = VelicinaDA4.velicinacombo();
            cbxVelicina.DisplayMember = "Naziv";
            cbxVelicina.ValueMember = "VelicinaID";
        }

        private void UcitajKategroije()
        {
            cbxKategorije.DataSource = KategorijeDA.getKategorijeCmbx();
            cbxKategorije.DisplayMember = "Naziv";
            cbxKategorije.ValueMember = "KategorijeID";
        }

        private void UcitajBoje()
        {
            cbxBoja.DataSource = BojaDA.bojacombo();
            cbxBoja.DisplayMember = "Naziv";
            cbxBoja.ValueMember = "BojaID";
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            proizvod.Naziv = txtNaziv.Text;
            proizvod.Kategorija = (int)cbxKategorije.SelectedValue;
            proizvod.Velicina = (int)cbxVelicina.SelectedValue;
            proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);
            proizvod.BojaID = (int)cbxBoja.SelectedValue;
            ProizvodiDA.InsertProizvoda(proizvod);
            MessageBox.Show("Uspješno ste dodali proizvod u košaricu");
            txtNaziv.Text = "";
            cbxKategorije.SelectedIndex = 0;
            cbxVelicina.SelectedIndex = 0;
            txtCijena.Text = "";
            cbxBoja.SelectedIndex = 0;

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                if (proizvod == null)
                    proizvod = new servis_project.Proizvod();
                openFileDialog.ShowDialog();
                if (UIHelper.IsValidImage(openFileDialog.FileName))
                {
                    slikaInput.Text = openFileDialog.FileName;
                    lblPoruka.Visible = false;
                    Image image = Image.FromFile(slikaInput.Text);
                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    proizvod.Slika = ms.ToArray();

                    int resizedWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                    int resizedHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                    int croppedWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                    int croppedHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                    if (image.Width > resizedWidth)
                    {
                        Image croppedImage;

                        ms = new MemoryStream();
                        image = UIHelper.resizeImage(image, new Size(132, 132));
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        croppedImage = image;
                        proizvod.SlikaThumb = ms.ToArray();


                        pictureBoxslikaproizvoda.Image = croppedImage;
                    }

                    else
                    {
                        proizvod = null;
                    }
                }
                else
                {
                    lblPoruka.Visible = true;
                    lblPoruka.ForeColor = Color.Red;
                }


            }
            catch (Exception)
            {
                proizvod = null;
                pictureBoxslikaproizvoda.Image = null;
                slikaInput.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
