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
            try
            {
                return message.Replace(" ", "");
            } 
            catch (Exception e) { return e.Message; }
            
        }
    }
}
