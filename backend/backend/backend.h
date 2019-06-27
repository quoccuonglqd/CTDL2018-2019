#pragma once
#include "company.h"
#include "cwchar"
#define EXPORT __declspec(dllexport)

extern "C" {

	extern EXPORT bool check_ticket_booked(company* object,const char* a, int id)
	{
		return object->check_ticket_booked(a, id);
	}

	extern EXPORT bool check_CMND_booked(company* object, const char* a, const char* cmnd)
	{
		return object->check_CMND_booked(a, cmnd);
	}

	extern EXPORT bool check_plane_exist(company* object, const char* a)
	{
		return object->check_plane_exist(a);
	}

	extern EXPORT bool check_flight_exist(company* object, const char* a)
	{
		return object->check_flight_exist(a);
	}

	extern EXPORT company* Create()
	{
		return new company;
	}

	extern EXPORT flightlist* getFlightlist(company* object)
	{
		return object->getFlightlist();
	}

	extern EXPORT list_airplane* getAirplanelist(company* object)
	{
		return object->getAirplanelist();
	}

	extern EXPORT passengerlist* getPassengerlist(company* object)
	{
		return object->getPassengerlist();
	}

	extern EXPORT void addairplane(company* object, const char* a, const char* b, int c)
	{
		object->addairplane(a, b, c);
	}

	extern EXPORT void deleteairplane(company* object,const char* a)
	{
		object->deleteairplane(a);
	}

	extern EXPORT void changeairplane(company* object, const char* a, const char* b, int c)
	{
		object->changeairplane(a, b, c);
	}

	extern EXPORT void addflight(company* object, const char* a, const char* b, const char* c, const char* e)
	{
		object->addflight(a, b, c, e);
	}

	extern EXPORT void Changeflightdepart(company* object, const char* a, const char* src)
	{
		object->Changeflightdepart(a, src);
	}

	extern EXPORT void Denyflight(company* object, const char* a)
	{
		object->Denyflight(a);
	}

	extern EXPORT void bookticket(company* object, const char* a, int id, const char* cmnd, const char* name, const char* surname, const char* sex)
	{
		object->bookticket(a, id, cmnd, name, surname, sex);
	}

	extern EXPORT void passengerinfo_of_flight(company* object, char* Id)
	{
		object->passengerinfo_of_flight(Id);

	}

	extern EXPORT void flightinfo(company* object, const char* a, const char* b)
	{
		object->flightinfo(a, b);
	}

	extern EXPORT void availticket_info(company* object, const char* x)
	{
		object->availticket_info(x);
	}

	extern EXPORT void Flightinfo(company* object)
	{
		object->Flightinfo();
	}

	extern EXPORT void getdatafromfile(company* object, const char* Airplane, const char* Flight, const char* Ticket, const char* Passenger)
	{
		object->getdatafromfile(Airplane,Flight,Ticket,Passenger);
	}

	extern EXPORT void saveintofile(company* object, const char* Airplane, const char* Flight, const char* Ticket, const char* Passenger)
	{
		object->saveintofile(Airplane, Flight, Ticket, Passenger);
	}
}