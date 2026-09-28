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
    public partial class NarudzbeFrm : Form
    {

        int id;

        public NarudzbeFrm(int ID)
        {
            InitializeComponent();
            id= ID;
            
        }

        private void NarudzbeFrm_Load(object sender, EventArgs e)
        {
            lblPorukaNarudzba.Visible = false;  
            dataGridView1.AutoGenerateColumns = false;
            UcitajGrid();
        }

        private void UcitajGrid()
        {
            dataGridView1.DataSource = NarudzbeDA.gridNarudzbe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                DetaljiFrm detalji = new DetaljiFrm(ID);
                detalji.Show();
                this.Hide();
            }
            else
            {

                    lblPorukaNarudzba.Visible = true;
                    lblPorukaNarudzba.ForeColor = Color.Red;
                
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
