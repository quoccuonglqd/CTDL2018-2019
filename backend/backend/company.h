#pragma once
#include "flightlist.h"
#include "list_airplane.h"
#include "passengerlist.h"


class __declspec(dllexport) company
{
protected:
	flightlist Flightlist;
	list_airplane Airplanelist;
	passengerlist Passengerlist;
public:
	flightlist* getFlightlist() const;
	list_airplane* getAirplanelist() const;
	passengerlist* getPassengerlist() const;

	void addairplane(string a, string b, int c);
	void deleteairplane(string a);
	void changeairplane(string a, string b, int c);

	void addflight(string a, string b, string c, string e);
	void Changeflightdepart(string a, string src);
	void Denyflight(string a);

	void bookticket(string a, int id, string cmnd, string name, string surname, string sex);

	void passengerinfo_of_flight(string Id);

	void flightinfo(string a, string b);

	void availticket_info(string x);

	void Flightinfo();

	void getdatafromfile(string Airplane, string Flight, string Ticket, string Passenger);
	void saveintofile(string Airplane, string Flight, string Ticket, string Passenger);

	bool check_ticket_booked(string a, int id);
	bool check_CMND_booked(string a, string cmnd);
	bool check_plane_exist(string a);
	bool check_flight_exist(string a);

	company();
	~company();
};

