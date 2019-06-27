#include "stdafx.h"
#include "ticket_node.h"



ticket_node * ticket_node::getnext() const
{
	return next;
}

void ticket_node::setnext(ticket_node * src)
{
	next = src;
}

ticket_node::ticket_node()
{
	next = nullptr;
}


ticket_node::~ticket_node()
{
}

