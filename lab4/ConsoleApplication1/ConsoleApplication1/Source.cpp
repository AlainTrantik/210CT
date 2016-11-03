#include <iostream>
#include <vector>

using namespace std;

//Use a vector of ints to represent a tower
typedef vector<int> tower;

tower a, b, c;

void display(){
	cout << "[ ";
	for (int i = 0; i<a.size(); i++)
		cout << a[i] << " ";
	cout << "]    [ ";
	for (int i = 0; i<b.size(); i++)
		cout << b[i] << " ";
	cout << "]    [ ";
	for (int i = 0; i<c.size(); i++)
		cout << c[i] << " ";
	cout << "] ";
	cout << endl;
}


void solveHanoi(int disks, tower& src, tower& dst, tower& spr){
	if (disks == 1){
		int tmp = src.back();
		dst.push_back(tmp);
		src.pop_back();
		display();
	}
	else{
		solveHanoi(disks - 1, src, spr, dst);
		dst.push_back(src.back());
		src.pop_back();
		display();
		solveHanoi(disks - 1, spr, dst, src);
	}
}


int main(int argc, char *argv[])
{

	a.push_back(3);
	a.push_back(2);
	a.push_back(1);
	display();
	solveHanoi(3, a, c, b);
	getchar();
	return 0;
}