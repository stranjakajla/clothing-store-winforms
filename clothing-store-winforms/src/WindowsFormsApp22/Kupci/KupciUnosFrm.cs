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

namespace WindowsFormsApp22
{
    public partial class KupciUnosFrm : Form
    {
        public static int id { get; set; }
        public KupciUnosFrm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void KupciUnosFrm_Load(object sender, EventArgs e)
        {
            txtLozinka.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() && checkBox1.Checked)
            {
                servis_project.Kupci kupci = new servis_project.Kupci();
                kupci.KorisnickoIme=txtKorisnickoIme.Text;
                kupci.Lozinka=txtLozinka.Text;
                kupci.Ime = txtIme.Text;
                kupci.Prezime=txtPrezime.Text;
                kupci.Adresa=txtAdresa.Text;
                kupci.DodatneInformacije=txtDodatneInformacije.Text;
                kupci.PostanskiBroj = Convert.ToInt32(txtPostanskiBroj.Text);
                kupci.Grad = txtGrad.Text;
                kupci.Regija = txtRegija.Text;
                kupci.KontaktTelefon=txtKontaktTelfon.Text;
                kupci.Aktivnost = checkBox1.Checked;
                KupciDA.InsertKupci(kupci);
                PrijavaFrm prijava=new PrijavaFrm();
                prijava.Show();
                this.Hide();
            }
           
        }

      

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtKorisnickoIme.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, "Korisnicko ime je obavezno polje.");
            }
            else
                errorProvider.SetError(txtKorisnickoIme, "");
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (txtLozinka.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, "Lozinka je obavezno polje.");
            }
            else if (txtLozinka.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, "Lozinka mora imati najmanje 8 karaktera");
            }
            else
                errorProvider.SetError(txtLozinka, "");
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (txtIme.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Ime je obavezno polje.");
            }
            else
                errorProvider.SetError(txtIme, "");
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrezime.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, "Prezime je obavezno polje.");
            }
            else
                errorProvider.SetError(txtPrezime, "");
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdresa.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtAdresa, "Adresa je obavezno polje.");
            }
            else
                errorProvider.SetError(txtAdresa, "");
        }

        private void txtPostanskiBroj_Validating(object sender, CancelEventArgs e)
        {
            int broj;
            bool provjera = Int32.TryParse(txtPostanskiBroj.Text, out broj);
            if (txtPostanskiBroj.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtPostanskiBroj, "Poštanski broj je obavezno polje.");
            }
            else if (provjera == false)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPostanskiBroj, "Ne mozete unijeti vrijednost koja nije cijeli broj.");

            }
            else
                errorProvider.SetError(txtPostanskiBroj, "");
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (txtGrad.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtGrad, "Grad je obavezno polje.");
            }
            else
                errorProvider.SetError(txtGrad, "");
        }

        private void txtRegija_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegija.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtRegija, "Regija je obavezno polje.");
            }
            else
                errorProvider.SetError(txtRegija, "");
        }

        private void txtKontaktTelfon_Validating(object sender, CancelEventArgs e)
        {
            if (txtKontaktTelfon.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtKontaktTelfon, "Kontakt telfon je obavezno polje.");
            }
            else
                errorProvider.SetError(txtKontaktTelfon, "");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije = new KategorijeFrm();
            kategorije.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void checkBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!checkBox1.Checked)
            {
                e.Cancel = true;
                errorProvider.SetError(checkBox1, "Aktivnost je obavezno polje.");
            }
            else
                errorProvider.SetError(checkBox1, "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije = new KategorijeFrm();
            kategorije.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            PretragaFrm p = new PretragaFrm();
            p.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

            Kupci kupci = new Kupci();
            if (kupci != null)
            {
                NarudzbeFrm na = new NarudzbeFrm(id);
                na.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ne možete otvoriti formu sa narudžabama bez prijave!");
                PrijavaFrm prijava=new PrijavaFrm();
                prijava.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PrijavaFrm prijava=new PrijavaFrm();
            prijava.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar == '*')
            {
                pictureBox5.BringToFront();

                txtLozinka.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                txtLozinka.PasswordChar = '*';
            }
        }
    }
}
