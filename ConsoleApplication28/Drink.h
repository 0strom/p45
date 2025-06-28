#ifndef DRINK_H
#define DRINK_H

#include <string>
using namespace std;

class Drink {
private:
	double price;
	string flavour;
	string brandname;
	string* ingredients;

public:
	
	Drink();
	Drink(double price, string flavour, string brandname);

	~Drink();
	void SetPrice(double price);
	void SetFlavour(string flavour);
	void SetBrandName(string brandname);
	void SetIngredients(string* ingredients);

	double GetPrice();
	string GetFlavour();
	string GetBrandName();
	string* GetIngredients();

	void ReadDrink();
	void Drinking();
	void Throw();
};

#endif 
