#pragma once
#include "ticketlist.h"

class __declspec(dllexport) flight
{
protected:
	string serial;
	string depart_time;
	string destination;
	int state;
	string plane_serial;
	ticketlist* Tk;
public:
	string getserial() const;
	string getdepart_time() const;
	string getdestination() const;
	int getstate() const;
	string getplane_serial() const;
	ticketlist* getTk() const;

	void setserial(string src);
	void setdepart_time(string src);
	void setdestination(string src);
	void setstate(int src);
	void setplane_serial(string src);
	void setTk(ticketlist* src);

	void save(ofstream& out, ofstream& out_);

	flight();
	flight(string a, string b, string c, string e);
	~flight();
};

