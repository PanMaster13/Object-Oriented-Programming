#ifndef COURSE_H
#define COURSE_H
#include <string>
#include <iostream>

using namespace std;

class Course
{
    public:
        Course(string name, int duration);
        virtual ~Course();
        string getName();
        int getDuration();

    protected:

    private:
        string _name;
        int _duration;
};

#endif // COURSE_H
