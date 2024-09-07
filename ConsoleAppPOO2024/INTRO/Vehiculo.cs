using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.INTRO
{
    public class Vehiculo
    {
        public string Color;
        public string Marca;
        public string Suspencion;
        public int Velocidades;

        public void Encender() { }
        public void Acelarar() { }
        public void Frenar() { }
        public void Apagar() { }
        public bool EncenderLuces(bool enceder) {
            return true;
        }
    }
}
