using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.PRACTICAS.PRACTICA1
{
    public class Vectores
    {
       
        public static void Main()
        {
            int[] edades = { 13, 19, 21, 22, 25, 10 };           
            int sumaedades = 0;
            foreach (int i in edades)
            {
                sumaedades += i;
            }
            Console.WriteLine("Op1:" + sumaedades);
            int[] edades_ = new int[6];
            edades_[0] = 15;
            edades_[1] = 19;
            edades_[2] = 21;
            edades_[3] = 22;
            edades_[4] = 25;
            edades_[5] = 10;
             int sumaedades_ = edades_[0] + edades_[1] + edades_[2] + edades_[3]+ edades_[4]+ edades_[5];
            Console.WriteLine("Op2:" + sumaedades_);
            Console.ReadKey();
        }
    }
}
