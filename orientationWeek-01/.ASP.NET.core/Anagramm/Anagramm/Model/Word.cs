﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Model
{
    public class Word
    {
        public string InputWord { get; set; }

        public bool Compare(Word word)
        {
            return InputWord.Equals(Converter(word));
        }

        public string Converter(Word word)
        {           
            return word.InputWord.OrderBy(x => x).ToString();
        }
    }
}
