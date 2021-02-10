using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Program
{
    class DocumentProgram
    {
        public string Name { get; set; }
        public double Size { get; set; }

        public DocumentProgram(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public DocumentProgram()
        {
        }

        public void OpenDocument()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Document Opened \n");
        }

        public virtual void OpenDocument2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ==== Basic Document Program ======================================== ");
            Console.WriteLine(" Document Opened in Basic version ");
        }

        public virtual void EditDocument()
        {
           
            Console.WriteLine("\n Can Edit in Pro and Expert versions ");
            Console.WriteLine($" You only view to {Name} ");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("\n Can Save in Pro and Expert versions ");
            Console.WriteLine(" ==================================================================== ");
        }
    }
}
