using System;

namespace SnakeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Methods.GetFullName("Alex", "Alex", "Alex");
            Methods.GetFullName("John", "Simenson", "Tran");
            Methods.GetFullName("Alex", "Smith", "Chohel");

            //2
            Methods.GetSumofStrinLine("110 120 15 2 3 1 150");

            //3
            Methods.GetSesonTime();
        }
    }
}
