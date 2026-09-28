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
    public partial class PretragaFrm : Form
    {
        public static int id { get; set; }
        public PretragaFrm()
        {
            InitializeComponent();
        }

        private void PretragaFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            UcitajGrid();
        }

        private void UcitajGrid()
        {
            dataGridView1.DataSource=ProizvodiDA.getProizvodiGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() =="")
            {
                UcitajGrid();
            }
            else
            {
                dataGridView1.DataSource = ProizvodiDA.pretragaByNaziv(textBox1.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            KategorijeFrm kategorije =new KategorijeFrm();
            kategorije.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            NarudzbeFrm narudzbe = new NarudzbeFrm(id);
            narudzbe.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
