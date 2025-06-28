#ifndef DOOR_H
#define DOOR_H

#include <string>
using namespace std;

class Door {
private:
	string name;
	string status;
	string* materials;

public:
	
	Door();
	Door(string name, string status);

	~Door();
	void SetName(string name);
	void SetStatus(string status);
	void SetMaterials(string* materials);


	string GetName();
	string GetStatus();
	string* GetMaterials();


	void Open();
	void Close();
	void Broken();
};

#endif 
