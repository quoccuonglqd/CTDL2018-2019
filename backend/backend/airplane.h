#pragma once
#include<fstream>
#include<string>
using namespace std;
class __declspec(dllexport) airplane
{
protected:
	int nChair;
	int nFlight;
	string id;
	string type_plane;
public:
	string get_id();
	string get_type_plane();
	int get_nChair();
	int get_nFlight();

	void set_id(string ID);
	void set_type_plane(string type);
	void set_nChair(int n);
	void set_nFlight(int nflight);

	void save(ofstream& file);
	void read(ifstream& file);


	airplane();
	airplane(string a, string b, int c) :id(a), type_plane(b), nChair(c) { nFlight = 0; };
	virtual ~airplane();
};

