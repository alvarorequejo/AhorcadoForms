using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoForms
{
    class HiddenWord
    {
        private int wordLength;
        private char[] hiddenWordArray;
        private char[] wordCharArray;
        private string word;
        public HiddenWord()
        {

        }
        public HiddenWord(int wordLength, string word)
        {
            this.word = word;
            this.wordLength = wordLength;
            hiddenWordArray = new char[wordLength];
            wordCharArray = new char[wordLength];
        }
        public void HiddeWord()
        {
            for (int i = 0; i < wordLength; i++)
            {
                hiddenWordArray[i] = '*';
            }
        }
        public char[] GetHiddenWordArray()
        {
            return hiddenWordArray;
        }
        public string GetWord()
        {
            return word;
        }
        public int GetWordLength()
        {
            return wordLength;
        }
        public char[] GetWordCharArray()
        {
            wordCharArray = word.ToCharArray();
            return wordCharArray;
        }
    }
}
