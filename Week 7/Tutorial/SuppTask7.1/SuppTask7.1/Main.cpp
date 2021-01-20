#include <iostream>
#include "clsUndergraduate.h"
#include "clsPostGraduate.h"
#include "TutorialClass.h"

using namespace std;

int main()
{
	//Printing in C++
	std::cout << "Checking Number and Details of Students in the Tutorial Class.....\n" << std::endl;

	//Creating Objects in C++
	TutorialClass *class1 = new TutorialClass;
	clsUndergraduate *student1 = new clsUndergraduate("King", "100067", "Eat Ass", "Science");
	clsPostgraduate *student2 = new clsPostgraduate("Ben", "100068", "Git Gud", "Guide in Gitting Gud", 5000);

	//Adding First Student in Tutorial Class
	class1->addStudent(student1);
	std::cout << "Current Student Count: " << class1->getStudentCount() << std::endl;
	class1->displayAll();

	//Adding Second Student in Tutorial Class
	class1->addStudent(student2);
	std::cout << "\nCurrent Student Count: " << class1->getStudentCount() << std::endl;
	class1->displayAll();

	//Deleting Objects in C++ (because it does not do it for you automatically, thus eating RAM)
	delete student1;
	delete student2;
	delete class1;

	//Getting input from User when Enter Key is pressed
	std::cin.get();
}