#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cmath>

using namespace std;

int validNumber(string input)
{
	int length = input.length()-1;
	vector<bool> charTable(127, 0); // create a character table and set to false

	int maximum = 0,j=0;

	for (int i = 0; i <= length; i++) // loop through word
	{
		// loop runs when a character has been encountered previously
		// runs for the number of characters previously found
		while (charTable[input[i]-'a']) 
		{
			charTable[input[j] - 'a'] = false; // reset characters to false
			j++;
		}

		charTable[input[i] - 'a'] = true;
		maximum = max(i - j + 1, maximum);
	}
	
	return maximum;
}

int main()
{
	string input;
	int output;

	getline(cin, input);

	output = validNumber(input);

	
	cout << output << endl;

	return 0;
	
}