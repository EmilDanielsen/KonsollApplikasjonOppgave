using System;
using System.Collections;
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

                switch (operation)
                {
                    case "1":
                        Console.WriteLine(TotalMarks.TotalMarksCalculation());
                        break;

                    case "2":
                        Console.WriteLine(CheckIfNumberIsPrime.CheckPrime());
                        break;

                    case "3":
                        List<int> deleteDuplicatesList = DeleteAllDuplicatesFromArray.DelAllDuplicatesArray();
                        foreach (var item in deleteDuplicatesList)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "4":
                        string strtwo;
                        Console.Write("Please Enter a string : ");
                        strtwo = Console.ReadLine();
                        Console.WriteLine("\"" + strtwo + "\"" + " contains {0} spaces", CountSpaces.FuncCountSpaces(strtwo));
                        break;

                    case "5":
                        try
                        {
                            var itemlist = (from c in Item_Mast.Getitem()
                                            select c.ItemDes)
                                .Distinct()
                                .OrderBy(x => x);

                            foreach (var item in itemlist)
                                Console.WriteLine(item);
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }
                        break;

                    case "6":
                        List<String> sortlist = StringExercise.Sort();
                        foreach (var item in sortlist)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "7":
                        IEnumerable<string> _result = RemoveItemsFromList.RemoveItems();
                        foreach (var removeChar in _result)
                        {
                            Console.WriteLine("Char: {0} ", removeChar);
                        }

                        break;

                    case "8":
                        List<String> list = CopyAllElementsFromArray.CopyAll();
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "9":
                        Console.Write("Enter the string you want to modify: ");
                        string myString = Console.ReadLine();

                        Console.WriteLine(RemoveAllSpaceFromString.RemoveWhiteSpace(myString));
                        break;
                    case "10":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }


            }
        }
    }
}