#include <iostream>
#include "Guitar.h"
#include "Book.h"
#include "Drink.h"
#include "Phone.h"
#include "Door.h"
#include "Calculator.h"

using namespace std;

int main() {
	
	Guitar guitar1;
	Guitar guitar2("Red", 6, "Strat", "Fender");

	string* accessories = new string[3]{ "Capo", "Pick" };
	guitar2.SetAccessories(accessories);
	guitar2.Play();

	delete[] accessories;

	


	Book book1;
	Book book2("Blue", 300, "C++ Basics");

	string* authors = new string[2]{ "Bjarne", "Stroustrup" };
	book2.SetAuthors(authors);
	book2.Read();

	delete[] authors;

	

	Drink drink1;
	Drink drink2(1.99, "Orange", "Fanta");

	string* ingredients = new string[2]{ "Water", "Sugar" };
	drink2.SetIngredients(ingredients);
	drink2.Drinking();

	delete[] ingredients;


	
	Phone phone1;
	Phone phone2(85, "iPhone 15", "Apple");

	string* apps = new string[3]{ "Camera", "Notes", "Safari" };
	phone2.SetApps(apps);
	phone2.WatchPhone();

	delete[] apps;

	

	Door door1;
	Door door2("Back Door", "closed");

	string* materials = new string[2]{ "Wood", "Steel" };
	door2.SetMaterials(materials);
	door2.Open();

	delete[] materials;

	


	Calculator calc1;
	Calculator calc2("Casio FX");

	string* operations = new string[3]{ "Add", "Subtract", "Multiply" };
	calc2.SetOperations(operations);
	calc2.On();
	calc2.CalculateSum();

	delete[] operations;

}