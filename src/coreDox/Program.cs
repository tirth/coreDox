using System;
using CommonMark;

class Program
{
    static void Main(string[] args)
    {
        var result = CommonMarkConverter.Convert("**Hello world!**");
        
        Console.WriteLine("Hello World!");
    }
}
