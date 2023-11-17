using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop_servis.Data
{
    public class PretrageDA
    {
      
        public static List<pcshop_pretragaRAM_Result> pretragaPoNazivuRAM(string naziv)
        {
            return Connection.dm.pcshop_pretragaRAM(naziv).ToList();
        }
        public static List<pcshop_pretraga_HDDSSD_Result> pretragaPoNazivuHDDSSD(string naziv)
        {
            return Connection.dm.pcshop_pretraga_HDDSSD(naziv).ToList();
        }
        public static List<pcshop_pretraga_CPUCooleri_Result> pretragaPoNazivuCPUCooleri(string naziv)
        {
            return Connection.dm.pcshop_pretraga_CPUCooleri(naziv).ToList();
        }
        public static List<pcshop_pretraga_GrafickeKartice_Result> pretragaPoNazivuGraficke(string naziv)
        {
            return Connection.dm.pcshop_pretraga_GrafickeKartice(naziv).ToList();
        }
        public static List<pcshop_pretraga_Kablovi_Result> pretragaPoNazivuKablovi(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Kablovi(naziv).ToList();
        }
        public static List<pcshop_pretraga_Kucista_Result> pretragaPoNazivuKucista(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Kucista(naziv).ToList();
        }
        public static List<pcshop_pretraga_MaticnePloce_Result> pretragaPoNazivuMaticne(string naziv)
        {
            return Connection.dm.pcshop_pretraga_MaticnePloce(naziv).ToList();
        }
        public static List<pcshop_pretraga_Mikrofoni_Result> pretragaPoNazivuMikrofoni(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Mikrofoni(naziv).ToList();
        }
        public static List<pcshop_pretraga_Misevi_Result>pretragaPoNazivuMisevi(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Misevi(naziv).ToList();
        }
        public static List<pcshop_pretraga_Mobiteli_Result> pretragaPoNazivuMobiteli(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Mobiteli(naziv).ToList();
        }
        public static List<pcshop_pretraga_Monitori_Result> pretragaPoNazivuMonitori(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Monitori(naziv).ToList();
        }
        public static List<pcshop_pretraga_Napojne_Result> pretragaPoNazivuNapojne(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Napojne(naziv).ToList();
        }
        public static List<pcshop_pretraga_Procesori_Result> pretragaPoNazivuProcesori(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Procesori(naziv).ToList();
        }
        public static List<pcshop_pretraga_Racunari1_Result>pretragaPoNazivuRacunari(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Racunari1(naziv).ToList();
        }
        public static List<pcshop_pretraga_Slusalice_Result> pretragaPoNazivuSlusalice(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Slusalice(naziv).ToList();
        }
        public static List<pcshop_pretraga_Tastature_Result> pretragaPoNazivuTastature(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Tastature(naziv).ToList();
        }
        public static List<pcshop_pretraga_Televizori_Result> pretragaPoNazivuTelevizori(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Televizori(naziv).ToList();
        }
        public static List<pcshop_pretraga_Zvucnici_Result> pretragaPoNazivuZvucnici(string naziv)
        {
            return Connection.dm.pcshop_pretraga_Zvucnici(naziv).ToList();
        }
    }
}
