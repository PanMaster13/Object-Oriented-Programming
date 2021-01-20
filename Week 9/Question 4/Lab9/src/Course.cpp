#include "Course.h"

Course::Course(string name, int duration)
{
    _name = name;
    _duration = duration;
}

Course::~Course()
{
    //dtor
}

string Course::getName(){
    return _name;
}

int Course::getDuration(){
    return _duration;
}
