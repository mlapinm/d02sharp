using System;
using System.IO;

namespace d2022hello
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                TextWriter textWriter = new StreamWriter("./new02.txt", true);
                textWriter.WriteLine("123");
                textWriter.Close();
                Console.WriteLine("File Worked");
            }catch(Exception e){
                Console.WriteLine(e);
            }


        }
    }
}
