#include <iostream>
#include <algorithm>
#include <vector>


using namespace std;

typedef pair<int, int> ii;

ii twoSums(vector<int> list, int target)
{
	int start=0, end = list.size()-1, sum; // initalize variables
	
	while(start < end)
	{
		sum = list[start] + list[end];
		
		// if sum is less move lower index up
		if(sum < target )
		{
			start++;
		}
		
		// if sum is greater move greater index down
		else if(sum > target)
		{
			end --;
		}
		
		// answer
		else if(sum == target)
		{
			return {start+1, end+1};
		}
	}
	
	return{-1,-1};
}

int main()
{
	int n, target;
	cin >> n;
	
	vector<int> list(n);
	
	for(int i=0;i<n;i++)
	{
		cin >> list[i];
	}
	
	cin >> target;
	
	ii answer = twoSums(list, target);
	
	if(answer.first !=-1 && answer.second !=-1)
	{
		cout << answer.first << " " << answer.second << endl;
	}
	
	else
	{
		cout << "NOT FOUND" << endl;
	}
	return 0;
}