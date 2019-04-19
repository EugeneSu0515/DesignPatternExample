namespace VisitorPattern
{
    public class File : Entry
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return this._name;
        }

        public override int GetSize()
        {
            return this._size;
        }

        public override void Accept(IVisitor v)
        {
            v.Visit(this);
        }
    }
}
