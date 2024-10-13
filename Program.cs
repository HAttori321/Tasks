namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demonstration demo = new Demonstration();
            Random rnd = new Random();
            int[] arr = new int[50];
            int searchingValue = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10);
            }
            demo.ShowClock();
            demo.ShowPrimeNumbers(); 
            demo.ShowPrimeNumbers(1,22);
            demo.ShowingValuesByTaskList(arr);
            demo.ArrayWorkByContinueWith(arr, searchingValue);
        }
    }
}