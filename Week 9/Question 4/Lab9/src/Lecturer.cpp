#include "Lecturer.h"

Lecturer::Lecturer(string name, string email, Course * course)
{
    _name = name;
    _email = email;
    _course = course;
}


Lecturer::~Lecturer()
{}

Course * Lecturer::getCourse(){
    return _course;
}

void Lecturer::display(){
    cout << "Name: " << _name << "\tEmail: " << _email << endl;
    cout << "Course: " << _course->getName() << " ( Duration: " << _course->getDuration() << "  )" << endl;
}
