#include "Calculator.h"
#include <iostream>
using namespace std;

void Calculator::SetName(string n) {
	name = n;
}

string Calculator::GetName() {
	return name;
}

void Calculator::On() {
	cout << name << " is On\n";
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

void Calculator::Off() {
	cout << name << " is Off, you must turn it on!\n";
}