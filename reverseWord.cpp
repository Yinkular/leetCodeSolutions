#include <iostream>
#include <string>


using namespace std;


string reverseString(string input)
{
	string output = "", subString;
	int length = input.length(), start = length - 1;
	bool lastChar = false;

	while (start > 0) // start from the end
	{
		subString = "";
		while (start >= 0 && !isalpha(input[start])) // if current character isn't an alphabet keep shifiting back
		{
			start--;
		}

		int beg, end=0;

		while (start >= 0 && isalpha(input[start]))// if subsequent characters are alphabets keep looping
		{
			start--;
			end++; // number of characters to fetch
		}

		beg = start + 1;

		if (output.length() != 0) // if output isnt empty add space
		{
			output += " ";
		}

		subString = input.substr(beg,end); // get substring
		output += subString; // append word to output string

		input.resize(start);
	}

	return output;
}

int main()
{
	string input, output;

	getline(cin, input);

	output = reverseString(input);

	cout << output << endl;
	
	return 0;
	
}