using System;
using System.Linq; //<-- added this to help with one of the "Contains" issues but didn't work

namespace CG_6_3_Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string Alice = "\nAlice was beginning to get very tired of sitting by her sister\n" +
                "on the bank, and of having nothing to do: once or twice she had peeped into\n" +
                "the book her sister was reading, but it had no pictures or conversations in it,\n" +
                "‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";

            Console.WriteLine($"Provide a word and see if it exists in the quote, {Alice}.");
            Console.WriteLine();

            var search = Console.ReadLine();
            //var start = Alice.IndexOf(search, StringComparison.OrdinalIgnoreCase); <--this doesn't do case insensitive
            var start = Alice.IndexOf(search);
            var end = search.Length;

            //Contains(search);
            //string title = search;
            //bool contains = Alice.Contains("title", StringComparison.OrdinalIgnoreCase);
            //^^That doesn't seem to work.  "Contains" says an overload issue that I can't 
            //figure out how to fix

            /*vvv thought this was a way to do CI -- no go
           StringCommparison comp = StringComparison.Ordinal;
            Console.WriteLine("        {0;G}:   {1]", comp, Alice.Contains(search, comp));

            comp = StringComparison.OrdinalIgnoreCase;
            Console.WriteLine("   {0:G}:  {1}", comp, Alice.Contains(search, comp));*/



            //if (Alice.Contains(AliceSearch))
            if (Alice.Contains(search)) //<--- this one works but is case sensitive
            //if (Alice.ToUpper().Contains(SEARCH)) //<---tried this for case insensitive.  No go.
            //if(Alice.Equals(search, StringComparison.InvariantCultureIgnoreCase)) <--tried this for case insensitive. No go.
            //if (string.Equals(Alice, search, StringComparison.OrdinalIgnoreCase)) <-- tried this for caase insensitive. No go.
            //if (Alice.Contains(search, StringComparison.OrdinalIgnoreCase)) <--tried this to make case insensitive. No go.
            //if (search.ToLowerCase() == Console.ReadLine()) <--No go for CI (case insensitive)
            //if (Alice.ToLowerCase() == search) <--No go for CI
            {
                Console.WriteLine("True. The word was found within the quote.");
            }

            else
            {
                Console.WriteLine("Fasle.It is not in that quote.");
            }


           // bool contains = Alice.Contains(search, StringComparison.OrdinalIgnoreCase) >= 0;
           //^^ trying to figure out case insensitive - no go on this way

            Console.ReadLine();

        }
        //vvv all that was trying to create methods to make it case insensitive
        //private static void Contains(string search)
        //{
        //    throw new NotImplementedException();
        //}this was the sugggested fix to the bool method to try and make it not case insenstive


        //public static bool Contains (this string source, string toCheck, StringComparison comp)
        //{
        //    return source.IndexOf(toCheck, comp) >= 0;
        //}this was a way to make it case insenstive. Did not work
    }
}
