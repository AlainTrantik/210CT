#include <iostream>

//Nodes and lists use public data members for convenience
//This may make some software engineers froth at the mouth

class Node
{
public:
	int value; //This could really be any type
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
		this->prev=NULL;
		this->next=NULL;
		this->value = NULL;
	}
};
class List
{

public:
	Node* head;
	Node* tail;

	List(){
		std::cout << "List Constructor!" << std::endl;
		this->head = NULL;
		this->tail = NULL;
	}
	~List(){
		std::cout << "List destructor!" << std::endl;
	}
	void insert(Node* n, Node* x){
		if (n != NULL){
			x->next = n->next;
			n->next = x;
			x->prev = n;
			if (x->next != 0)
				x->next->prev = x;
		}
		if (this->head == NULL){
			this->head = x;
			this->tail = x;
			x->prev = NULL;
			x->next = NULL;
		}
		else if (this->tail = n){
			this->tail = x;
		}
	}
	void display(){
		Node* i = this->head;
		std::cout << "List: ";
		while (i != NULL){
			std::cout << i->value << ",";
			i = i->next;
		}
		std::cout << std::endl;
	}
};

int main(int argc, char *argv[])
{
	List* l = new List();
	Node* a = new Node(4);
	l->insert(NULL, a);
	l->insert(l->head, new Node(6));
	l->insert(l->head, new Node(8));
	l->display();
	delete a;
	getchar();
	return 0;
}