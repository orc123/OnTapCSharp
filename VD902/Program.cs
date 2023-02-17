namespace VD902
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayVals(5, 6, 7, 8);

            int[] explicitArray = new int[5] { 1, 2, 3, 4, 5 };
            DisplayVals(explicitArray);
        }

        public static void DisplayVals(params int[] intVals)
        {
            foreach (var item in intVals)
            {
                Console.WriteLine("Display Value {0}", item);
            }
        } 
    }
}