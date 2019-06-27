#pragma once
#include "passengernode.h"

class __declspec(dllexport) passengerlist
{
protected:
	passengernode* root;
public:
	passengernode* getroot() const;
	void setroot(passengernode* src);

	passengernode* Search(string src);
	void Add(string CMND_, string name_, string surname_, string sex_);

	void input(ifstream& inp);
	void save(ofstream& out);
	void Savenode(ofstream& out, passengernode* it);

	passengerlist();
	~passengerlist();
};

