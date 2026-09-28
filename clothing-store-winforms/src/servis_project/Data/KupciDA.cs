using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servis_project.Data
{
  public  class KupciDA
    {
       

        public static prijava_Kupci_Result prijava(string KorisnickoIme, string Lozinka)
        {
            return Connection.dm.prijava_Kupci(KorisnickoIme, Lozinka).FirstOrDefault();

        }

        public static Kupci GetKupciByID(int KupaciID)
        {
            return Connection.dm.getKupcibyID(KupaciID).FirstOrDefault();
        }
        public static void UpdateKupaca (Kupci kupci)
        {
            Connection.dm.UpdateKupci(kupci.KupciID, kupci.KorisnickoIme, kupci.Lozinka, kupci.Ime, kupci.Prezime, kupci.Adresa, kupci.DodatneInformacije, kupci.PostanskiBroj, kupci.Grad, kupci.Regija, kupci.KontaktTelefon, kupci.Aktivnost);
        }
     
        public static List<Kupci> KupciGriD()
        {
            return Connection.dm.KupciGrid().ToList();
        }

       /* public static void DeleteKupac (int KupacID)
        {
            Connection.dm.DeleteKupac(KupacID);
        } */

        public static void InsertKupci(Kupci kupci)
        {
            Connection.dm.KupciInsert(kupci.KorisnickoIme, kupci.Lozinka, kupci.Ime, kupci.Prezime, kupci.Adresa, kupci.DodatneInformacije, kupci.PostanskiBroj, kupci.Grad, kupci.Regija, kupci.KontaktTelefon, kupci.Aktivnost);
        }
    }
}
