using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
   public class KategorijeDA
    {
        public static List<Kategorije> getKategorijeCmbx()
        {
            List<Kategorije> listaKategorije=new List<Kategorije>();
            listaKategorije = Connection.dm.zara_Kategorije_SelectAll().ToList();
            Kategorije kategorije=new Kategorije();
            kategorije.KategorijeID = 0;
            kategorije.Naziv = "Odaberite kategoriju";
            listaKategorije.Insert(0, kategorije);
            return listaKategorije;
        }
    }
}
