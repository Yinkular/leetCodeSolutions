#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cmath>

using namespace std;

typedef pair <int, int> ii;

vector<ii> range(vector<int> input)
{
	int length = input.size();
	string answer = "";
	vector <ii> fullRange;

	bool start = false, end = false;

	if (length == 0)
	{
		fullRange.push_back({ 0, 99 });

		return fullRange;
	}

	if (input[0] == 0)
	{
		start = true;
	}

	if (input[length - 1] == 99)
	{
		end = true;
	}

	int beg=0, fin=0, current , next;
	for (int i = 0; i<length; i++)
	{
		current = input[i];
		if (i+1 < length) // make sure stays within limit
		next = input[i + 1];
		
		if (i == 0 && !start) // if first number and first number isnt a zero
		{
			beg = 0;
			fin = current - 1;
		}

		else if (i == (length - 1) && !end) // last number isn't 99
		{
			beg = current + 1;
			fin = 99;
		}

		else if ((current + 1) != next) // other numbers
		{
			beg = current + 1;
			fin = next - 1;
		}

		
		fullRange.push_back({beg, fin}); // push current missing range back to array
	}

	return fullRange;
}

int main()
{
	vector<int> input;
	int num;
	vector<ii> output;

	while (cin >> num)
	{
		input.push_back(num);
	}

	output = range(input);

	for (int i = 0; i<output.size(); i++)
	{
		cout << output[i].first << "->" << output[i].second;

		if (i< output.size() - 1)
		{
			cout << ",";
		}
	}


	return 0;

}