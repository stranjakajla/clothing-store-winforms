using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
    public class NarudzbeDA
    {
        public static List<GridNarudzbe_Result> gridNarudzbe()
        {
            return Connection.dm.GridNarudzbe().ToList();
        }

        public static int? getPosljednjuNarudzbu() {
            return Connection.dm.getNaruzdbaID().FirstOrDefault();
        }

        public static void InsertNarudzbe(Narudzbe narudzba) {
            Connection.dm.insertNarudzbe(narudzba.DatumNarudzbe, narudzba.DatumIsporuke,narudzba.BrojNarudzbe, narudzba.Kupac, narudzba.StatusNarudzbe);
        }
    }
}
