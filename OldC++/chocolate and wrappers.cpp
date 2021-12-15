#include <iostream>


using namespace std;

int main()
{
	int amountEntered, costPerChocolate, wrappersPerDiscount;
	int totalNumberOFChocolates, totalNumberOfWrappers;

	//cout << "Enter amount you have" << endl;
	cin >> amountEntered;


	totalNumberOFChocolates = 0; // intital number of chocolates is zero
	costPerChocolate = 1; // cost of each chocolate
	wrappersPerDiscount = 3; // number of wrappers to be returned to get one

	totalNumberOFChocolates += amountEntered / costPerChocolate;

	totalNumberOfWrappers = totalNumberOFChocolates; // initially total number of wrappers = number of chocoaltes boutght

	int div, mod;
	while (totalNumberOfWrappers >= wrappersPerDiscount) // loop runs till there discount is improbable
	{
		div = totalNumberOfWrappers / wrappersPerDiscount; // get number of chocolates possible from current wrappers
		mod = totalNumberOfWrappers % wrappersPerDiscount; // wrappers left

		totalNumberOFChocolates += div; // add to previous number of chocolates
		totalNumberOfWrappers = div + mod; // get new number of wrappers
	}

	cout << totalNumberOFChocolates << endl; // print answer

	return 0;
}