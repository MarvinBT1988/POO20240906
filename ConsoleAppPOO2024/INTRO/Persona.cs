using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.INTRO
{
    public class Persona
    {
        // Atributos
        public string DUI;
        public string Name;
        public string LastName;
        public string Profesion;
        public string Phone;
        public string Mail;

        // Metodos
        public void Hablar() { }
        public void Comer() { }
        public void Reir() { }
        public void Llorar() { }
        public void Saludar() { }

        public void GetInformacion() {
            Console.WriteLine("=====================");
            Console.WriteLine("Bienvenidos");
            Console.WriteLine("=====================");
            Console.WriteLine("DUI: "+ DUI);
            Console.WriteLine("Nombres: " + Name);
            Console.WriteLine("Apellidos: " + LastName);                      
            Console.WriteLine("Profesión: " + Profesion);
            Console.WriteLine("Teléfono: " + Phone);
            Console.WriteLine("Correo: " + Mail);
        }
    }
}
