#pragma once

#include <iostream>
#include <string>

using namespace std;

//This class is an abstract class with no usage other than being a parent class
class Member {
protected:
	int _studID;
	string _name;
	string _course;
	int _contNo;

public:
	Member(int studID, string name, string course, int contNo);
	int getStudID();
	string getName();
	string getCourse();
	int getContNo();
};