using System;

namespace DelegateApp
{

    public delegate string strMyDel(string str);
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate tele = new TestDelegate();
            strMyDel spacedel = tele.Space;
            strMyDel reversedel = tele.Reverse;

            string space = spacedel.Invoke("Michael");
            string reverse = reversedel.Invoke("Aiyetan");
            Console.WriteLine(space);
            Console.WriteLine(reverse);
        

        }
    }
}
