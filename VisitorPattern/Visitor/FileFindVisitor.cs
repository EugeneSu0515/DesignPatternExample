using System.Collections;

namespace VisitorPattern
{
    public class FileFindVisitor : IVisitor
    {
        private string _fileType;
        ArrayList _fountArrayList = new ArrayList();
        public FileFindVisitor(string fileType)
        {
            _fileType = fileType;
        }

        public ArrayList GetFoundFiles()
        {
            return this._fountArrayList;
        }

        public void Visit(File file)
        {
            if (file.GetName().EndsWith(this._fileType))
            {
                this._fountArrayList.Add(file);
            }
        }

        public void Visit(Directory directory)
        {
            foreach (var file in directory.Iterator())
            {
                Entry entry = file as Entry;
                entry.Accept(this);
            }
        }
    }
}
