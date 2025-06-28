#ifndef PHONE_H
#define PHONE_H

#include <string>
using namespace std;

class Phone {
private:
	int battery = 100;
	string modelname;
	string brandname;

public:
	void SetBattery(int b);
	void SetModelName(string m);
	void SetBrandName(string b);

		int GetBattery();
	string GetModelName();
	string GetBrandName();

	void WatchPhone();
	void LowBattery();
	void Charge();
};

#endif 
