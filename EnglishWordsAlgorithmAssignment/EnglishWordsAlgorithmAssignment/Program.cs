using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace EnglishWordsAlgorithmAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rows = File.ReadAllLines(@"C:\Users\Sneh Mehta\source\repos\EnglishWordsAlgorithmAssignment\EnglishWordsAlgorithmAssignment\bin\words.txt").ToList();

            //TheReverseOrder

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var reverse = from words in rows
                          orderby words descending
                          select words;

            foreach (string value in reverse)
            {
                Console.WriteLine(value);
            }

            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ReadKey();




            ////ReturnsWordsWithZ
            //var startsWith1 = "Z";
            //var startsWith2 = "z";
            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();

            //var queryResults =
            //    from r in rows
            //    where r.StartsWith(startsWith1, StringComparison.Ordinal) || r.StartsWith(startsWith2, StringComparison.Ordinal)
            //    select r;

            //foreach (var item in queryResults)
            //{
            //    Console.WriteLine(item);
            //}

            //watch.Stop();
            ////count how many results were quereyed
            //Console.WriteLine($"Number of Query Results: " + queryResults.Count());
            //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //Console.ReadKey();




            ////ReturnsWordsWithHeAtBeggining

            //var startsWith1 = "he";
            //var startsWith2 = "hE";
            //var startsWith3 = "HE";
            //var startsWith4 = "He";

            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();

            //var queryResults =
            //    from r in rows
            //    where r.StartsWith(startsWith1, StringComparison.Ordinal) || r.StartsWith(startsWith2, StringComparison.Ordinal) || r.StartsWith(startsWith3, StringComparison.Ordinal) || r.StartsWith(startsWith4, StringComparison.Ordinal)
            //    select r;

            //foreach (var item in queryResults)
            //{
            //    Console.WriteLine(item);
            //}

            //watch.Stop();

            ////count how many results were quereyed
            //Console.WriteLine($"Number of Query Results: " + queryResults.Count());
            //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //Console.ReadKey();




            ////ReturnsWordsWithEInSecondPosition

            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();

            //var result = rows.Where(e => e.Length > 1 && e[1] == 'e');
            //var result2 = rows.Where(E => E.Length > 1 && E[1] == 'E');

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //watch.Stop();
            //Console.WriteLine($"Number of Query Results: " + result.Count());
            //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //Console.ReadKey();










        }
    }
}
