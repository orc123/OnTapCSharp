namespace VD904;

public class Program
{
    static void Main(string[] args)
    {
        const int rows = 4;
        const int columns = 3;

        int[,] rectangularArray = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                rectangularArray[i, j] = i + j;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"rectangularArray[{i}, {j}] = {rectangularArray[i, j]}");
            }
        }
    }
}