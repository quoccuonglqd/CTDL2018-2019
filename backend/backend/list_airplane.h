#pragma once
#include"airplane.h"
#include <algorithm>

#define MAX_AIRPLANE 1000
class __declspec(dllexport) list_airplane
{
protected:
	int num_airplane = 0;
	airplane list[MAX_AIRPLANE];
public:
	int getnum_airplane() const;
	airplane getairplane(int id) const;

	void setnum_airplane(int src);
	void setairplane(int id, airplane src);

	void Add(string id, string type, int chair, int flight);
	void Delete(string A);
	void Change(string Id, airplane src);
	bool checkID(string A, int n);
	void Sort();

	void save(ofstream& out);
	void read(ifstream& in);
	airplane* FindID(string A);

	list_airplane();
	virtual ~list_airplane();

};

