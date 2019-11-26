using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2.Entity
{
    class TextAnalyzer
    {
        private string text;

        public TextAnalyzer()
        {
        }

        public TextAnalyzer(string text)
        {
            this.text = text;
        }

        public char[] GeneratedText( char[] strText, Random rnd)
        {
            char randomChar;
            for(int i = 0; i < 50; i++)
            {
                randomChar = (Char)rnd.Next('a', 'z');
                strText[i] = randomChar;
            }
            return strText;
        }

        public string Text { get => text; set => text = value; }
    }
}
