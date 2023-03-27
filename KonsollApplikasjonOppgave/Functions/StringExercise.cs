using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    public class StringExercise
    {
        public static List<String> Sort()
        {
            string[] arr1;
            string temp;
            int num, i, j, lenghth;
            List<String> list = new List<String>();

            try
            {
               

                Console.Write("Input number of strings :");
                num = Convert.ToInt32(Console.ReadLine());
                arr1 = new string[num];
                Console.Write("Input {0} strings below :\n", num);
                for (i = 0; i < num; i++)
                {
                    arr1[i] = Console.ReadLine();
                }
                lenghth = arr1.Length;

                for (i = 0; i < lenghth; i++)
                {
                    for (j = 0; j < lenghth - 1; j++)
                    {
                        if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                        {
                            temp = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = temp;
                        }
                    }
                }
                Console.Write("\n\nAfter sorting the array appears like : \n");
                for (i = 0; i < lenghth; i++)
                {
                    list.Add(arr1[i] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
 
        }
    }
}
