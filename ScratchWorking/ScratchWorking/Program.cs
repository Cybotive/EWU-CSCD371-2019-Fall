using System;
using System.Diagnostics;
using System.IO;

namespace ScratchWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentException(nameof(args), "My message here"); //C# reversed the parameters so this is wrong
            }

#pragma warning disable CS0219 // Variable is assigned but its value is never used
            (string, string) _ = ("", ""); //tuple
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            int number = 42;
            Print(number); //boxing, since Print takes in an Object

            var numbers = (1, 2); //still a value type, so not passed by reference
            Print(numbers); //(1, 2)
            AddNumbers(numbers);
            Print(numbers); //(1, 2)

            try
            {
                //IO Stuff
                Console.WriteLine("Hello World!");
            }
            catch (IOException ex) when (ex.Message == "this message") //this when statement reduces callstack load
            {
                //Do something
            }
            catch(Exception e)
            {
                Debug.WriteLine($"{e}"); //this is very bad. Don't log then rethrow without handling the exception
                throw;
            }

            Pets pets = Pets.Dog;
        }

        public static void AddNumbers((int, int) numbers)
        {
            numbers.Item1 += numbers.Item2;
        }

        public static void Print(Object foo) => Console.WriteLine(foo.ToString());

        [Flags]
        public enum Pets //pretend mixing animals makes sense. This stuff is on Assignment 5
        {
            Dog = 0b_0000,
            Cat = 0b_0001,
            Bird = 0b_0010,
            Chicken = 0b_0100
        }
    }
}
