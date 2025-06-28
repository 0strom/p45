#ifndef BOOK_H
#define BOOK_H

#include <string>
using namespace std;

class Book {
private:
	string color;
	int pages = 10;
	string name;

public:
	void SetColor(string c);
	void SetPages(int p);
	void SetName(string n);

		string GetColor();
	int GetPages();
	string GetName();

	void Read();
	void Buy();
	void Finish();
};

#endif
