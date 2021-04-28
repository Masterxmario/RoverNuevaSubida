using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MetodosRobot
    {
        public static bool ComprobarPosicion(int[] CoordenasXY, string[] CoordenasXYZ)
        {
            if (CoordenasXY[0] >= int.Parse(CoordenasXYZ[0]))
            {
                if (CoordenasXY[1] >= int.Parse(CoordenasXYZ[1]))
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }
        public static bool ComprobarRastro(string[] CoordenasXYZ, List<string[,]> Olor, string Instrucciones)
        {
            var x = 0;
            foreach (var item in Olor)
            {
                if (CoordenasXYZ[0] == item[x, 0] && CoordenasXYZ[1] == item[x, 1] && CoordenasXYZ[2] == item[x, 2] && Instrucciones == "F")
                {
                    return true;
                }
                x++;
            }
            return false;
        }
        public static void AñadirRastro(string[] CoordenasXYZ, List<string[,]> Olor)
        {
            //string[] aux = coordenasXYZ;
            Retroceder(CoordenasXYZ);
            string[,] array = new string[1, 3];
            array[0, 0] = CoordenasXYZ[0];
            array[0, 1] = CoordenasXYZ[1];
            array[0, 2] = CoordenasXYZ[2];

            Olor.Add(array);
        }
        public static void Retroceder(string[] CoordenasXYZ)
        {
            if (CoordenasXYZ[2] == "N")
            {
                CoordenasXYZ[1] = Convert.ToString(int.Parse(CoordenasXYZ[1]) - 1);

            }
            else if (CoordenasXYZ[2] == "S")
            {
                CoordenasXYZ[1] = Convert.ToString(int.Parse(CoordenasXYZ[1]) + 1);
            }
            else if (CoordenasXYZ[2] == "E")
            {
                CoordenasXYZ[0] = Convert.ToString(int.Parse(CoordenasXYZ[0]) - 1);
            }
            else
            {
                CoordenasXYZ[0] = Convert.ToString(int.Parse(CoordenasXYZ[0]) + 1);
            }
        }
        public static void Avanzar(string[] CoordenasXYZ)
        {
            if (CoordenasXYZ[2] == "N")
            {
                CoordenasXYZ[1] = Convert.ToString(int.Parse(CoordenasXYZ[1]) + 1);

            }
            else if (CoordenasXYZ[2] == "S")
            {
                CoordenasXYZ[1] = Convert.ToString(int.Parse(CoordenasXYZ[1]) - 1);
            }
            else if (CoordenasXYZ[2] == "E")
            {
                CoordenasXYZ[0] = Convert.ToString(int.Parse(CoordenasXYZ[0]) + 1);
            }
            else
            {
                CoordenasXYZ[0] = Convert.ToString(int.Parse(CoordenasXYZ[0]) - 1);
            }
        }
        public static void Girar(string Avanzar, string[] CoordenasXYZ)
        {
            if (Avanzar == "L")
            {
                if (CoordenasXYZ[2] == "N")
                {
                    CoordenasXYZ[2] = "W";
                }
                else if (CoordenasXYZ[2] == "S")
                {
                    CoordenasXYZ[2] = "E";
                }
                else if (CoordenasXYZ[2] == "E")
                {
                    CoordenasXYZ[2] = "N";
                }
                else
                {
                    CoordenasXYZ[2] = "S";
                }
            }
            else
            {
                if (CoordenasXYZ[2] == "N")
                {
                    CoordenasXYZ[2] = "E";
                }
                else if (CoordenasXYZ[2] == "S")
                {
                    CoordenasXYZ[2] = "W";
                }
                else if (CoordenasXYZ[2] == "E")
                {
                    CoordenasXYZ[2] = "S";
                }
                else
                {
                    CoordenasXYZ[2] = "N";
                }
            }
        }
    }
}
