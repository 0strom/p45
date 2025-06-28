#include "Phone.h"
#include <iostream>
using namespace std;

Phone::Phone() : Phone(100, "ModelX", "BrandY") {
	apps = nullptr;
}


Phone::Phone(int battery, string modelname, string brandname)
	: battery(battery), modelname(modelname), brandname(brandname) {
	apps = nullptr;
}


Phone::~Phone() {
	delete[] apps;
}


void Phone::SetBattery(int battery) {
	if (battery >= 0 && battery <= 100)
		this->battery = battery;
}
void Phone::SetModelName(string modelname) {
	this->modelname = modelname;
}
void Phone::SetBrandName(string brandname) {
	this->brandname = brandname;
}
void Phone::SetApps(string* apps) {
	this->apps = apps;
}



int Phone::GetBattery() {
	return battery;
}
string Phone::GetModelName() {
	return modelname;
}
string Phone::GetBrandName() {
	return brandname;
}
string* Phone::GetApps() {
	return apps;
}


void Phone::WatchPhone() {
	cout << brandname << " so many things to watch\n";
}

void Phone::LowBattery() {
	battery = 0;
	cout << brandname << " 0%\n";
}

void Phone::Charge() {
	battery = 100;
	cout << brandname << " 100%\n";
}