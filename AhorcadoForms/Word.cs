using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoForms
{
    class Word
    {
        private string word;
        private int wordLength;
        private bool b;
        private char letter;
        private char[] hiddenWordCharArray;
        private char[] wordCharArray;

        public Word() //constructor por defecto
        {
        }
        public Word(HiddenWord w, ref char letter) //constructor con argumentos
        {
            this.letter = letter;
            wordLength = w.GetWordLength();
            word = w.GetWord();
            hiddenWordCharArray = w.GetHiddenWordArray();
            wordCharArray = w.GetWordCharArray();
            b = Utilidades.CheckChar(letter, wordCharArray);
        }
        public void WriteChar() //escribir la letra
        {
            for (int i = 0; i < wordLength; i++)
            {
                if (wordCharArray[i] == letter)
                {
                    hiddenWordCharArray[i] = letter;
                }
            }
        }
        public char[] GetCharArray()
        {
            return wordCharArray;
        }
    }
}
