namespace BinarySearch
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 , 8, 9, 10, 68, 125, 987};

            SortIntgers sortIntgers = new SortIntgers(arr);
            BinarySeachAlgorithm<int> binarySeachAlgorithm = new BinarySeachAlgorithm<int>(sortIntgers);


            Console.WriteLine(binarySeachAlgorithm.binarySearch(5, arr.Length));

           

        }
    }
}
