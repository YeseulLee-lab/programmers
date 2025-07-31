public class Example
{
    public static void Main(string[] args)
    {
        int[] answer = solution([1, 3, 2, 4, 2]);
        for (int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
        }
    }

    public static int[] solution(int[] answers)
    {
        int[] supo = {1, 2, 3, 4, 5};
        int[] supo2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] supo3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] cnt = new int[3];

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == supo[i % supo.Length])
            {
                cnt[0]++;
            }

            if (answers[i] == supo2[i % supo2.Length])
            {
                cnt[1]++;
            }

            if (answers[i] == supo3[i % supo3.Length])
            {
                cnt[2]++;
            }
        }

        int max = cnt[0];
        int maxPerson = 1;
        List<int> answer = new List<int>();

        for (int i = 0; i < cnt.Length; i++)
        {
            if (max < cnt[i])
            {
                answer.Clear();
                max = cnt[i];
                maxPerson = i + 1;
                answer.Add(maxPerson);
            }
            else if (max == cnt[i])
            {
                maxPerson = i + 1;
                answer.Add(maxPerson);
            }
        }

        return answer.ToArray();
    }
}