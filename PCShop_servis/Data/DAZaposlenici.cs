using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop_servis.Data
{
    public class DAZaposlenici
    {
        public static zaposlenici getLogin(string korisnickoIme,string lozinka)
        {
            return Connection.dm.prijavaZaposlenika1(korisnickoIme, lozinka).FirstOrDefault();
        }
        public static List<prikazZaposlenikaGrid_Result> prikazZaposlenika()
        {
            return Connection.dm.prikazZaposlenikaGrid().ToList();
        }
        public static List<prikazGradaCmbx_Result> gradCmbx()
        {
            List<prikazGradaCmbx_Result> listaGradova = new List<prikazGradaCmbx_Result>();
            listaGradova = Connection.dm.prikazGradaCmbx().ToList();
            prikazGradaCmbx_Result grad = new prikazGradaCmbx_Result();
            grad.gradID = 0;
            grad.naziv = "Odaberite grad";
            listaGradova.Insert(0,grad);
            return listaGradova;
        }
        public static void insertZaposlenika(zaposlenici zaposlenik)
        {
            Connection.dm.zaposleniciInsert(zaposlenik.ime, zaposlenik.prezime, zaposlenik.datumRodjenja, zaposlenik.korisnickoIme, zaposlenik.brojTelefona, zaposlenik.mail, zaposlenik.lozinka, zaposlenik.adresaID);

        }
        public static zaposlenici zaposleniciByID(int id)
        {
            return Connection.dm.ZaposleniciByID2(id).FirstOrDefault();
        }
        public static void updateZaposlenika(zaposlenici zaposlenik)
        {
            Connection.dm.zaposleniciUpdate(zaposlenik.korisniciID, zaposlenik.ime, zaposlenik.prezime, zaposlenik.datumRodjenja, zaposlenik.korisnickoIme, zaposlenik.brojTelefona, zaposlenik.mail, zaposlenik.lozinka, zaposlenik.adresaID);
        }
        public static void deleteZaposlenika(int id)
        {
            Connection.dm.zaposleniciDelete(id);
        }
    }
}
