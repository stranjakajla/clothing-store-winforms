using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using servis_project;
using servis_project.Data;

namespace WindowsFormsApp22
{
    public partial class KosaricaFrm : Form
    {
        public List<GridProizvodByProizvodID_Result> listaProizvodaKosarica = new List<GridProizvodByProizvodID_Result>();
        public KosaricaFrm(List <GridProizvodByProizvodID_Result> listapro)
        {
            InitializeComponent();
            listaProizvodaKosarica = listapro;
        }

        private void KosaricaFrm_Load(object sender, EventArgs e)
        {
            lblPorukaKosarica.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listaProizvodaKosarica;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prijava_Kupci_Result kupac = Connection.kupac;
            if (dataGridView1.SelectedRows.Count > 0 && kupac!=null )
           {
               
                servis_project.Narudzbe narudzba = new servis_project.Narudzbe();
                narudzba.DatumNarudzbe = DateTime.Now;
                narudzba.DatumIsporuke = DateTime.Now;
                narudzba.BrojNarudzbe = null;
                narudzba.Kupac = kupac.KupciID;
                narudzba.StatusNarudzbe = 1;
                NarudzbeDA.InsertNarudzbe(narudzba);
                int? id = NarudzbeDA.getPosljednjuNarudzbu();
                for (int i = 0; i < listaProizvodaKosarica.Count; i++)
                {

                    servis_project.Detalji detalj=new servis_project.Detalji();
                    detalj.Narudzba = (int)id;
                    detalj.Proizvod = listaProizvodaKosarica[i].ProizvodiID;
                    int kolicina = 0;
                    for (int j = 0; j < listaProizvodaKosarica.Count; j++)
                    {
                        if (listaProizvodaKosarica[i].ProizvodiID == detalj.Proizvod)
                        {
                            kolicina++;

                        }
                    }
                    detalj.Kolicina = kolicina;
                    DetaljiDA.InsertDetalja(detalj);
                }
                int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                NarudzbeFrm narudzbe = new NarudzbeFrm(ID);
                narudzbe.Show();
                this.Hide();
            }
            else if (kupac == null)
            {
                PrijavaFrm prijava=new PrijavaFrm();
                prijava.Show();
                this.Hide();
            }
            else
            {
                    lblPorukaKosarica.Visible = true;
                lblPorukaKosarica.ForeColor = Color.Red;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 =new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PretragaFrm p = new PretragaFrm();
            p.Show();
            this.Hide();
        }
    }
}
