#pragma once
#include "passenger.h"
class __declspec(dllexport) passengernode :public passenger
{
protected:
	passengernode* left;
	passengernode* right;
	passengernode* par;
public:
	passengernode* getleft() const;
	passengernode* getright() const;
	passengernode* getpar() const;

	void setleft(passengernode* src);
	void setright(passengernode* src);
	void setpar(passengernode* src);

	passengernode();
	~passengernode();
};

