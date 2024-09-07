using ConsoleAppPOO2024.INTRO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pedro = new Persona();
            pedro.DUI = "02461478-8";
            pedro.Name = "Pedro Antonio";
            pedro.LastName = "Hernandez";
            pedro.Profesion = "Médico";
            pedro.Phone = "7845-8956";
            pedro.Mail = "pedro@gmail.com";
            pedro.GetInformacion();

            Persona cristina = new Persona();
            cristina.DUI = "02461448-9";
            cristina.Name = "Cristina Gabriela";
            cristina.LastName = "Ochoa Pérez";
            cristina.Profesion = "Abogada";
            cristina.Phone = "6685-8956";
            cristina.Mail = "cristina@gmail.com";
            cristina.GetInformacion();

            Calculadora fx85 = new Calculadora();
            Console.WriteLine("Dígite un número: ");
            fx85.Numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dígite otro número: ");
            fx85.Numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La resta es: "+ fx85.Restar());
           
            Console.ReadKey();
        }
    }
}
