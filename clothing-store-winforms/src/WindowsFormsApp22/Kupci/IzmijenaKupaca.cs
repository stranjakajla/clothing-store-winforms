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
    public partial class IzmijenaKupaca : Form
    {
        public static int id { get; set; }
        public  static servis_project.Kupci kupci =new servis_project.Kupci();
        public IzmijenaKupaca()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            UcitajGrid();
        }
        private void UcitajGrid()
        {
            dataGridView1.DataSource = KupciDA.KupciGriD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }

      
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int KupciID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    kupci = KupciDA.GetKupciByID(KupciID);
                    UcitajPodatke();
                }
                else
                {
                    lblporuka.Visible = true;
                    lblporuka.ForeColor = Color.Red;
                }
            }
        }

        private void UcitajPodatke()
        {
            txtKorisnickoIme.Text = kupci.KorisnickoIme;
            txtLozinka.Text= kupci.Lozinka;
            txtIme.Text= kupci.Ime;
            txtPrezime.Text=kupci.Prezime;
            txtAdresa.Text= kupci.Adresa;
            txtDodatneInformacije.Text = kupci.DodatneInformacije;
            txtPostanskiBroj.Text =  kupci.PostanskiBroj.ToString();
            txtGrad.Text= kupci.Grad;
            txtRegija.Text= kupci.Regija;
            txtKontaktTelfon.Text = kupci.KontaktTelefon;
          

            
        }

        private void SpasiPodatke()

        {
            if (dataGridView1.Rows.Count != 0)
            {
                kupci.KorisnickoIme = txtKorisnickoIme.Text;
                kupci.Lozinka = txtLozinka.Text;
                kupci.Ime = txtIme.Text;
                kupci.Prezime = txtPrezime.Text;
                kupci.Adresa = txtAdresa.Text;
                kupci.DodatneInformacije = txtDodatneInformacije.Text;
                kupci.PostanskiBroj = Convert.ToInt32(txtPostanskiBroj.Text);
                kupci.Grad = txtGrad.Text;
                kupci.Regija = txtRegija.Text;
                kupci.KontaktTelefon = txtKontaktTelfon.Text;
            }
            else
                MessageBox.Show("Morate odabrati kupca za izmjenu!");
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SpasiPodatke();
            KupciDA.UpdateKupaca(kupci);
            UcitajGrid();
            OcistiFormu();
            kupci = null;
        }

        private void OcistiFormu()
        {
            txtKorisnickoIme.Text = "";
            txtLozinka.Text = "";
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtAdresa.Text = "";
            txtDodatneInformacije.Text = "";
            txtPostanskiBroj.Text = "";
            txtGrad.Text = "";
            txtRegija.Text = "";
            txtKontaktTelfon.Text = "";
        }

        private void IzmijenaKupaca_Load(object sender, EventArgs e)
        {
            
            lblporuka.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije=new KategorijeFrm();
            kategorije.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();    
            form2.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
        
        }
      

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            NarudzbeFrm narudzbe = new NarudzbeFrm(id);
            narudzbe.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            PretragaFrm pretraga = new PretragaFrm();
            pretraga.Show();
            this.Hide();
        }
    }
}
