public class Example
{
    public static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string str = sr.ReadLine();
        char[] chars = str.ToArray();
        Array.Sort(chars);
        Array.Reverse(chars);

        string upperStr = "";
        string lowerStr = "";
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] < 'a')
            {
                upperStr += chars[i];
            }
            else
            {
                lowerStr += chars[i];
            }
        }

        sw.WriteLine(lowerStr + upperStr);
        sw.Flush();
    }

}