using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
   public class DetaljiDA
    {
        public static List<GridDetalji_Result> gridDetalji_Results(int NarudzbeID)
        {
            return Connection.dm.GridDetalji(NarudzbeID).ToList();
        }

        public static void InsertDetalja(Detalji detalj)
        {
            Connection.dm.insertDetalji(detalj.Narudzba, detalj.Proizvod, detalj.Kolicina);

        }
        
    }
}

