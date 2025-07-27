public class Example
{
    public static void Main(string[] args)
    {
        int[,] computers = { { 1, 1, 0}, { 1, 1, 1 }, { 0, 0, 1} };//computers는 노드 연결 상태 나타냄
        Console.Write(solution(3, computers));
    }

    public static int solution(int n, int[,] computers)
    {
        int answer = 0;
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                answer++;
                DFS(i, n, computers, visited);
            }
        }

        return answer;
    }

    public static void BFS(int start, int num, int[,] computers, bool[] visited)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(start);
        visited[start] = true;

        while (q.Count > 0)
        {
            int cur = q.Dequeue();
            for (int i = 0; i < num; i++)
            {
                if (!visited[i] && computers[cur, i] == 1)
                {
                    visited[i] = true;
                    q.Enqueue(i);
                }
            }
        }
    }

    public static void DFS(int start, int num, int[,] computers, bool[] visited)
    {
        visited[start] = true;

        for (int i = 0; i < num; i++)
        {
            if (!visited[i] && computers[start, i] == 1)
            {
                visited[i] = true;
                DFS(i, num, computers, visited);
            }
        }
    }
}