using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Program
{
    class ProDocumentProgram : DocumentProgram
    {
        public ProDocumentProgram(string name, double size) : base(name, size) { }


        public ProDocumentProgram() {}

        public  void OpenDocument()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ==== Pro Document Program ========================================== ");
            Console.WriteLine("\n Document Opened in Pro version");
            Console.WriteLine($" {Name}  is document. Size of Document is {Size }  ");

        }

        public override void OpenDocument2()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" ==== Pro Document Program ========================================== ");
            Console.WriteLine("\n Document Opened in Pro version");
            Console.WriteLine($" {Name}  is document. Size of Document is {Size }  ");

        }
        public  sealed override void EditDocument()
        {
            Console.WriteLine("\n Can Edit in Pro versions ");
            Console.WriteLine($" {Name} was edited, size is {Size / 2} after edit  ");
        }


        public override void SaveDocument()
        {
            Console.WriteLine($"\n {Name} was stored  in memory  ");
            Console.WriteLine(" Document Saved in doc format, for pdf format buy Expert packet \n");
            Console.WriteLine(" ==================================================================== ");
        }
    }
}
