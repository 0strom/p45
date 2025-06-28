#ifndef PHONE_H
#define PHONE_H

#include <string>
using namespace std;

class Phone {
private:
	int battery;
	string modelname;
	string brandname;
	string* apps;

public:
	
	Phone();
	Phone(int battery, string modelname, string brandname);

		
	~Phone();
	void SetBattery(int battery);
	void SetModelName(string modelname);
	void SetBrandName(string brandname);
	void SetApps(string* apps);


	int GetBattery();

	string GetModelName();
	string GetBrandName();
	string* GetApps();

	
	void WatchPhone();
	void LowBattery();
	void Charge();
};

#endif
