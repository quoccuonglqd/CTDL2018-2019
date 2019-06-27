#pragma once
#include <string>
#include <fstream>
using namespace std;

__declspec(dllexport) enum Sex { male, female };

class __declspec(dllexport) passenger
{
protected:
	string CMND;
	string name;
	string surname;
	Sex sex;
public:
	string getCMND() const;
	string getname() const;
	string getsurname() const;
	Sex getsex() const;

	void setCMND(string src);
	void setname(string src);
	void setsurname(string src);
	void setsex(Sex src);

	void input(ifstream& inp);
	void save(ofstream& out);
	passenger();
	~passenger();
};

