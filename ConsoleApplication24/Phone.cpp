#include "Phone.h"
#include <iostream>
using namespace std;

void Phone::SetBattery(int b) {
	if (b >= 0 && b <= 100)
		battery = b;
}

void Phone::SetModelName(string m) {
	modelname = m;
}

void Phone::SetBrandName(string b) {
	brandname = b;
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

void Phone::WatchPhone() {
	cout << brandname << " — so many things to watch\n";
}

void Phone::LowBattery() {
	battery = 0;
	cout << brandname << " 0%\n";
}

void Phone::Charge() {
	battery = 100;
	cout << brandname << " 100%\n";
}