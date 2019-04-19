namespace VisitorPattern
{
    public interface Element
    {
        void Accept(IVisitor v);
    }
}
