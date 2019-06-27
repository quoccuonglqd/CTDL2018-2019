#include "stdafx.h"
#include "ticket.h"



int ticket::getserial() const
{
	return serial;
}

string ticket::getCMND() const
{
	return CMND;
}

void ticket::setserial(int src)
{
	serial = src;
}

void ticket::setCMND(string src)
{
	CMND = src;
}

void ticket::save(ofstream & out)
{
	out << '\n' << serial << "    " << CMND;
}

ticket::ticket()
{
}

ticket::ticket(int serial_, string CMND_)
{
	serial = serial_;
	CMND = CMND_;
}


ticket::~ticket()
{
}

