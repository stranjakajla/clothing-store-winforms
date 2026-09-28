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
    public partial class Form2 : Form
    {
       public static int id { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije=new KategorijeFrm();
            kategorije.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kupci kupci=new Kupci();
            if (kupci == null || kupci != null)
            {
                PretragaFrm pretragaFrm = new PretragaFrm();
                pretragaFrm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            prijava_Kupci_Result kupac = Connection.kupac;
            if (kupac != null)
            {
                IzmijenaKupaca izmijena = new IzmijenaKupaca();
                izmijena.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Žao nam je ne možete uraditi izmjenu dok se ne prijavite", "Poruka");
                PrijavaFrm prijava=new PrijavaFrm();
                prijava.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
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
                PrijavaFrm prijava = new PrijavaFrm();
                prijava.Show();
                this.Hide();
            }
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorijeFrm = new KategorijeFrm();
            kategorijeFrm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NarudzbeFrm narudzbe=new NarudzbeFrm(id);
            narudzbe.Show();
            this.Hide();
          
        }
    }
}
