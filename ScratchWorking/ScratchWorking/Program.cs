using System;
using System.Diagnostics;
using System.IO;

namespace ScratchWorking
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
