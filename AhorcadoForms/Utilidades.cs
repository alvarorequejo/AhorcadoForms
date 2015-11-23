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
        public static void clicking1(ref char[] iL, char letter, ref int i, ref System.Windows.Forms.Label l, Word w)
        {
            iL[i] = letter;
            w.WriteChar();
            l.Text = new string(Reference.h.GetHiddenWordArray());
            i++;
        }
    }
}
