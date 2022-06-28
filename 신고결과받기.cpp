#include <string>
#include <vector>
#include <sstream>
#include <algorithm>
#include <map>
using namespace std;

vector<string> Split(string token)
{
    vector<string> result;
    istringstream stream(token);
    string str;
    while (getline(stream, str, ' '))
    {
        result.emplace_back(str);
    }

    return result;
}

vector<int> solution(vector<string> id_list, vector<string> report, int k) 
{
    vector<int> answer;
    map<string, vector<string>> reported;
    map<string, vector<string>> getReported;

    for (const auto& report_Item : report)
    {
        vector<string> names = Split(report_Item);
        string name1 = names[0];
        string name2 = names[1];

        //해당키가 비어있을 경우와 값이 없는경우
        if (reported[name1].empty() || (find(reported[name1].begin(), reported[name1].end(), name2) == reported[name1].end()))
        {
            reported[name1].emplace_back(name2);
        }
        if (getReported[name2].empty() || (find(getReported[name2].begin(), getReported[name2].end(), name1) == getReported[name2].end()))
        {
            getReported[name2].emplace_back(name1);
        }

    }

    for (const auto& id_item : id_list)
    {
        int count = 0;
        vector<string> name_list = reported[id_item];
        for (const auto& name : name_list)
        {
            if (getReported[name].size() >= k)
            {
                count++;
            }
        }
        answer.emplace_back(count);
    }

    return answer;
}