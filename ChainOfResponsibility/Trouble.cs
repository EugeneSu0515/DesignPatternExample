using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Trouble
    {
        private int _number;

        public Trouble(int number)
        {
            _number = number;
        }

        public int GetNumber()
        {
            return this._number;
        }

        public override string ToString()
        {
            return $"[Trouble {this._number}]";
        }
    }
}
