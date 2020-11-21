using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamZach.Learning
{

    using SamZach.Learning.LibraryOne;
    using TestNameSpace;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(EvenOrOdd("1"));

            //I am Sam oo     //Sam oo
            StringIndexer.GetTextBeforeSpecifiedString("Sam oo", "Sam");
            StringIndexer.GetTextAfterSpecifiedString("Sam oo", "Sam");
            StringIndexer.GetTextBetweenSpecifiedStrings("Sam oo Sam","Sam", "Sam");

            Console.ReadLine();
        }

        static string EvenOrOdd(string str) =>
            int.TryParse(str, out int num) ? (num % 2 == 0) ? "Even" : "Odd" : "Invalid Parameter";

        static bool IsEven(int num) => num % 2 == 0;

        internal class InnerClass
        {
            public int SimpleNumber { get; set; }
        }
    }

    class TestClass
    {
        Program.InnerClass innerClass = new Program.InnerClass();

        void TestMethod()
        {

        }
    }
}

namespace TestNameSpace
{
    internal class LibraryTestClass
    {

    }
}
