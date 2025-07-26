public class Example
{
    public static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        int result = 0;
        for (int i = 2; i < n; i++)
        {
            if ((n % i) == 1)
            {
                result = i;
                break;
            }
        }

        sw.WriteLine(result);
        sw.Flush();
    }
}