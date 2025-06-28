#include "Drink.h"
#include <iostream>
using namespace std;

void Drink::SetPrice(double p) {
	if (p >= 0)
		price = p;
}

void Drink::SetFlavour(string f) {
	flavour = f;
}

void Drink::SetBrandName(string b) {
	brandname = b;
}

double Drink::GetPrice() {
	return price;
}

string Drink::GetFlavour() {
	return flavour;
}

string Drink::GetBrandName() {
	return brandname;
}

void Drink::ReadDrink() {
	cout << brandname << " is the name of it\n";
}

void Drink::Drinking() {
	cout << flavour << " is good\n";
}

void Drink::Throw() {
	cout << brandname << " thrown away\n";
}