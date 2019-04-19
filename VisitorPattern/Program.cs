using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Configuration;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial Message
            Console.WriteLine("Making root entires......");

            //Directory
            Directory rootDir = new Directory("root");
            Directory binDir = new Directory("bin");
            Directory tmpDir = new Directory("tmp");
            Directory usrDir = new Directory("usr");
            rootDir.Add(binDir);
            rootDir.Add(tmpDir);
            rootDir.Add(usrDir);
            
            //File
            binDir.Add(new File("vi", 10000));
            binDir.Add(new File("latex", 20000));

            rootDir.Accept(new ListVisitor());

            Console.WriteLine("");
            Console.WriteLine("Making user entries.....");

            Directory yuki = new Directory("yuki");
            Directory hanako = new Directory("hanako");
            Directory tomura = new Directory("tomura");
            usrDir.Add(yuki);
            usrDir.Add(hanako);
            usrDir.Add(tomura);

            yuki.Add(new File("diary.html", 100));
            yuki.Add(new File("Composite.java", 200));

            hanako.Add(new File("index.html", 300));
            hanako.Add(new File("memo.txt", 300));

            tomura.Add(new File("game.doc", 400));
            tomura.Add(new File("junk.mail", 500));
            rootDir.Accept(new ListVisitor());

            Console.WriteLine("");
            Console.WriteLine("List files that ends with specific file type.....");
            FileFindVisitor fileFindVisitor = new FileFindVisitor(".html");
            rootDir.Accept(fileFindVisitor);
            foreach (var foundFile in fileFindVisitor.GetFoundFiles())
            {
                var file = foundFile as File;
                Console.WriteLine(file);
            }

            Console.ReadLine();
        }
    }
}
