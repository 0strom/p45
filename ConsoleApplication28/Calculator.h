#ifndef CALCULATOR_H
#define CALCULATOR_H

#include <string>
using namespace std;

class Calculator {
private:
	string name;
	string* operations;

public:
	
	Calculator();
	Calculator(string name);

	~Calculator();
	void SetName(string name);
	void SetOperations(string* operations);

	string GetName();
	string* GetOperations();

	void On();
	void Off();
	void CalculateSum();
};

#endif
