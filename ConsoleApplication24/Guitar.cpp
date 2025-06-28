#include "Guitar.h"
#include <iostream>
using namespace std;

void Guitar::SetColor(string color) {
	this->color = color;
}

void Guitar::SetStrings(int strings) {
	if (strings >= 6 && strings <= 12)
		this->strings = strings;
}

void Guitar::SetName(string name) {
	this->name = name;
}

void Guitar::SetModelName(string modelname) {
	this->modelname = modelname;
}

string Guitar::GetColor() {
	return color;
}

int Guitar::GetStrings() {
	return strings;
}

string Guitar::GetName() {
	return name;
}

string Guitar::GetModelName() {
	return modelname;
}

void Guitar::Play() {
	cout << name << " is being played...\n";
}

void Guitar::OutOfTune() {
	cout << name << " is detuned\n";
}

void Guitar::Tuned() {
	cout << name << ": is tuned, you can play again\n";
}Guitar::Tuned() { cout << name << ": is tuned, you can play again\n"; }