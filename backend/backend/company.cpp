#include "stdafx.h"
#include "company.h"
#include <vector>



flightlist * company::getFlightlist() const
{
	flightlist* ptr = (flightlist*)(&Flightlist);
	return ptr;
}

list_airplane * company::getAirplanelist() const
{
	list_airplane* ptr = (list_airplane*)(&Airplanelist);
	return ptr;
}

passengerlist * company::getPassengerlist() const
{
	passengerlist* ptr = (passengerlist*)(&Passengerlist);
	return ptr;
}

void company::addairplane(string a, string b, int c)
{
	Airplanelist.Add(a, b, c, 0);
}

void company::deleteairplane(string a)
{
	Airplanelist.Delete(a);
}

void company::changeairplane(string a, string b, int c)
{
	airplane tmp(a, b, c);
	Airplanelist.Change(a, tmp);
}

void company::addflight(string a, string b, string c, string e)
{
	flight_node* ptr = new flight_node(a, b, c, e);
	Flightlist.Insert(ptr);
	airplane* element = Airplanelist.FindID(e);
	element->set_nFlight(element->get_nFlight() + 1);
}

void company::Changeflightdepart(string a, string src)
{
	flight_node* ptr = Flightlist.Search(a);
	ptr->setdepart_time(src);
}

void company::Denyflight(string a)
{
	flight_node* ptr = Flightlist.Search(a);
	ptr->setstate(0);
}

void company::bookticket(string a, int id, string cmnd, string name, string surname, string sex)
{
	passengernode* ptr = Passengerlist.Search(cmnd);
	if (ptr == nullptr)
		Passengerlist.Add(cmnd, name, surname, sex);
	flight_node* ptr_ = Flightlist.Search(a);
	ticket_node* ele = new ticket_node(id, cmnd);
	ptr_->getTk()->Insert(ele);
	airplane* ptr__ = Airplanelist.FindID(ptr_->getplane_serial());
	if (ptr_->getTk()->getlen() == ptr__->get_nChair())
		ptr_->setstate(2);
}

void company::passengerinfo_of_flight(string Id)
{
	flight_node* ptr = Flightlist.Search(Id);
	int cnt = 0;
	string ret = "";
	ret += ptr->getdepart_time() + " " + ptr->getdestination() + " ";
	ticket_node* it = ptr->getTk()->getstart();
	while (it != nullptr)
	{
		passengernode* element = Passengerlist.Search(it->getCMND());
		string str = (element->getsex() == male ? "Nam" : "Nữ");
		ret += to_string(++cnt) + " " + to_string(it->getserial()) + " " + element->getCMND() + " " + element->getsurname() + " " + element->getname() + " " + str + " ";
		it = it->getnext();
	}
	ofstream out("output1.txt");
	out << ret;
	out.close();
}

void company::flightinfo(string a, string b)
{
	string ret = "";
	flight_node* it = Flightlist.getstart();
	while (it != nullptr)
	{
		airplane* ptr = Airplanelist.FindID(it->getplane_serial());
		if (it->getTk()->getlen() < ptr->get_nChair() && it->getdepart_time() == a && it->getdestination() == b)
			ret += it->getserial() + " " + to_string(ptr->get_nChair() - it->getTk()->getlen()) + " ";
		it = it->getnext();
	}
	ofstream out("output2.txt");
	if (ret == "") ret = "not";
	out << ret;
	out.close();
}

void company::availticket_info(string x)
{
	vector<int> vt;
	string ret = "";
	flight_node* ptr = Flightlist.Search(x);
	ticket_node* it = ptr->getTk()->getstart();
	while (it != nullptr)
	{
		vt.push_back(it->getserial());
		it = it->getnext();
	}
	airplane* ptr_ = Airplanelist.FindID(ptr->getplane_serial());
	vt.push_back(ptr_->get_nChair() + 1);
	sort(vt.begin(), vt.end());
	int id = 1;
	for (auto x : vt)
	{
		for (; id < x; id++)
			ret += to_string(id) + " ";
		id = x + 1;
	}
	if (ret == "") ret = "not";
	ofstream out("output3.txt");
	out << ret;
	out.close();
}

void company::Flightinfo()
{
	string ret = "";
	for (int i = 0; i < Airplanelist.getnum_airplane(); i++)
		ret += Airplanelist.getairplane(i).get_id() + " " + to_string(Airplanelist.getairplane(i).get_nFlight()) + " " ;
	ofstream out("output4.txt");
	out << ret;
	out.close();
}

void company::getdatafromfile(string Airplane, string Flight, string Ticket, string Passenger)
{
	ifstream Airplane_(Airplane);
	ifstream Flight_(Flight);
	ifstream Ticket_(Ticket);
	ifstream Passenger_(Passenger);

	Airplanelist.read(Airplane_);
	Flightlist.input(Flight_, Ticket_);
	Passengerlist.input(Passenger_);
}

void company::saveintofile(string Airplane, string Flight, string Ticket, string Passenger)
{
	ofstream Airplane_(Airplane);
	ofstream Flight_(Flight);
	ofstream Ticket_(Ticket);
	ofstream Passenger_(Passenger);

	Airplanelist.save(Airplane_);
	Flightlist.save(Flight_, Ticket_);
	Passengerlist.save(Passenger_);

	Airplane_.close();
	Flight_.close();
	Ticket_.close();
	Passenger_.close();
}

bool company::check_ticket_booked(string a, int id)
{
	flight_node* ptr = Flightlist.Search(a);
	if (ptr->getTk() == nullptr) return false;
	return ptr->getTk()->Searchid(id);
}

bool company::check_CMND_booked(string a, string cmnd)
{
	flight_node* ptr = Flightlist.Search(a);
	if (ptr->getTk() == nullptr) return false;
	return ptr->getTk()->SearchCMND(cmnd);
}

bool company::check_plane_exist(string a)
{
	return (Airplanelist.FindID(a)!=nullptr);
}

bool company::check_flight_exist(string a)
{
	return (Flightlist.Search(a) != nullptr);
}

company::company()
{
}


company::~company()
{
}

