public class Example
{
    public static void Main(string[] args)
    {
        
    }

    public static int[] Solution(int[] progresses, int[] speeds)
    {
        Queue<int> completeQ = new Queue<int>();
        for (int i = 0; i < progresses.Length; i++)
        {
            int remain = (100 - progresses[i]) % speeds[i];
            if (remain > 0)
            {
                completeQ.Enqueue((100 - progresses[i]) / speeds[i] + 1);
            }
            else
            {
                completeQ.Enqueue((100 - progresses[i]) / speeds[i]);
            }
        }

        List<int> answers = new List<int>();
        int releaseDay = completeQ.First();
        int releaseNum = 0;
        while (completeQ.Count > 0)
        {
            if (releaseDay >= completeQ.First())
            {
                releaseNum++;
                completeQ.Dequeue();
            }
            else
            {
                answers.Add(releaseNum);
                releaseNum = 0;
                releaseDay = completeQ.First();
            }
        }
        answers.Add(releaseNum);
        return answers.ToArray();
    }
}