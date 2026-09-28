using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using servis_project.Data;

namespace WindowsFormsApp22
{
    public partial class PrijavaFrm : Form
    {
        public PrijavaFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                servis_project.prijava_Kupci_Result kupci = new servis_project.prijava_Kupci_Result();
                kupci = KupciDA.prijava(txtKorisnickoIme.Text, txtLozinka.Text);
                if (kupci != null && kupci.Aktivnost == true)
                {
                    Connection.kupac = kupci;
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else if (kupci != null && kupci.Aktivnost == false) {
                    lblPoruka.Text = "Korisnik nije aktivan.";
                    lblPoruka.Visible = true;
                    lblPoruka.ForeColor = Color.Red;
                }
                else
                {
                    lblPoruka.Text = "Pogrešni podaci";
                    lblPoruka.Visible = true;
                    lblPoruka.ForeColor = Color.Red;
                }
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
            else
                errorProvider.SetError(txtLozinka, "");
        }
         
        private void PrijavaFrm_Load(object sender, EventArgs e)
        {
          
          
            txtLozinka.PasswordChar = '*';
            this.AutoValidate = AutoValidate.Disable;
            lblPoruka.Visible = false;
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KupciUnosFrm unos=new KupciUnosFrm();
            unos.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar == '\0')
            {
                pictureBox3.BringToFront();
                txtLozinka.PasswordChar = '*';
            }
           
        }
    

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (txtLozinka.PasswordChar == '*')
            {
                pictureBox2.BringToFront();
               
                txtLozinka.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
