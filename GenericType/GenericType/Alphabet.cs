using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Alphabet
    {
        public string Name { get; }

        private char[] _letters;

        public Alphabet(string name)
        {
            Name = name;
            _letters = new char[30];
        }

        public char this[int index] 
        { 
            get
            {
                return _letters[index];
            }
            set
            {
                _letters[index] = value;
            }
        }

        public char GetLetter(int index)
        {
            return _letters[index];
        }

        public void SetLetter(int index, char value)
        {
            _letters[index] = value;
        }
    }
}
