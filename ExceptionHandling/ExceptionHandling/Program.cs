using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        // 88 parsing a invalid
        // null
        static void Main(string[] args)
        {
           // string s = null;
            string s = "555555555555555555555559999999999999999"; //overflow
            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null Exception" + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Value" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message + "Stack : " + e.StackTrace) ;
                //throw;
            }
            finally
            {
                Console.WriteLine("Always execute");
            }

            Console.WriteLine("ok");
        }
    }
}
