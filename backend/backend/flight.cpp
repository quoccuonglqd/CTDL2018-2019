#include "stdafx.h"
#include "flight.h"



void flight::setTk(ticketlist* src)
{
	Tk = src;
}

void flight::save(ofstream & out, ofstream& out_)
{
	out << "\n======================================================";
	out << "\nInformation of the flight " << serial;
	out_ << "\nTicket information of flight " << serial;
	string str;
	switch (state)
	{
	case 0:
	{
		str = "Flight_denied";
		break;
	}
	case 1:
	{
		str = "Ticket_available";
		break;
	}
	case 2:
	{
		str = "Clear_out_of_ticket";
		break;
	}
	case 3:
	{
		str = "Complete";
		break;
	}
	}
	out << '\n' << serial << " " << depart_time << " " << destination << " " << str << " " << plane_serial;
	if (Tk!=nullptr) Tk->save(out_);
	out_ << "\n==========================================";
}

flight::flight()
{
	state = 1;
	Tk = new ticketlist();
}

flight::flight(string a, string b, string c, string e)
{
	serial = a;
	depart_time = b;
	destination = c;
	state = 1;
	plane_serial = e;
	Tk = new ticketlist();
}


flight::~flight()
{
}

string flight::getserial() const
{
	return serial;
}

string flight::getdepart_time() const
{
	return depart_time;
}

string flight::getdestination() const
{
	return destination;
}

int flight::getstate() const
{
	return state;
}

string flight::getplane_serial() const
{
	return plane_serial;
}

ticketlist* flight::getTk() const
{
	return Tk;
}

void flight::setserial(string src)
{
	serial = src;
}

void flight::setdepart_time(string src)
{
	depart_time = src;
}

void flight::setdestination(string src)
{
	destination = src;
}

void flight::setstate(int src)
{
	state = src;
}


void flight::setplane_serial(string src)
{
	plane_serial = src;
}

