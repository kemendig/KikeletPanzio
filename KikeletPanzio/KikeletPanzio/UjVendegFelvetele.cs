using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    internal class UjVendegFelvetele
    {
        string azon;
        string emailCim;
        DateTime regisztracioDatuma;
        string nev;
        string anyajNeve;
        string szuletesiHely;
        DateTime szuletsiIdo;
        string orszag;
        private int iranyitoszam;
        string varos;
        string utcaHazszam;
        bool vipE;

        public string Azon { get => azon; set => azon = value; }
        public string EmailCim { get => emailCim; set => emailCim = value; }
        public DateTime RegisztracioDatuma { get => regisztracioDatuma; set => regisztracioDatuma = value; }
        public string Nev { get => nev; set => nev = value; }
        public string AnyajNeve { get => anyajNeve; set => anyajNeve = value; }
        public string SzuletesiHely { get => szuletesiHely; set => szuletesiHely = value; }
        public DateTime SzuletsiIdo { get => szuletsiIdo; set => szuletsiIdo = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int Iranyitoszam { get => iranyitoszam; set => iranyitoszam = value; }
        public string Varos { get => varos; set => varos = value; }
        public string UtcaHazszam { get => utcaHazszam; set => utcaHazszam = value; }
        public bool VipE { get => vipE; set => vipE = value; }

        public UjVendegFelvetele(string emailCim, string nev, string anyajNeve, string szuletesiHely, DateTime szuletsiIdo, string orszag, int iranyitoszam, string varos, string utcaHazszam, bool vipE)
        {
            this.EmailCim = emailCim;
            this.Nev = nev;
            this.AnyajNeve = anyajNeve;
            this.SzuletesiHely = szuletesiHely;
            this.SzuletsiIdo = szuletsiIdo;
            this.Orszag = orszag;
            this.Iranyitoszam = iranyitoszam;
            this.Varos = varos;
            this.UtcaHazszam = utcaHazszam;
            this.VipE = vipE;
            this.Azon = nev.Remove(' ') + regisztracioDatuma.rem ;
        }
    }
}
