public class Example
{
    public static int des;
    public static int tar;

    public static int answer = 0;

    public static void Main(string[] args)
    {
        Console.Write(solution([4, 1, 2, 1], 2));
    }

    public static int solution(int[] numbers, int target)
    {
        des = numbers.Length;
        tar = target;

        DFS(0, 0, numbers);
        return answer;
    }

    public static void DFS(int sum, int n, int[] arr)
    {
        if (n < des)
        {
            DFS(sum + arr[n], n + 1, arr);//노드를 돌면서 더하고 빼면서 target이랑 같은지 확인
            DFS(sum - arr[n], n + 1, arr);
        }
        else
        {
            if (sum == tar)
            {
                answer ++;
            }
        }
    }
}