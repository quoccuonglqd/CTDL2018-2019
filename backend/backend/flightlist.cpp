#include "stdafx.h"
#include "flightlist.h"

flight_node * flightlist::getstart() const
{
	return start;
}

void flightlist::setstart(flight_node * src)
{
	start = src;
}

void flightlist::Insert(flight_node* ptr)
{
	flight_node* tmp = start;
	start = ptr;
	start->setnext(tmp);
}

flight_node * flightlist::Search(string serial_)
{
	flight_node* it = start;
	while (it != nullptr)
	{
		if (it->getserial() == serial_)
			return it;
		it = it->getnext();
	}
	return nullptr;
}

void flightlist::input(ifstream & inp, ifstream & inp_)
{
	string str, a, b, c, e;
	int d;
	getline(inp, str);
	getline(inp_, str);
	while (getline(inp, str))
	{
		inp.ignore();
		getline(inp, str);
		inp >> a >> b >> c >> str >> e;
		d = (str[0] == 'F' ? 0 : (str[0] == 'T' ? 1 : (str[1] == 'l' ? 2 : 3)));
		flight_node* ptr = new flight_node(a, b, c, e);
		ptr->setstate(d);
		inp_.ignore();
		getline(inp_, str);
		ticketlist* ptr_ = new ticketlist();
		ptr_->input(inp_);
		ptr->setTk(ptr_);
		Insert(ptr);
		inp.ignore();
	}
}

void flightlist::save(ofstream & out, ofstream & out_)
{
	out << "Format data: <Flight serial> <Depart time> <Destination> <Flight state> <Plane serial of the flight>";
	out_ << "Format data: <Ticket number> <Identity card>";
	flight_node* it = start;
	while (it != nullptr)
	{
		it->save(out, out_);
		it = it->getnext();
	}
}

flightlist::flightlist()
{
	start = nullptr;
}


flightlist::~flightlist()
{
}

