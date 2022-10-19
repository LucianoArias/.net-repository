using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            int totalDe10 = this.BilletesDe10 * 10;
            int totalDe20 = this.BilletesDe20 * 20;
            int totalDe50 = this.BilletesDe50 * 50;
            int totalDe100 = this.BilletesDe100 * 100;
            int totalDe200 = this.BilletesDe200 * 200;
            int totalDe500 = this.BilletesDe500 * 500;
            int totalDe1000 = this.BilletesDe1000 * 1000;
            return totalDe10 + totalDe20 + totalDe50 + totalDe100 + totalDe200 + totalDe500 + totalDe1000;
        }

        public Billetera Combinar(Billetera segundaBilletera)
        {
            Billetera nuevaBilletera = new()
            {
                BilletesDe10 = this.BilletesDe10 + segundaBilletera.BilletesDe10,
                BilletesDe20 = this.BilletesDe20 + segundaBilletera.BilletesDe20,
                BilletesDe50 = this.BilletesDe50 + segundaBilletera.BilletesDe50,
                BilletesDe100 = this.BilletesDe100 + segundaBilletera.BilletesDe100,
                BilletesDe200 = this.BilletesDe200 + segundaBilletera.BilletesDe200,
                BilletesDe500 = this.BilletesDe500 + segundaBilletera.BilletesDe500,
                BilletesDe1000 = this.BilletesDe1000 + segundaBilletera.BilletesDe1000,
            };
            return nuevaBilletera;
        }
    }
}
