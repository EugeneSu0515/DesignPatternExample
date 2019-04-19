using System;

namespace VisitorPattern
{
    public class ListVisitor : IVisitor
    {
        private string _currentDir = "";

        public void Visit(File file)
        {
            Console.WriteLine($"{_currentDir}/{file}");
        }

        public void Visit(Directory directory)
        {
            Console.WriteLine($"{_currentDir}/{directory}");
            string saveDir = _currentDir;
            _currentDir = $"{_currentDir}/{directory.GetName()}";
            foreach (var item in directory.Iterator())
            {
                Entry entry = item as Entry;
                entry.Accept(this);
            }

            _currentDir = saveDir;
        }
    }
}
