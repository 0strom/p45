#pragma on#ifndef GUITAR_H
#define GUITAR_H

#include <string>
using namespace std;

class Guitar {
private:
	string color;
	int strings;
	string name;
	string modelname;
	string* accessories;

public:

	Guitar();

		Guitar(string color, int strings, string name, string modelname);

	
	void SetColor(string color);
	void SetStrings(int strings);
	void SetName(string name);
	void SetModelName(string modelname);
	void SetAccessories(string* accessories);

	
	string GetColor();
	int GetStrings();
	string GetName();
	string GetModelName();
	string* GetAccessories();

	// Ä³¿
	void Play();
	void OutOfTune();
	void Tuned();
};

#endif
