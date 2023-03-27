using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    public class RemoveItemsFromList
    {
        public static IEnumerable<string> RemoveItems()
        {
            IEnumerable<string> _result = new List<string>();
            try
            {
                List<string> list = new List<string>();
                list.Add("a");
                list.Add("b");
                list.Add("c");
                list.Add("d");
                list.Add("e");
                list.Add("f");


                var result = from y in list
                             select y;
                Console.Write("Here is the list of items : \n");
                foreach (var tchar in result)
                {
                    Console.WriteLine("Char: {0} ", tchar);
                }

                list.RemoveRange(1, 4);

                _result = from n in list
                              select n;
                Console.Write("\nHere is the list after removing the four items starting from the list : \n");

            } 
            catch(Exception e) {Console.WriteLine(e.Message);}
         
            return _result;
        }
    }
}
