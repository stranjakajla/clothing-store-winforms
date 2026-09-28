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

namespace WindowsFormsApp22
{
    public partial class DetaljiFrm : Form
    {
        public int narudzbaid { get; set; }
        public int id { get; set; }
        public DetaljiFrm(int ID)
        {
            InitializeComponent();
            narudzbaid = ID;
        }

        private void DetaljiFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns=false;
            dataGridView1.DataSource = DetaljiDA.gridDetalji_Results(narudzbaid);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            PretragaFrm pretraga=new PretragaFrm();
            pretraga.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            NarudzbeFrm na = new NarudzbeFrm(id);
            na.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            NarudzbeFrm na = new NarudzbeFrm(id);
            na.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije = new KategorijeFrm();
            kategorije.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 pocetna=new Form2();
            pocetna.Show();
            this.Hide();
        }
    }
}
