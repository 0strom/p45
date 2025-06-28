#ifndef GUITAR_H
#define GUITAR_H

#include <string>
using namespace std;

class Guitar {
private:
	string color;
	int strings = 6;
	string name;
	string modelname;

public:
	void SetColor(string color);
	void SetStrings(int strings);
	void SetName(string name);
	void SetModelName(string modelname);

		string GetColor();
	int GetStrings();
	string GetName();
	string GetModelName();

	void Play();
	void OutOfTune();
	void Tuned();
};

#endif