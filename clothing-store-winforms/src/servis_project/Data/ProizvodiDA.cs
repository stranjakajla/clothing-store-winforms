using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
   public class ProizvodiDA
    {
        public static List<zara_Proizvodi_Select_Result> getProizvodiGrid()
        {
            return Connection.dm.zara_Proizvodi_Select().ToList();
        }

        
        public static GridProizvodByProizvodID_Result getGridProizvodiGridbyID(int ID)
        {
            return Connection.dm.GridProizvodByProizvodID(ID).FirstOrDefault();
        }

        public static List<zara_Kategorija_PretragaByKategorija_Result> pretragaProizvodByKategorija (int Kategorija)
        {
            return Connection.dm.zara_Kategorija_PretragaByKategorija(Kategorija).ToList();
        }
        public static List<PretragaByNaziv_Result> pretragaByNaziv (string Naziv)
        {
            return Connection.dm.PretragaByNaziv(Naziv).ToList();
        }

        public static  void InsertProizvoda(Proizvod proizvod)
        {
            Connection.dm.insertProizvoda(proizvod.Naziv, proizvod.Kategorija, proizvod.Slika, proizvod.Velicina, proizvod.Cijena, proizvod.BojaID, proizvod.SlikaThumb);
        }

        public static Proizvod vratiSliku(int id)
        {
            return Connection.dm.UcitajSliku(id).FirstOrDefault();
        }
    }
}
