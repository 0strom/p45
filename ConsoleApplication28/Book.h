#ifndef BOOK_H
#define BOOK_H

#include <string>
using namespace std;

class Book {
private:
	string color;
	int pages;
	string name;
	string* authors;

public:
	Book();
	Book(string color, int pages, string name);

	~Book();
	void SetColor(string color);
	void SetPages(int pages);
	void SetName(string name);
	void SetAuthors(string* authors);

	
	string GetColor();
	int GetPages();
	string GetName();
	string* GetAuthors();



	void Read();
	void Buy();
	void Finish();
};

#endif 
