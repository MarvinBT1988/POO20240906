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
        public string Estado;
        public void Encender() {
            Estado= "Encendido";
        }
        public void Acelarar() {
            Velocidades += 5;
        }
        public void Frenar() {
            Velocidades = 0;
        }
        public void Apagar() {
            Estado = "Apagado";
        }
        public bool EncenderLuces(bool enceder) {
            return true;
        }
    }
}
