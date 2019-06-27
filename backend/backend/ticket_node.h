#pragma once
#include "ticket.h"
class __declspec(dllexport) ticket_node :public ticket
{
protected:
	ticket_node* next;
public:
	ticket_node* getnext() const;
	void setnext(ticket_node* src);
	ticket_node();
	ticket_node(int serial_, string CMND_) :ticket(serial_, CMND_), next(nullptr) {};
	~ticket_node();
};

