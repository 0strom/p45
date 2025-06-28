#ifndef DOOR_H
#define DOOR_H

#include <string>
using namespace std;

class Door {
private:
	string name;
	string status;

public:
	void SetName(string n);
	void SetStatus(string s);

		string GetName();
	string GetStatus();

	void Open();
	void Close();
	void Broken();
};

#endif
