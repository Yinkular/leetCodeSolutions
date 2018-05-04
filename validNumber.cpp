#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

bool validNumber(string input)
{
	int length = input.length()-1;
	int start = 0;
	bool valid = false, point= false;
	char c = input[start];;

	while (isspace(c)) // read off starting white spaces
	{
		start++;
		c = input[start];
	}

	if (isdigit(c) || c == '+' || c == '-') // if after reading whitespaces next char is digit or sign
	{
		valid = true;
		start++;

		while (start<=length)
		{
			c = input[start];

			if (isdigit(c))
			{
				start++;
			}

			else if (c == '.' && point == false) // if you get a decimal
			{
				start++;
				point = true;
			}

			else if (!isdigit(c) || c == '.' && point == true) // if you get non decimal or a second point
			{
				valid = false;
				break;
			}
		}
		
	}

	else
	{
		return valid;
	}

	return valid;
}

int main()
{
	string input;
	bool output;

	getline(cin, input);

	output = validNumber(input);

	if (output)
		cout << "TRUE" << endl;

	else
		cout << "FALSE" << endl;
	
	return 0;
	
}