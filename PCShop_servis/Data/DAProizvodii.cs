using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop_servis.Data
{
    public class DAProizvodii
    {
        public static void insertProizvoda(proizvodi proizvod)
        {
            Connection.dm.pcshop_proizvodi_Insert(proizvod.naziv, proizvod.opis, proizvod.cijena, proizvod.kolicina, proizvod.sifra, proizvod.kategorijaID, proizvod.proizvodjacID);

        } 
        public static proizvodi proizvodiByID(int proizvodiID)
        {
            return Connection.dm.pcshop_ProizvodiByID2(proizvodiID).FirstOrDefault();
        }
        public static void updateProizvoda(proizvodi proizvod)
        {
            Connection.dm.pcshop_updateProizvoda(proizvod.proizvodiID, proizvod.naziv, proizvod.opis, proizvod.cijena, proizvod.kolicina, proizvod.sifra, proizvod.kategorijaID, proizvod.proizvodjacID);

        }
        public static void deleteProizvoda(int id)
        {
            Connection.dm.pcshop_brisanjeProizvoda(id);
        }
    }
}
