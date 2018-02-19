using System;
using System.Linq;

namespace ConsoleA5._Short_Words_Sortedpp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().
                Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '/', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                
               ;
          var sortwords=  words.Where(x => x.Count() < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ",sortwords));   
        }
    }
}
