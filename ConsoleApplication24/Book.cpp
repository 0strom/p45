#include "Book.h"
#include <iostream>
using namespace std;

void Book::SetColor(string c) {
	color = c;
}

void Book::SetPages(int p) {
	if (p > 0 && p <= 10000)
		pages = p;
}

void Book::SetName(string n) {
	name = n;
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

void Book::Read() {
	cout << name << " is being read...\n";
}

void Book::Buy() {
	cout << "New book - " << name << " - is bought\n";
}

void Book::Finish() {
	cout << name << " is finished, go buy a new one!\n";
}h() { cout << name << " is finished, go buy a new one!\n"; }