#include <iostream>
#include <vector>
#include <string>
#include <sstream>
using namespace std;

string solution(string s) {
	istringstream ss(s);
	string stringBuffer;

	vector<int> strVec;
	strVec.clear();

	while (getline(ss, stringBuffer, ' '))
	{
		int num;
		stringstream ssInt(stringBuffer);
		ssInt >> num;
		strVec.push_back(num);
	}

	int minNum = strVec[0];
	int maxNum = strVec[0];

	for (int i = 0; i < strVec.size(); i++)
	{
		minNum = min(minNum, strVec[i]);
		maxNum = max(maxNum, strVec[i]);
	}

	string result = "";
	result = to_string(minNum) + " " + to_string(maxNum);

	return result;
}