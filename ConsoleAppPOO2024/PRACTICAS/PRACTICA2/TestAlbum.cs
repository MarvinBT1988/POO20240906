using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPOO2024.PRACTICAS.PRACTICA2
{
    public class TestAlbum
    {
        public static void Main() {
            Album disco1 = new Album();
            disco1.nombre = "Jesús Verbo, no sustantivos";
            disco1.artista = "Ricardo Arjona";
            disco1.año = 1995;
            disco1.genero = "baladas";
            disco1.canciones.Add("¿Porqué estan crud el amor?");
            disco1.canciones.Add("creo que se llama amor?");
            disco1.canciones.Add("Jesús verbo, no sustantivos");
            disco1.canciones.Add("Hermanos del tiempo");
            
            Album disco2=new Album();
            disco2.nombre = "Reputacion";
            disco2.artista = "Taylor Swift";
            disco2.año = 2019;
            disco2.canciones.Add("End Game");
            disco2.canciones.Add("Ready for Iy?");

            List<Album> albumes=new List<Album>();
            albumes.Add(disco1);
            albumes.Add(disco2 );

            Album[] albums = {disco1,disco2 };
        }
    }
}
