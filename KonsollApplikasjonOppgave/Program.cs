using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KonsollApplikasjonOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Emil's program\nWhat task would you like to perform?");

            while (true)
            {
                string operation;

                Console.WriteLine("\nType 1 to calculate total marks, precentage and division of a student based on three subjects");
                Console.WriteLine("Type 2 to check if a number is prime");
                Console.WriteLine("Type 3 to delete all duplicate elements from an array");
                Console.WriteLine("Type 4 to count all spaces in a string");
                Console.WriteLine("Type 5 to arrange distinct elements in ascending order in Linq Query ");
                Console.WriteLine("Type 6 to read a string through the keyboard and sort it using bubble sort");
                Console.WriteLine("Type 7 to remove a range of items from a list");
                Console.WriteLine("Type 8 to copy all elements of an array to another");
                Console.WriteLine("Type 9 to remove all spaces in a string");
                Console.WriteLine("Type 10 to stop the program");

                operation = Console.ReadLine();

                if (operation == "1")
                {
                    TotalMarks.TotalMarksCalculation();
                }

                else if (operation == "2")
                {
                    CheckIfNumberIsPrime.CheckPrime();
                }

                else if (operation == "3")
                {
                    DeleteAllDuplicatesFromArray.DelAllDuplicatesArray();
                }

                else if (operation == "4")
                {
                    string strtwo;
                    Console.Write("Please Enter a string : ");
                    strtwo = Console.ReadLine();
                    Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", CountSpaces.FuncCountSpaces(strtwo));
                }

                else if (operation == "5")
                {
                    var itemlist = (from c in Item_Mast.Getitem()
                                    select c.ItemDes)
                                    .Distinct()
                                    .OrderBy(x => x);

                    foreach (var item in itemlist)
                        Console.WriteLine(item);
                }

                else if (operation == "6")
                {
                    StringExercise.Sort();
                }

                else if (operation == "7")
                {
                    RemoveItemsFromList.RemoveItems();
                }

                else if (operation == "8")
                {
                    CopyAllElementsFromArray.CopyAll();
                }

                else if (operation == "9")
                {
                    Console.Write("Enter the string you want to modify: ");
                    string myString = Console.ReadLine();

                    RemoveAllSpaceFromString.DisplayResult(RemoveAllSpaceFromString.RemoveWhiteSpace(myString));      
                }

                else if (operation == "10")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                }


            }
        }
    }
}
