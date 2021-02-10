using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Program
{
    class ExpertDocumentProgram : DocumentProgram  
    {
        public ExpertDocumentProgram(string name, double size) : base(name, size) { }

        public ExpertDocumentProgram() { }

        public void OpenDocument()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ==== Expert Document Program ======================================== ");
            Console.WriteLine("\n Document Opened in Expert version");
            Console.WriteLine($" {Name}  is document. Size of Document is {Size }  ");
        }

        public override void OpenDocument2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ==== Expert Document Program ======================================== ");
            Console.WriteLine("\n Document Opened in Expert version");
            Console.WriteLine($" {Name}  is document. Size of Document is {Size }  ");

        }
        public override void EditDocument()
        {
            Console.WriteLine("\n Document Edited ");
            Console.WriteLine($" {Name} was edited, size is {Size / 2} after edit  ");
        }


        public override void SaveDocument()
        {
            Console.WriteLine($"\n {Name} was stored  in memory  ");
            Console.WriteLine(" Document Saved in  pdf format ");
            Console.WriteLine("\n ==================================================================== ");
        }

    }
}
