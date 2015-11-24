using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoForms
{
    class Utilidades
    {
        public static bool CheckChar(char l, char[] iL)
        {
            return iL.Contains(l);
        }
        public static bool CheckChar(char l, char[] iL, char[] wordCharArray)
        {
            return wordCharArray.Contains(l) && !iL.Contains(l);
        }
        public static void WriteChar(int wordLength, char[] wordCharArray, char[] hiddenWordArray, char letter) //escribir la letra
        {
            for (int i = 0; i < wordLength; i++)
            {
                if (wordCharArray[i] == letter)
                {
                    hiddenWordArray[i] = letter;
                }
            }
        }
    }
}
