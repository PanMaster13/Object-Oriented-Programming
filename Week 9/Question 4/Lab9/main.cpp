#include <iostream>
#include "person.h"
#include "Course.h"
#include "Lecturer.h"

using namespace std;

int main()
{

    Course * cs = new Course("Computer Science", 3);
    Lecturer * lect1 = new Lecturer("Ong", "cong@swinburne.edu.my", cs);
    lect1->display();
    return 0;
}
