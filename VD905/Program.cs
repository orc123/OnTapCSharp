namespace VD905;

public class Program
{
    static void Main(string[] args)
    {
        const int rows = 4;
        const int columns = 3;

        int[,] rectangularArray =
        {
            {0, 1, 2 },
            {3, 4, 5 },
            {6, 7, 8},
            {9, 10, 11 }
        };
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"rectangularArray[{i}, {j}] = {rectangularArray[i, j]}");
            }
        }
    }
}