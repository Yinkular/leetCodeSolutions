#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int stringToInt(string input)
{
	int length = input.length() - 1;
	int output=0, start =0;
	bool sign= true;
	char c;

	while (start <= length)
	{
		c = input[start];

		if(isspace(c)) // condition to skip spaces`
		{
			start++;
			continue;
		}

		// get sign
		else if (c == '+') 
		{
			sign = true;
		}

		else if (c == '-')
		{
			sign = false;
		}

		// get integer
		else
		{
			output = (c-'0') + output * 10;
		}
		start++;
	}

	if (!sign)
	{
		output *= -1;
	}

	return output;
}

int main()
{
	string input;
	int output;

	getline(cin, input);

	output = stringToInt(input);

	cout << output << endl;
	
	return 0;
	
}