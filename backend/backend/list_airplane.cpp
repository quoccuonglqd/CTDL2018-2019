#include "stdafx.h"
#include "list_airplane.h"



airplane * list_airplane::FindID(string A)
{
	airplane* p = nullptr;
	for (int i = 0; i < this->num_airplane; i++)
		if (A.compare(list[i].get_id()) == 0)
		{
			p = &list[i];
			break;
		}
	return p;
}



void list_airplane::Add(string id, string type, int chair, int flight)
{
	string ID;
	bool flag = true;
	this->num_airplane++;
	list[this->num_airplane - 1].set_nChair(chair);
	list[this->num_airplane - 1].set_nFlight(flight);
	list[this->num_airplane - 1].set_type_plane(type);
	list[this->num_airplane - 1].set_id(id);
}

void list_airplane::Delete(string A)
{
	int i;
	for (i = 0; i < this->num_airplane; i++)
		if (A.compare(list[i].get_id()) == 0)
			break;
	for (; i < this->num_airplane; i++)
		list[i] = list[i + 1];
	this->num_airplane--;
}


void list_airplane::Change(string Id, airplane src)
{
	int j;
	for (j = 0; j < this->num_airplane; j++)
	{
		if (Id.compare(list[j].get_id()) == 0)
		{
			list[j] = src;
			break;
		}
	}
}

bool list_airplane::checkID(string A, int n)
{
	for (int i = 0; i < n; i++)
		if (A.compare(list[i].get_id()) == 0)
			return true;
	return false;
}

void list_airplane::Sort()
{
	sort(list, list + num_airplane, [](airplane x, airplane y) {
		return x.get_nFlight() > y.get_nFlight();
	});
}


void list_airplane::save(ofstream & out)
{
	out << this->num_airplane;
	for (int i = 0; i < num_airplane; i++)
		list[i].save(out);
}

void list_airplane::read(ifstream & in)
{
	in >> num_airplane;
	for (int i = 0; i < this->num_airplane; i++)
		list[i].read(in);
}

int list_airplane::getnum_airplane() const
{
	return num_airplane;
}

airplane list_airplane::getairplane(int id) const
{
	return list[id];
}

void list_airplane::setnum_airplane(int src)
{
	num_airplane = src;
}

void list_airplane::setairplane(int id, airplane src)
{
	list[id] = src;
}

list_airplane::list_airplane()
{
	this->num_airplane = 0;
}


list_airplane::~list_airplane()
{
}