public class Example
{
    public static void Main(string[] args)
    {
        int[, ] ints = {{2, 5, 3 }, {4, 4, 1 }, {1, 7, 3 } };
        Solution([1, 5, 2, 6, 3, 7, 4], ints);
    }

    public static int[] Solution(int[] array, int[,] commands)
    {
        int[] newArr;
        int[] result = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            newArr = new int[commands[i,1] - commands[i,0] + 1];
            for (int j = 0; j < newArr.Length; j++)
            {
                newArr[j] = array[j + commands[i,0] - 1];
            }
            Array.Sort(newArr);
            result[i] = newArr[commands[i,2] - 1];
        }

        return result;
    }
}