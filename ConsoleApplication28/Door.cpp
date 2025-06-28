#include "Door.h"
#include <iostream>
using namespace std;


Door::Door() : Door("Default Door", "closed") {
	materials = nullptr;
}

Door::Door(string name, string status)
	: name(name), status(status) {
	materials = nullptr;
}


Door::~Door() {
	delete[] materials;
}



void Door::SetName(string name) {
	this->name = name;
}
void Door::SetStatus(string status) {
	this->status = status;
}
void Door::SetMaterials(string* materials) {
	this->materials = materials;
}



string Door::GetName() {
	return name;
}
string Door::GetStatus() {
	return status;
}
string* Door::GetMaterials() {
	return materials;
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