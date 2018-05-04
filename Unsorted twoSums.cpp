#include <iostream>
#include <algorithm>
#include <vector>
#include <map>


using namespace std;

typedef pair<int, int> ii;
typedef map<int, int> mii;

ii twoSums(mii list, int target)
{
	int size = list.size(), currentValue, otherValue;
	mii::iterator it; // create an iterator type for map
	
	for(int i=0;i<size;i++)
	{
		currentValue = list[i]; // get current index
		
		otherValue = target- currentValue; // get complimentary number
		
		it =list.find(otherValue); // check if complimentary number is in map
		
		if(it != list.end() ) // if it is in the map
		{
			return {list[currentValue], list[otherValue]};
		}
	}
	
	return {-1,-1};
}

int main()
{
	int n, value,target;
	cin >> n;
	
	mii list;
	
	for(int i=0;i<n;i++)
	{
		cin >> value;
		list[value] = i; // map each value to an index
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