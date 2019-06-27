#include "stdafx.h"
#include "passenger.h"



passenger::passenger()
{
}


passenger::~passenger()
{
}

string passenger::getCMND() const
{
	return CMND;
}

string passenger::getname() const
{
	return name;
}

string passenger::getsurname() const
{
	return surname;
}

Sex passenger::getsex() const
{
	return sex;
}

void passenger::setCMND(string src)
{
	CMND = src;
}

void passenger::setname(string src)
{
	name = src;
}

void passenger::setsurname(string src)
{
	surname = src;
}

void passenger::setsex(Sex src)
{
	sex = src;
}

void passenger::input(ifstream & inp)
{
	string str;
	inp >> CMND >> name >> surname >> str;
	if (str == "male")
		sex = male;
	else sex = female;
}

void passenger::save(ofstream & out)
{
	string str = (sex == male ? "male" : "female");
	out << '\n' << CMND << ' ' << name << ' ' << surname << ' ' << str;
}
