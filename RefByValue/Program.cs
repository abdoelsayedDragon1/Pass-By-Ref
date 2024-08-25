namespace RefByValue
{
    internal class Program
    {
        static void overRide(ref int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 10; 
            }
        }
        static void Main(string[] args)
        {
            
            int[] myarr= { 1, 2, 3, 5, 6, 7, 8, 9};
            Console.WriteLine(myarr[5]);
                overRide( ref myarr);
            Console.WriteLine(myarr[0]);
        }
    }
}
