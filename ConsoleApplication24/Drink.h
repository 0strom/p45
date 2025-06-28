#ifndef DRINK_H
#define DRINK_H

#include <string>
using namespace std;

class Drink {
private:
	double price = 0.99;
	string flavour;
	string brandname;

public:
	void SetPrice(double p);
	void SetFlavour(string f);
	void SetBrandName(string b);

		double GetPrice();
	string GetFlavour();
	string GetBrandName();

	void ReadDrink();
	void Drinking();
	void Throw();
};

#endif
