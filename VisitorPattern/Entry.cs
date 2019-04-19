namespace VisitorPattern
{
    public abstract class Entry : Element
    {
        public abstract string GetName();
        public abstract int GetSize();
        public abstract void Accept(IVisitor v);
        public override string ToString()
        {
            return $"{GetName()} ({GetSize()})";
        }
    }
}
