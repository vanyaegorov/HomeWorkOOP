using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Acoder acoder = new Acoder();
            string encoder = acoder.Encode("Привет МИР!");
            Console.WriteLine(encoder);
            Console.WriteLine(acoder.Decode(encoder));
            Bcoder bcoder = new Bcoder();
            string newencoder = bcoder.Encode("АБВГДЕ");
            Console.WriteLine(newencoder);
            Console.WriteLine(bcoder.Decode(newencoder));



        }
    }
}
