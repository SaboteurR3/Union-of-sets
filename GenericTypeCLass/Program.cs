using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeCLass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> passedList = new List<int> { 1, 3, 3, 8, 16, 17, 10 };
                List<int> List = new List<int> { 10, 3, 15, 17, 8, 25 };
                var firstList = new Set<int>(passedList);
                var secondList = new Set<int>(List);
                Console.Write("==========================================\nFirst set: { ");
                foreach (var set in firstList)
                {
                    Console.Write(set + ", ");
                }
                Console.WriteLine("}");
                Console.Write("==========================================\nSecond set: { ");
                foreach (var set in secondList)
                {
                    Console.Write(set + ", ");
                }
                Console.WriteLine("}");
                // AddItem method for firstlList
                Console.WriteLine("==========================================\nAdd item: " + firstList.AddItem(5));
                // Contains method for firstlList
                Console.WriteLine("==========================================\nFirst list contains '8': " + firstList.Contains(8));
                // Remove method for firstlList
                Console.WriteLine("==========================================\nRemoves '11' from list: " + firstList.Remove(11));
                // ISEMPTY getmethod for firstlList
                Console.WriteLine("==========================================\nList is empty: " + firstList.ISEMPTY);
                // COUNT getmethod for firstlList
                Console.WriteLine("==========================================\nFirst list contains " + firstList.COUNT + " items");
                // Union of sets
                Set<int> result = firstList + secondList;
                // For unique elements
                IEnumerable<int> union = result.Distinct();
                Console.Write("===============================================\nUnion of sets: { ");
                foreach (int number in union)
                {
                    Console.Write(number + ", ");
                }
                Console.WriteLine("}");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("===============================================\nBye <3\n");
            }
        }
    }
}