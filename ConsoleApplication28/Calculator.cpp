#include "Calculator.h"
#include <iostream>
using namespace std;

Calculator::Calculator() : Calculator("DefaultCalc") {
	operations = nullptr;
}
Calculator::Calculator(string name) {
	this->name = name;
	operations = nullptr;
}
Calculator::~Calculator() {
	delete[] operations;
}


void Calculator::SetName(string name) {
	this->name = name;
}

void Calculator::SetOperations(string* operations) {
	this->operations = operations;
}




string Calculator::GetName() {
	return name;
}
string* Calculator::GetOperations() {
	return operations;
}



void Calculator::On() {
	cout << name << " is On\n";
}
void Calculator::Off() {
	cout << name << " is Off, you must turn it on!\n";
}



void Calculator::CalculateSum() {
	int a, b;
	cout << "Enter first number: ";
	cin >> a;
	cout << "Enter second number: ";
	cin >> b;
	cout << name << " is calculating sum...\n";
	cout << "Sum = " << a + b << "\n";
}