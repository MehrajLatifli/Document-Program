using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Program
{
    class Program
    {
        static void ConnectPlan(string version)
        {
            Console.WriteLine($" \n {version} choosed");
        }
        static void Main(string[] args)
        {


                            DocumentProgram d1 = new DocumentProgram("Test", 300);
                            DocumentProgram d2 = new ProDocumentProgram("Test2", 3100);
                            DocumentProgram d3 = new ExpertDocumentProgram("Test3", 3000);
       

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n 1 <- Basic ");
            Console.WriteLine(" 2 <- Pro ");
            Console.WriteLine(" 3 <- Expert ");
            for (int i = 0; i < 10; i++)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n Choose plan: ");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                       
                            Console.ForegroundColor = ConsoleColor.Green;
                            ConnectPlan(ChooseVersion.Basic);
                            d1.OpenDocument();
                            d1.OpenDocument2();
                            d1.EditDocument();
                            d1.SaveDocument();


                        break;
                    case "2":
                       
                            Console.ForegroundColor = ConsoleColor.Green;
                            ConnectPlan(ChooseVersion.Pro);
                            d2.OpenDocument();
                            d2.OpenDocument2();
                            d2.EditDocument();
                            d2.SaveDocument();
                       
                        break;
                    case "3":
                       
                            Console.ForegroundColor = ConsoleColor.Green;
                            ConnectPlan(ChooseVersion.Expert);
                            d3.OpenDocument();
                            d3.OpenDocument2();
                            d3.EditDocument();
                            d3.SaveDocument();
                       
                        break;
                    default:

                        try
                        {
                            if (choose != "1" || choose != "2" || choose != "3")
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                DateTime time = DateTime.Now;
                                throw new PlanExeption();
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }
                        catch (PlanExeption ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }




            }

            Console.ReadKey();

        }
    }
}
