#pragma once
#include "flight_node.h"

class __declspec(dllexport)  flightlist
{
protected:
	flight_node* start;
public:
	flight_node* getstart() const;
	void setstart(flight_node* src);

	void Insert(flight_node* ptr);
	flight_node* Search(string serial_);
	void input(ifstream& inp, ifstream& inp_);
	void save(ofstream& out, ofstream& out_);
	flightlist();
	~flightlist();
};

