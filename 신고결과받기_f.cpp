#include <string>
#include <vector>
#include <sstream>
#include <algorithm>
#include <map>
#include <iostream>
using namespace std;

vector<int> solution(vector<string> id_list, vector<string> report, int k) {
    vector<string> reportSplit;
    vector<int> answer;
    map<string, vector<string>> reportMap;

    sort(report.begin(), report.end());
    report.erase(unique(report.begin(), report.end()), report.end());


    for (int i = 0; i < report.size(); i++)
    {
        istringstream stream(report[i]);
        string str;
        while (getline(stream, str, ' '))
        {
            reportSplit.emplace_back(str);
        }
    }

    bool isSending = false;
    for (int i = 1; i < reportSplit.size(); i += 2)
    {
        string temp = reportSplit[i];
        int count = 0;
        for (int j = 1; j < reportSplit.size(); j += 2)
        {
            if (temp == reportSplit[j])
            {
                count++;
                if (count >= k)
                {
                    isSending = true;
                    break;
                }
            }
        }                           
    }


    for (int i = 0; i < reportSplit.size(); i += 2)
    {
        int count = 0;
        string name = reportSplit[i];
        for (int j = 1; j < reportSplit.size(); j += 2)
        {
            if (name == reportSplit[j-1])
            {
                count++;
                if (isSending)
                    answer.emplace_back(count);
                else
                    for(int k = 0; k < id_list.size(); k++)
                        answer.emplace_back(0);
            }
            else
                continue;
        }
    }
    return answer;
}

int main()
{
    vector<string> id_list = { "con", "ryan" };
    vector<string> report = { "ryan con", "ryan con", "ryan con", "ryan con" };
    solution(id_list, report, 2);
    for (int i = 0; i < solution(id_list, report, 2).size(); i++)
    {
        cout << solution(id_list, report, 2)[i] << endl;
    }
}