#pragma once
#include <string>
#include <fstream>
using namespace std;

class __declspec(dllexport) ticket
{
protected:
	int serial;
	string CMND;
public:
	int getserial() const;
	string getCMND() const;

	void setserial(int src);
	void setCMND(string src);

	void save(ofstream& out);

	ticket();
	ticket(int serial_, string CMND_);
	~ticket();
};

