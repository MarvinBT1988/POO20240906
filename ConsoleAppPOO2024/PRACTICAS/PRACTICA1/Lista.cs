using ConsoleAppPOO2024.INTRO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.PRACTICAS.PRACTICA1
{
    internal class Lista
    {
        public static void Main()
        {
            List<string> paises = new List<string>();
            paises.Add("El salvador");
            paises.Add("Guatemala");
            paises.Add("Honduras");
            paises.Add("Nicaragua");
            paises.Add("Panama");
            paises.Add("Costa rica");
            paises.RemoveAt(3);
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);               
            }

            Empleado[] personas = new Empleado[3];
            personas[0]=new Empleado();
            personas[0].name = "Marvin";
            personas[0].lastName = "Barrera Trigueros";
            personas[0].Isr = 12.5d;
            personas[0].SetAFP(10);
            Console.ReadKey();
        }
    }
}
