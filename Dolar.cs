using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPOOex6
{
    internal class Dolar
    {
        private double Reais;
        private double qnt;

        public void setqnt(double d)
        {
            qnt = d;
        }
        public double getReais()
        {
            return Reais; 
        }
        public double getqnt()
        {
            return qnt;
        }
        public void calcular()
        {
            Reais = qnt * 4.97;
        }


    }
}
