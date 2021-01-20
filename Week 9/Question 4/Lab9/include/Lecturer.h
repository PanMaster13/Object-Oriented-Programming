#ifndef LECTURER_H
#define LECTURER_H
#include <string>
#include <iostream>
#include "Course.h"
#include "Person.h"

using namespace std;

class Lecturer:public Person
{
    public:
        Lecturer(string name, string email, Course * course);
        virtual ~Lecturer();
        Course * getCourse();
        void display();

    protected:

    private:
        Course * _course;
};

#endif // LECTURER_H
