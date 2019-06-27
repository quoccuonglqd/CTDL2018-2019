#include "stdafx.h"
#include "ticketlist.h"

ticket_node * ticketlist::getstart() const
{
	return start;
}

void ticketlist::setstart(ticket_node * src)
{
	start = src;
}

int ticketlist::getlen() const
{
	return len;
}

void ticketlist::setlen(int src)
{
	len = src;
}


void ticketlist::save(ofstream & out)
{
	ticket_node* it = start;
	while (it != nullptr)
	{
		it->save(out);
		it = it->getnext();
	}
}

void ticketlist::input(ifstream & inp)
{
	string str;
	while (inp >> str)
	{
		if (str[0] == '=')
			break;
		int a = stoi(str);
		inp >> str;
		ticket_node* ptr = new ticket_node();
		ptr->setserial(a);
		ptr->setCMND(str);
		Insert(ptr);
	}
}

void ticketlist::Insert(ticket_node* ptr)
{
	ticket_node* tmp = start;
	start = ptr;
	start->setnext(tmp);
	len++;
}

bool ticketlist::Searchid(int id)
{
	ticket_node* it = start;
	while (it != nullptr)
	{
		if (it->getserial() == id)
			return true;
		it = it->getnext();
	}
	return false;
}

bool ticketlist::SearchCMND(string CMND)
{
	ticket_node* it = start;
	while (it != nullptr)
	{
		if (it->getCMND()== CMND)
			return true;
		it = it->getnext();
	}
	return false;
}

ticketlist::ticketlist()
{
	start = nullptr;
	len = 0;
}


ticketlist::~ticketlist()
{
}

