#include <iostream>


class Node
{
public:
	int value; //Any type
	Node* next;
	Node* prev;
	Node(int val){
		std::cout << "Node constructor!" << std::endl;
		this->value = val;
		this->next = (Node*)0;
		this->prev = (Node*)0;
	}
	~Node(){
		std::cout << "Node destructor" << std::endl;
		std::cout << "I had the value " << this->value << std::endl;
	}
};
class List
{

public:
	Node* head;
	Node* tail;

	List(){
		std::cout << "List Constructor!" << std::endl;
		this->head = 0;
		this->tail = 0;
	}
	~List(){
		std::cout << "List destructor!" << std::endl;
		Node* temp;
		while (head != 0) {
			temp = head->next;
			delete head;
			head = temp;
		}
		std::cout << "List destructed!" << std::endl;

	}
	void insert(Node* n, Node* x){
		//Not actually perfect: how do we prepend to an existing list?
		if (n != 0){
			x->next = n->next;
			n->next = x;
			x->prev = n;
			if (x->next != 0)
				x->next->prev = x;
		}
		if (this->head == 0){
			this->head = x;
			this->tail = x;
			x->prev = 0;
			x->next = 0;
		}
		else if (this->tail == n){
			this->tail = x;
		}
	}
	bool remove(Node* n) {
		if (n != 0 && this->head != n && this->tail != n) {
			std::cout << "Remove node" << std::endl;
			n->next->prev = n->prev;
			n->prev->next = n->next;
			return true;
		}
		if (this->head == n) {
			std::cout << "Remove head" << std::endl;
			this->head = n->next;
			n->next->prev = 0;
			return true;
		}
		else if (this->tail == n) {
			std::cout << "Remove tail" << std::endl;
			this->tail = n->prev;
			n->prev->next = 0;
			return true;
		}
		return false;
	}
	void display(){
		Node* i = this->head;
		std::cout << "List: ";
		while (i != 0){
			std::cout << i->value << ",";
			i = i->next;
			}
		std::cout << std::endl;
	}
};

int main(int argc, char *argv[])
{
	List* l = new List();
	Node* a = new Node(8);
	l->insert(l->head, new Node(4));
	l->insert(l->head, new Node(6));
	l->insert(l->head, a);
	l->display();
	l->remove(l->tail);
	l->display();
	delete l;
	getchar();
	return 0;
}