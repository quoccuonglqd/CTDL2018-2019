#pragma once
#include "ticket_node.h"

class __declspec(dllexport) ticketlist
{
protected:
	ticket_node* start;
	int len;
public:
	ticket_node* getstart() const;
	void setstart(ticket_node* src);

	int getlen() const;
	void setlen(int src);

	void save(ofstream& out);
	void input(ifstream& inp);
	void Insert(ticket_node* ptr);

	bool Searchid(int id);
	bool SearchCMND(string CMND);

	ticketlist();
	~ticketlist();
};

