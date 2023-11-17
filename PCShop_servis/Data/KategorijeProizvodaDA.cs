using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop_servis.Data
{
    public class KategorijeProizvodaDA
    {
        public static List<pcshop_prikaz_Racunari_Result1> prikazRacunaraGrid()
        {
            return Connection.dm.pcshop_prikaz_Racunari().ToList();
        }
        public static List<pcshop_prikaz_RAM_Result1> prikazRAMGrid()
        {
            return Connection.dm.pcshop_prikaz_RAM().ToList();
        }
        public static List<pcshop_prikaz_CPUCooleri_Result1> prikazCooleraGrid()
        {
            return Connection.dm.pcshop_prikaz_CPUCooleri().ToList();
        }
        public static List<pcshop_prikaz_GrafickeKartice_Result2> prikazGrafickihGrid()
        {
            return Connection.dm.pcshop_prikaz_GrafickeKartice().ToList();
        }
        public static List<pcshop_prikaz_HDDSSD_Result1> prikazHDDSSDGrid()
        {
            return Connection.dm.pcshop_prikaz_HDDSSD().ToList();
        }
        public static List<pcshop_prikaz_Kablovi_Result1> prikazKablovaGrid()
        {
            return Connection.dm.pcshop_prikaz_Kablovi().ToList();
        }
        public static List<pcshop_prikaz_Kucista_Result1> prikazKucistaGrid()
        {
            return Connection.dm.pcshop_prikaz_Kucista().ToList();
        }
        public static List<pcshop_prikaz_MaticnePloce_Result1> prikazMaticnihGrid()
        {
            return Connection.dm.pcshop_prikaz_MaticnePloce().ToList();
        }
        public static List<pcshop_prikaz_Mikrofoni_Result1> prikazMikrofonaGrid()
        {
            return Connection.dm.pcshop_prikaz_Mikrofoni().ToList();
        }
        public static List<pcshop_prikaz_Misevi_Result1> prikazMisevaGrid()
        {
            return Connection.dm.pcshop_prikaz_Misevi().ToList();
        }
        public static List<pcshop_prikaz_Mobiteli_Result1> prikazMobitelaGrid()
        {
            return Connection.dm.pcshop_prikaz_Mobiteli().ToList();
        }
        public static List<pcshop_prikaz_Monitori_Result1> prikazMonitoraGrid()
        {
            return Connection.dm.pcshop_prikaz_Monitori().ToList();
        }
        public static List<pcshop_prikaz_Napojne_Result1> prikazNapojnihGrid()
        {
            return Connection.dm.pcshop_prikaz_Napojne().ToList();
        }
        public static List<pcshop_prikaz_Procesori_Result1> prikazProcesoraGrid()
        {
            return Connection.dm.pcshop_prikaz_Procesori().ToList();
        }
        public static List<pcshop_prikaz_Slusalice_Result1> prikazSlusalicaGrid()
        {
            return Connection.dm.pcshop_prikaz_Slusalice().ToList();
        }
        public static List<pcshop_prikaz_Tastature_Result1> prikazTastaturaGrid()
        {
            return Connection.dm.pcshop_prikaz_Tastature().ToList();
        }
        public static List<pcshop_prikaz_Televizori_Result1> prikazTelevizoraGrid()
        {
            return Connection.dm.pcshop_prikaz_Televizori().ToList();
        }
        public static List<pcshop_prikaz_Zvucnici_Result1> prikazZvucnikaGrid()
        {
            return Connection.dm.pcshop_prikaz_Zvucnici().ToList();
        }

    }
}
