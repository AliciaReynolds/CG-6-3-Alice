using System;

namespace CG_6_3_Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alice = "Alice was beginning to get very tired of sitting by her sister/n " +
                "on the bank, and of having nothing to do: once or twice she had peeped into/n" +
                " the book her sister was reading, but it had no pictures or conversations in it,/n" +
                " ‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";

            Console.WriteLine($"Provide a word and see if it exists in the quote, {Alice}.");

            var search = Alice.IndexOf(Console.ReadLine());
            string AliceSearch = Convert.ToString(search);

            
            if (Alice.Contains(AliceSearch))
            {
                Console.WriteLine("True. The word was found within the quote.");
            }

            else
            {
                Console.WriteLine("Fasle.It is not in that quote.");
            }

            Console.ReadLine();

        }
    }
}
