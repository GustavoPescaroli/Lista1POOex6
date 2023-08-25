using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPOOex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar a;
            a = new Dolar();

            Console.WriteLine("valor em dola");
            a.setqnt(double.Parse(Console.ReadLine()));

            a.calcular();
            Console.WriteLine("valor convertido = {0}", a.getReais());
        }
    }
}
