using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionII_estadistica
{
    class Estadistica
    {
        public double Media(string[]serie)
        {
            double suma = 0;
            foreach (string valor in serie)
            {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;
        }
        public double estandar(string[] serie)
        {
            double media_aritmetica = Media(serie),
            suma = 0;
           
            foreach (string valor in serie)
            {
                Math.Pow(double.Parse(valor) - media_aritmetica, 2);
            }
            return suma / serie.Length;
        }
        public double Tipica(string[] serie)
        {
           return Math.Sqrt(estandar(serie));
        }
            
    }
}
