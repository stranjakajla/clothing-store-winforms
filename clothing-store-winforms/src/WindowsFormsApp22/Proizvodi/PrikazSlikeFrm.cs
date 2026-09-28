using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22.Proizvodi
{
    public partial class PrikazSlikeFrm : Form
    {
        servis_project.Proizvod pr =new servis_project.Proizvod();
        public PrikazSlikeFrm(servis_project.Proizvod pr1)
        {
            InitializeComponent();
            pr= pr1;    
        }

        private void PrikazSlikeFrm_Load(object sender, EventArgs e)
        {
            if (pr.SlikaThumb != null)
            {
                var ms = new MemoryStream(pr.SlikaThumb);
                Image thumbImage = Image.FromStream(ms);
                pictureBoxSlikaProizvoda.Image = thumbImage;
            }
        }
          
}
    }

