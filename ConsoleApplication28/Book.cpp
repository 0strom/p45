#include "Book.h"
#include <iostream>
using namespace std;

Book::Book() : Book("White", 100, "Untitled") {
	authors = nullptr;
}
Book::Book(string color, int pages, string name)
	: color(color), pages(pages), name(name) {
	authors = nullptr;
}
Book::~Book() {
	delete[] authors;
}



void Book::SetColor(string color) {
	this->color = color;
}
void Book::SetPages(int pages) {
	if (pages > 0 && pages <= 10000)
		this->pages = pages;
}
void Book::SetName(string name) {
	this->name = name;
}
void Book::SetAuthors(string* authors) {
	this->authors = authors;
}


string Book::GetColor() {
	return color;
}


int Book::GetPages() {
	return pages;
}
string Book::GetName() {
	return name;
}
string* Book::GetAuthors() {
	return authors;
}




void Book::Read() {
	cout << name << " is being read...\n";
}
void Book::Buy() {
	cout << "New book - " << name << " - is bought\n";
}
void Book::Finish() {
	cout << name << " is finished, go buy a new one!\n";
}