#pragma once
#include "flight.h"

class __declspec(dllexport) flight_node :public flight
{
protected:
	flight_node* next;
public:
	flight_node* getnext() const;
	void setnext(flight_node* src);

	flight_node();
	flight_node(string a, string b, string c, string e) :flight(a, b, c, e) { next = nullptr; }
	~flight_node();
};

