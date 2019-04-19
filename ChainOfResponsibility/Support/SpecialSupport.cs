namespace ChainOfResponsibility
{
    public class SpecialSupport : Support
    {
        private int _number;
        public SpecialSupport(string name, int number) : base(name)
        {
            _number = number;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() == this._number;
        }
    }
}
