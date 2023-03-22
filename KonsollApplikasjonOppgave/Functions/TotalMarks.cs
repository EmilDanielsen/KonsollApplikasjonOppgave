using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    public class TotalMarks
    {
        public static void TotalMarksCalculation()
           
        {
            try
            {
                int marks1, marks2, marks3;

                int total;

                float percentage;

                string division;



                Console.WriteLine("Enter the marks of the student in subject 1: ");

                marks1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the marks of the student in subject 2: ");

                marks2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the marks of the student in subject 3: ");

                marks3 = int.Parse(Console.ReadLine());



                total = marks1 + marks2 + marks3;



                percentage = (total / 300) * 100;



                if (percentage >= 60)
                {

                    division = "First Division";

                }
                else if (percentage >= 45)
                {

                    division = "Second Division";

                }
                else
                {

                    division = "Third Division";

                }

                Console.WriteLine("The total is {0}% and you're in {1}", percentage, division);
            }
            catch(Exception e) 
            {
            Console.WriteLine(e.Message);
            }





        }
    }
}
