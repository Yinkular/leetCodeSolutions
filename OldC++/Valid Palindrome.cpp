#include <iostream>
#include <string>

using namespace std;

bool isPalindrome(string input)
{
	int start =0,end = input.length()-1;
	char front, back;
	
	while(start< end)
	{
		//front = tolower(input[start]);
		//back = tolower(input[end]);
		
		// check if both are alphabets
		while(!isalpha(input[start])) // if character at the front end isn;t alpha move to the next
		{
			start++;
		}
		
		while(!isalpha(input[end])) // if charater at the back isn't alpha go to the next
		{
			end--;
		}
		
		//make character lower and assign current alphabets to variables
		front = tolower(input[start]);
		back = tolower(input[end]);
		
		if(front!=back)
		{
			return false;
		}
		
		// next characters
		start++;
		end--;
	}
	
	return true;
}

int main()
{
	string input;
	getline(cin, input); // accept input
	
	bool status;
	
	status = isPalindrome(input); // call function
	
	if(status)
	{
		cout << "VALID PALINDROME" << endl;
	}
	
	else
	{
		cout << "INVALID" << endl;
	}
	return 0;
}