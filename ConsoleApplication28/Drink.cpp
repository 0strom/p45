#include "Drink.h"
#include <iostream>
using namespace std;


Drink::Drink() : Drink(0.99, "Classic", "GenericBrand") {
	ingredients = nullptr;
}


Drink::Drink(double price, string flavour, string brandname)
	: price(price), flavour(flavour), brandname(brandname) {
	ingredients = nullptr;
}

Drink::~Drink() {
	delete[] ingredients;
}



void Drink::SetPrice(double price) {
	if (price >= 0)
		this->price = price;
}
void Drink::SetFlavour(string flavour) {
	this->flavour = flavour;
}
void Drink::SetBrandName(string brandname) {
	this->brandname = brandname;
}
void Drink::SetIngredients(string* ingredients) {
	this->ingredients = ingredients;
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

string* Drink::GetIngredients() {
	return ingredients;
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