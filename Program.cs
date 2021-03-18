using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("Beetlejuice");
            nombresDePelicula.Add("Silence of the Lambs"); 
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");
            
            // No permite elementos duplicados
            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("Beetlejuice");
            nombresDePeliculaSet.Add("Silence of the Lambs"); 
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant. de peliculas en nombresDePelicula: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de peliculas en nombresDePeliculaSet: " + nombresDePeliculaSet.Count);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995)); 
            peliculasSet.Add(new Pelicula("Bad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 2019));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));
            // Son objetos distintos, incluso si tiene los mismos datos
            peliculasSet.Add(new Pelicula("Aladdin", 1992));
            Console.WriteLine("Cant.de peliculas en peliculasSet: " + peliculasSet.Count); //5

            // Map -> Java
            // Dictionary -> C#, Python
            // Object -> Javascript

            Dictionary<string, string> nombresDePeliculaFavoritas = new Dictionary<string, string>();
            nombresDePeliculaFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculaFavoritas.Add("Esteban", "Fast and Furious: Tokyo Drift");
            nombresDePeliculaFavoritas.Add("Octavio", "Barbie in the 12 Dancing Princesses");

            string nombrePeliculaFavoritaPablo = nombresDePeliculaFavoritas.GetValueOrDefault("Pablo");
            Console.WriteLine("NombrePeliculaFavoritaPablo: " + nombrePeliculaFavoritaPablo);

            string nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro");
            Console.WriteLine("NombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //null

            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("NombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //(Ninguna)

            nombresDePeliculaFavoritas.Add("Ramiro", "Avatar");

            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("NombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //Avatar

            // Uso real de obtener valores de un Dictionary
            if (nombresDePeliculaFavoritas.TryGetValue("Maria", out string nombrePeliculaFavoritaMaria))
            {
            Console.WriteLine("nombrePeliculaFavoritaMaria: " + nombrePeliculaFavoritaMaria);
            }
            else
            {
                Console.WriteLine("María no tiene película favorita.");
            }

            // Lista
            Console.WriteLine("--------");
            Console.WriteLine("Lista");
            for (int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            // HashSet
            Console.WriteLine("--------");
            Console.WriteLine("Set");
            // Foreach: elemento in conjunto
            foreach (string nombrePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombrePelicula);
            }
            
            // Dictionary
            Console.WriteLine("--------");
            Console.WriteLine("Dictionary");
            foreach (var key in nombresDePeliculaFavoritas.Keys)
            {
                Console.WriteLine(key);        
            }
            foreach (var key in nombresDePeliculaFavoritas.Keys)
            {
                Console.WriteLine(key + ":" + nombresDePeliculaFavoritas.GetValueOrDefault(key));        
            }

        }
    }
}
