#include <fstream>
#include <iostream>
using namespace std;


int main()
{
    const int size = 4096;
    char buffer[size] = {};
    ifstream in("file.html");


    if (in)
    {
        bool valid = true;

        while (!in.eof())
        {
             in.read(buffer, size);

             int count = in.gcount();


            for (int i = 0; i < count; i++)
            {

                if (buffer[i] == '<')

                {
                     bool found = false;

                    for (int j = i + 1; j < count; j++)
                    {
                        if (buffer[j] == '>')
                        {
                            found = true;
                            break;
                        }
                    }


                    if (!found)
                    {
                        valid = false;
                        break;
                    }
                }
            }

            if (!valid)
                break;
        }


        in.close();

        if (valid)
        {
            cout << "HTML is valid" << endl;
        }
        else
        {
            cout << "HTML isnt valid" << endl;
        }
    }

    else
    {
        cout << "Error1" << endl;
    }



    return 0;
}