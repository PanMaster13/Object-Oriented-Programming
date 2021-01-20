#ifndef PERSON_H
#define PERSON_H
#include <iostream>
#include <string>

using namespace std;

class Person
{
    public:
        Person();
        Person(string name, string email);
        virtual ~Person();
        string getName();
        string getEmail();
        virtual void display();

    protected:
        string _name;
        string _email;

    private:
};

#endif // PERSON_H
