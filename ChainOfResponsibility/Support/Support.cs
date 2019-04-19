using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Support
    {
        private string _name;
        private Support _next;

        public Support(string name)
        {
            _name = name;
        }

        public Support SetNext(Support next)
        {
            this._next = next;
            return this._next;
        }

        public void DoSupport(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                this.Done(trouble);
            }
            else if (this._next != null)
            {
                this._next.DoSupport(trouble);
            }
            else
            {
                this.Fail(trouble);
            }

        }

        protected abstract bool Resolve(Trouble trouble);

        protected void Done(Trouble trouble)
        {
            Console.WriteLine($"{trouble} is resolved by {this}.");
        }

        protected void Fail(Trouble trouble)
        {
            Console.WriteLine($"{trouble} cannot be resolved.");
        }

        public override string ToString()
        {
            return $"{this._name}";
        }
    }
}
