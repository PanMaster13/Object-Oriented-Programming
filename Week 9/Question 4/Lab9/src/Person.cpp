#include "Person.h"

Person::Person(){}

Person::Person(string name, string email)
{
    _name = name;
    _email = email;
}

Person::~Person()
{
    //dtor
}

string Person::getName(){
    return _name;
}

string Person::getEmail(){
    return _email;
}

void Person::display(){
}
