#include "stdafx.h"
#include "flight_node.h"



flight_node* flight_node::getnext() const
{
	return next;
}

void flight_node::setnext(flight_node * src)
{
	next = src;
}

flight_node::flight_node()
{
	next = nullptr;
}


flight_node::~flight_node()
{
}

