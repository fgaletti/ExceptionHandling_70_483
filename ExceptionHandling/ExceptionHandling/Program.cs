using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        // 94
        // null
        static void Main(string[] args)
        {
            try
            {
                string o = OpenAndParse(null);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Arg. Null :" + e.Message);
            }
            
            
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("Filename", "Filename is requiered");
            }
            return File.ReadAllText(fileName);
        }
    }
}
