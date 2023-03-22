using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    public class RemoveAllSpaceFromString
    {

        public static string RemoveWhiteSpace(string message)
        {
            return message.Replace(" ", "");
        }

        public static void DisplayResult(string message)
        {
            Console.WriteLine($"Your modified string is: {message}");
        }
    }
}
