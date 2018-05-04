#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

string reverse(string input, int start, int end)
{
	while (start < end)
	{
		swap(input[start], input[end]);
		start++;
		end--;
	}

	return input;
}

string reverseString(string input)
{
	int length = input.length();
	int start = length-1;

	while (start >= 0)
	{
		int beg, end;
		while (start >= 0 && !isalpha(input[start]))
		{
			start--;
		}

		end = start;

		while (start >= 0 && isalpha(input[start]))
		{
			start--;
		}
		beg = start+1;

		input = reverse(input, beg, end); // reverse each word in the string
	}
	
	input = reverse(input, 0, length - 1); // reverse entire word
	return input;
}

int main()
{
	string input, output;

	getline(cin, input);

	output = reverseString(input);

	cout << output << endl;
	
	return 0;
	
}