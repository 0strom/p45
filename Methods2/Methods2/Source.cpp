#include <iostream>

#include "Bison.h"
#include "Wolf.h"
#include "Wildebeest.h"
#include "Lion.h"
#include "AnimalWorld.h"
using namespace std;

int main() {
   
    cout << "North America" << endl;

    AnimalWorld naWorld(new Bison(300.0), new Wolf(200.0));

    naWorld.ShowWorldInfo();
    naWorld.MealsHerbivores();         
    naWorld.NutritionCarnivores();     
    naWorld.ShowWorldInfo();

    cout << "Africa" << endl;


    AnimalWorld africaWorld(new Wildebeest(100.0), new Lion(110.0));

    africaWorld.ShowWorldInfo();
    africaWorld.MealsHerbivores();     
    africaWorld.NutritionCarnivores(); 
    africaWorld.ShowWorldInfo();

    return 0;
}