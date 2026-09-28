#include <iostream>
#include <string>
#include <exception>
using namespace std;


class ArraySizeException : public exception {
public:
    const char* what() const noexcept override {
        return "array must be 4x4";
    }
};


class ArrayDataException : public exception {
    string msg;
public:
    ArrayDataException(int r, int c) {
        msg = "bad data from" + to_string(r) + "to" + to_string(c);
    }
    const char* what() const noexcept override {
        return msg.c_str();
    }
};


class ArrayValueCalculator {
public:
    static int doCalc(const string* const* arr, int r, int c) {
        if (r != 4 || c != 4) {
            throw ArraySizeException();
        }

        int sum = 0;
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                try {
                    sum += stoi(arr[i][j]);
                }
                catch (...) {
                    throw ArrayDataException(i, j);
                }
            }
        }
        return sum;
    }
};



int main() {
    
    string data[4][4] = {
        {"1", "2", "3", "4"},
        {"5", "6", "7", "8"},
        {"9", "10", "11", "12"},
        {"13", "14", "15", "16"}
    };

   
    string* ptrs[4] = { data[0], data[1], data[2], data[3] };


    try {
        int result = ArrayValueCalculator::doCalc(ptrs, 4, 4);
        cout << "result: " << result << endl;
    }

    catch (const ArraySizeException& e) {
        cerr << e.what() << endl;
    }

    catch (const ArrayDataException& e) {
        cerr << e.what() << endl;
    }

    return 0;
}