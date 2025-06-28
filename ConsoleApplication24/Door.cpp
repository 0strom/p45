#include "Door.h"
#include <iostream>
using namespace std;

void Door::SetName(string n) {
	name = n;
}

void Door::SetStatus(string s) {
	status = s;
}

string Door::GetName() {
	return name;
}

string Door::GetStatus() {
	return status;
}

void Door::Open() {
	status = "opened";
	cout << name << " is opened\n";
}

void Door::Close() {
	status = "closed";
	cout << name << " is closed\n";
}

void Door::Broken() {
	cout << name << " is broken, you cannot use it!\n";
}

