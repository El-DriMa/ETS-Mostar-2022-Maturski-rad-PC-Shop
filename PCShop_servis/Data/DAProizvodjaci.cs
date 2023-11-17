using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCShop_servis;

namespace PCShop_servis.Data
{
    public class DAProizvodjaci
    {
        
        public static List<pcshop_Cmbx_Proizvodjaci_Result> proizvodjaciCmbx()
        {
            List<pcshop_Cmbx_Proizvodjaci_Result> listaProizvodjaca = new List<pcshop_Cmbx_Proizvodjaci_Result>();
            listaProizvodjaca = Connection.dm.pcshop_Cmbx_Proizvodjaci().ToList();
            pcshop_Cmbx_Proizvodjaci_Result proizvodjac = new pcshop_Cmbx_Proizvodjaci_Result();
            proizvodjac.proizvodjaciID = 0;
            proizvodjac.naziv = "Odaberite proizvođača";
            listaProizvodjaca.Insert(0, proizvodjac);
            return listaProizvodjaca;
        }



    }
}
