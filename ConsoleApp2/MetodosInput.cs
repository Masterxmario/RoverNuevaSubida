using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MetodosInput
    {
        public static string[] SolicitarInstrucciones()
        {
            while (true)
            {
                string CadenaInstructions;
                CadenaInstructions = Console.ReadLine();

                if (CadenaInstructions.Length<1000)
                {
                    List<string> miLista = new List<string>();
                    for (int i = 0; i < CadenaInstructions.Length; ++i)
                    {
                        miLista.Add(CadenaInstructions[i].ToString());
                    }
                    string[] miArray = miLista.ToArray();
                    return miArray;
                }

                Console.WriteLine("Ha introducido más de 1000 caracteres");
            }
           

        }

        public static string[] SolicitasCoordenadasXYZ()
        {
            while (true)
            {
                string[] Coordenas = new string[3];
                string CadenaPosiciones;
                CadenaPosiciones = Console.ReadLine();
                if (CadenaPosiciones == "")
                {
                    Coordenas[0] = "";
                    return Coordenas;
                }
                int x = 0;

                string[] Palabras = CadenaPosiciones.Split(' ');
                foreach (var item in Palabras)
                {
                    Coordenas[x] = item;
                    x++;
                }
               
                if (int.Parse(Coordenas[0])<50)
                {
                    if (int.Parse(Coordenas[0])<50)
                    {
                        return Coordenas;
                    }
                }
                Console.WriteLine("Ha introducido más de 50 en una coordenada");
            }   
        }

        public static int[] SolicitarCoordenadasXY()
        {
            int[] Coordenas = new int[2];
            while (true)
            {
                string Cadena;
                Cadena = Console.ReadLine();
                string[] Palabras = Cadena.Split(' ');
                
                Coordenas[0] = int.Parse(Palabras[0]);
                Coordenas[1] = int.Parse(Palabras[1]);
                if (Coordenas[0] < 50)
                    if (Coordenas[1] < 50)
                    {
                        return Coordenas;
                    }
                Console.WriteLine("Ha introducido más de 50 en la posición del mapa");
            }
        }
    }
}
