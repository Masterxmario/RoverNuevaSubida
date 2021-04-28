using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MetodosOutput
    {
        public static void OUTPUT(List<string[,]> OUTPUT, string[] CoordenasXYZ, bool LOST)
        {
            string[,] array = new string[1, 4];
            array[0, 0] = CoordenasXYZ[0];
            array[0, 1] = CoordenasXYZ[1];
            array[0, 2] = CoordenasXYZ[2];

            if (LOST)
            {
                array[0, 3] = "LOST";
                OUTPUT.Add(array);
            }
            else
            {
                OUTPUT.Add(array);
            }
        }

    }
}
