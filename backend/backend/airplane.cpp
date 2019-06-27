#include "stdafx.h"
#include "airplane.h"


airplane::airplane()
{
	this->id = "";
	this->nChair = 0;
	this->nFlight = 0;
	this->type_plane = "";
}

string airplane::get_id()
{
	return this->id;
}

string airplane::get_type_plane()
{
	return this->type_plane;
}

int airplane::get_nChair()
{
	return this->nChair;
}

int airplane::get_nFlight()
{
	return this->nFlight;
}

void airplane::set_id(string ID)
{
	this->id = ID;
}

void airplane::set_type_plane(string type)
{
	this->type_plane = type;
}

void airplane::set_nChair(int n)
{
	this->nChair = n;
}

void airplane::set_nFlight(int nflight)
{
	this->nFlight = nflight;
}



void airplane::save(ofstream & file)
{
	file << "\n" << this->id << " ";
	file << this->type_plane << " ";
	file << this->nChair << " ";
	file << this->nFlight;
}

void airplane::read(ifstream & file)
{
	file >> this->id;
	file >> this->type_plane;
	file >> this->nChair;
	file >> this->nFlight;
}



airplane::~airplane()
{
}
