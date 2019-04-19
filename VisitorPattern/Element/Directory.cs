using System;
using System.Collections;

namespace VisitorPattern
{
    public class Directory : Entry
    {
        private string _name;
        private ArrayList _dir = new ArrayList();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return this._name;
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (var item in this.Iterator())
            {
                Entry entry = item as Entry;
                size += entry.GetSize();
            }

            return size;
        }

        public Entry Add(Entry entry)
        {
            this._dir.Add(entry);
            return this;
        }

        public ArrayList Iterator()
        {
            return this._dir;
        }

        public override void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
