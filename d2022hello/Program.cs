using System;

namespace d2022hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "yellow";

            switch(color){
                case "white":
                Console.WriteLine("white");
                break;
                case "blue":
                Console.WriteLine("blue");
                break;
                default:
                Console.WriteLine("invalid color : " + color);
                break;
            }
        }
    }
}
