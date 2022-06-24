#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> progresses, vector<int> speeds)
{
    vector<int> release;
    vector<int> answer;

    for (int i = 0; i < progresses.size(); i++)
    {
        int temp;
        temp = (100 - progresses[i]) % speeds[i];
        if (temp > 0)
            release.push_back((100 - progresses[i]) / speeds[i] + 1);
        else
            release.push_back((100 - progresses[i]) / speeds[i]);
    }

    int count = 1;
    int temp = release.front();

    for (int i = 0; i < release.size() - 1; i++)
    {
        if (temp >= release[i + 1])
            count++;
        else
        {
            temp = release[i + 1];
            answer.push_back(count);
            count = 1;
        }
    }

    answer.push_back(count);
    return answer;
}