#include "stdafx.h"
#include "passengerlist.h"

passengernode * passengerlist::getroot() const
{
	return root;
}

void passengerlist::setroot(passengernode * src)
{
	root = src;
}

passengernode * passengerlist::Search(string src)
{
	passengernode* it = root;
	while (it != nullptr)
	{
		if (it->getCMND() == src)
			return it;
		if (it->getCMND() < src)
			it = it->getright();
		else it = it->getleft();
	}
	return it;
}

void passengerlist::Add(string CMND_, string name_, string surname_, string sex_)
{
	passengernode* tmp = Search(CMND_);
	if (tmp != nullptr) return;
	passengernode* ptr = new passengernode();
	ptr->setCMND(CMND_);
	ptr->setname(name_);
	ptr->setsurname(surname_);
	ptr->setsex(sex_ == "male" ? male : female);
	if (root == nullptr)
	{
		root = ptr;
		return;
	}
	passengernode* it = root;
	passengernode* prev = nullptr;
	while (it != nullptr)
	{
		prev = it;
		if (it->getCMND() < CMND_)
			it = it->getright();
		else
			it = it->getleft();
	}
	if (prev->getCMND() < CMND_)
		prev->setright(ptr);
	else
		prev->setleft(ptr);
	ptr->setpar(prev);
}

void passengerlist::input(ifstream & inp)
{
	string str, a, b, c, d;
	getline(inp, str);
	while (inp >> a)
	{
		inp >> b >> c >> d;
		Add(a, b, c, d);
	}
}

void passengerlist::save(ofstream & out)
{
	out << "Format data: <Identity number> <Name> <Surname> <Sex>";
	Savenode(out, root);
}

void passengerlist::Savenode(ofstream & out, passengernode * it)
{
	if (it == nullptr) return;
	it->save(out);
	Savenode(out, it->getleft());
	Savenode(out, it->getright());
}

passengerlist::passengerlist()
{
	root = nullptr;
}


passengerlist::~passengerlist()
{
}

