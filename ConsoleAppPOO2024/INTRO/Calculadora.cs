using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.INTRO
{
    public class Calculadora
    {
        public double Numero1;
        public double Numero2;
        public double Resultado;

        public double Sumar() {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }
        public double Restar()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }
        public double Dividir()
        {
            Resultado = Numero1 / Numero2;
            return Resultado;
        }
    }
}
