#include "stdafx.h"
#include "passengernode.h"



passengernode * passengernode::getleft() const
{
	return left;
}

passengernode * passengernode::getright() const
{
	return right;
}

passengernode * passengernode::getpar() const
{
	return par;
}

void passengernode::setleft(passengernode * src)
{
	left = src;
}

void passengernode::setright(passengernode * src)
{
	right = src;
}

void passengernode::setpar(passengernode * src)
{
	par = src;
}

passengernode::passengernode()
{
	left = right = par = nullptr;
}


passengernode::~passengernode()
{
}

