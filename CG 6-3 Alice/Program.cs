using System;
using System.Linq; //<-- added this to help with one of the "Contains" issues but didn't work

namespace CG_6_3_Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the string code that the program is based off of. Assigning it a variable to use.
            string Alice = "\nAlice was beginning to get very tired of sitting by her sister\n" +
                "on the bank, and of having nothing to do: once or twice she had peeped into\n" +
                "the book her sister was reading, but it had no pictures or conversations in it,\n" +
                "‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";

            //This is the code asking the user to see if a certain word is within the quote.
            Console.WriteLine($"Provide a word and see if it exists in the quote, {Alice}.");
            Console.WriteLine();

            //This is assigning the word input from the user to a variable to be used
            var search = Console.ReadLine();
           
            
            //var start = Alice.IndexOf(search, StringComparison.OrdinalIgnoreCase); <--this doesn't do case insensitive
           
            //This was the code used to search for the word.  This bit of code is case sensitive.
            // var start = Alice.IndexOf(search);
            //var end = search.Length;

            //This code is to search for the word but is not case sensitive.
            var start = Alice.ToUpper().IndexOf(search.ToUpper());

       
            //if (Alice.Contains(search)) //<--- this one works but is case sensitive
           
            //If statement to find the word the user inputs.  The first half is if the word does
            //exist in the quote, the 'else' statement is if the word is not in the quote.
            if (start >= 0)


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

        //if (Alice.ToUpper().Contains(SEARCH)) //<---tried this for case insensitive.  No go.
        //if(Alice.Equals(search, StringComparison.InvariantCultureIgnoreCase)) <--tried this for case insensitive. No go.
        //if (string.Equals(Alice, search, StringComparison.OrdinalIgnoreCase)) <-- tried this for caase insensitive. No go.
        //if (Alice.Contains(search, StringComparison.OrdinalIgnoreCase)) <--tried this to make case insensitive. No go.
        //if (search.ToLowerCase() == Console.ReadLine()) <--No go for CI (case insensitive)
        //if (Alice.ToLowerCase() == search) <--No go for CI



    }
}
