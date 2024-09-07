using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.INTRO
{
    public class Empleado
    {
        public int id;
        public string name;
        public string lastName;
        public string email;
        public string phone;
        public string city;
        public DateTime birthday;
        public string levelacademy;
        public string title;
        public double salary;
        private double afp;
        public double Isr { get; set; }
        private double Cashsalary { get => Cashsalary; set => Cashsalary = value; }
        public double GetAFP() {
            return afp;
        }
        public void SetAFP(double pAFP) {
            afp = pAFP;
        }
    }
}
