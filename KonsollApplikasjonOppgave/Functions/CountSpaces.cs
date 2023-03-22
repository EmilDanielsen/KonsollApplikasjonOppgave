using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    public class CountSpaces
    {
        public static int FuncCountSpaces(string str)
        {
            int spcctr = 0;
            string strone;
            for (int i = 0; i < str.Length; i++)
            {
                strone = str.Substring(i, 1);
                if (strone == " ")
                    spcctr++;
            }
            return spcctr;
        }
    }
}
