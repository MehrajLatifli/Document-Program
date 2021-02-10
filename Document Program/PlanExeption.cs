using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Program
{
    class PlanExeption : ApplicationException
    {
        private string _message;
        public DateTime TimeExeption { get; set; }

        public PlanExeption()
        {
            _message = " We have not this plan ";
            TimeExeption = DateTime.Now;

            Console.WriteLine($"\n {TimeExeption} ");

        }
        public PlanExeption(string message)
        {
            _message = message;


        }

        public string Message
        {

            get { return _message; }


        }


    }
}
