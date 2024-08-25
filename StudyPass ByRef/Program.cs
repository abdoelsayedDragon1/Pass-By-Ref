using System.ComponentModel.DataAnnotations;

namespace StudyPass_ByRef
{
    internal class Program
    {
        static void Swap(ref int A, ref int B)
        {
            A = 20;
            B = 10;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            
        }
    }
}
