#ifndef CALCULATOR_H
#define CALCULATOR_H

#include <string>
using namespace std;

class Calculator {
private:
	string name;

public:
	void SetName(string n);
	string GetName();

		void On();
	void CalculateSum();
	void Off();
};

#endif #pragma once
