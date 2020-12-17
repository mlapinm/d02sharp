using System;
using System.Threading;

namespace d2022hello
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Thread thread = new Thread(new ThreadStart(stuff));
                thread.Start();
            }catch(Exception e){
                Console.WriteLine(e);
            }

            static void stuff(){
                Console.WriteLine("Thread 1 running");
            }

        }
    }
}
