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
    public partial class KategorijeFrm : Form
    {
        public List<GridProizvodByProizvodID_Result> listaProizvodaKosarica = new List<GridProizvodByProizvodID_Result>();

        public KategorijeFrm()
        {
            InitializeComponent();
        }
        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void KategorijeFrm_Load(object sender, EventArgs e)
        {
            lblPorukaIzbrisi.Visible = false;
            lblPorukaKosarica.Visible = false;
            lblpregledFotografije.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            UcitajKategorije();
            UcitajGrid();
        }


        private void UcitajGrid()
        {
            dataGridView1.DataSource = ProizvodiDA.getProizvodiGrid();
        }

        private void UcitajKategorije()
        {
            comboBox1.DataSource = KategorijeDA.getKategorijeCmbx();
            comboBox1.ValueMember = "KategorijeID";
            comboBox1.DisplayMember = "Naziv";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 1)
            {
                UcitajGrid();
            }
            else
            {
                dataGridView1.DataSource = ProizvodiDA.pretragaProizvodByKategorija(Convert.ToInt32(comboBox1.SelectedValue));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                lblPorukaKosarica.Visible = false;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    GridProizvodByProizvodID_Result proizvod = new GridProizvodByProizvodID_Result();
                    proizvod = ProizvodiDA.getGridProizvodiGridbyID(ID);
                    if (proizvod != null)

                    {
                        listaProizvodaKosarica.Add(proizvod);
                        UcitajGridZaPregledKosarice();
                    }
                }
                else
                {

                    lblPorukaKosarica.Visible = true;
                    lblPorukaKosarica.ForeColor = Color.Red;
                }

            }


        }

        private void UcitajGridZaPregledKosarice()
        {
            var lista = new List<GridProizvodByProizvodID_Result>(listaProizvodaKosarica);
            dataGridView2.DataSource = lista;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PretragaFrm pretraga = new PretragaFrm();
            pretraga.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                lblPorukaIzbrisi.Visible = false;
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                    int indeks = -1;
                    GridProizvodByProizvodID_Result proizvod = new GridProizvodByProizvodID_Result();
                    proizvod = ProizvodiDA.getGridProizvodiGridbyID(ID);

                    for (int i = 0; i < listaProizvodaKosarica.Count; i++)
                    {
                        if (listaProizvodaKosarica[i].ProizvodiID == ID)
                        {
                            indeks = i;
                        }
                    }

                    if (indeks != -1)

                        listaProizvodaKosarica.RemoveAt(indeks);
                    UcitajGridZaPregledKosarice();
                }
                else
                {
                    lblPorukaIzbrisi.Visible = true;
                    lblPorukaIzbrisi.ForeColor = Color.Red;
                }
            }


        }



        private void button4_Click(object sender, EventArgs e)
        {

            KosaricaFrm kosarica = new KosaricaFrm(listaProizvodaKosarica);
            kosarica.Show();
            this.Hide();

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    servis_project.Proizvod pr1=new servis_project.Proizvod();
                    pr1=ProizvodiDA.vratiSliku(ID);
                    Proizvodi.PrikazSlikeFrm prikaz=new Proizvodi.PrikazSlikeFrm(pr1);
                    prikaz.Show();
                   
                }
                else
                {
                    lblpregledFotografije.Visible = true;
                    lblpregledFotografije.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Proizvodi.PrizvodiUnos unos=new Proizvodi.PrizvodiUnos();
            unos.Show();
        }
    }
}
