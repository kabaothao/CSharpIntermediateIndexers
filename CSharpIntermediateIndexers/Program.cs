// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace CSharpIntermediateIndexers // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Kabao";
            Console.WriteLine(cookie["name"]);
        }
    }
}




/*
What is an indexer?

A mixer is a way to access elements in a class that represents a list of values.



Now how can we declare an indexer and indexer is nothing but a property.

So we can declare an indexer exactly like how we declare a property.

So we have the data type like string.

Then in sort of an identifier we use that this keyword.

And here is the index or notation.

So brackets and inside the bracket we have the type of indexer.

So in this case with the typical key I want to find items by the key which should be a string.
 */