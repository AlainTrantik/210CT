#include <iostream>
#include <stack>
using namespace std;



class BinTreeNode{
public:
	BinTreeNode(int value){
		this->value = value;
		this->left = NULL;
		this->right = NULL;
	}
	int value;
	BinTreeNode* left;
	BinTreeNode* right;

};
/*On part de la racine de l'arbre. On possède une valeur item que l'on souhaite insérer dans l'ABR. 
Si l'élément en cours n'existe pas, on insère item à cet emplacement. Sinon, on compare item à l'élément en cours. 
S'il a une valeur supérieure, on l'insère dans le sous-arbre droit, sinon, on l'insère dans le sous-arbre gauche (récursivité)...*/
BinTreeNode* tree_insert(BinTreeNode* tree, int item){
	if (tree == NULL)
		tree = new BinTreeNode(item);
	else
	if (item < tree->value)
	if (tree->left == NULL)
		tree->left = new BinTreeNode(item);
	else
		tree_insert(tree->left, item);
	else
	if (tree->right == NULL)
		tree->right = new BinTreeNode(item);
	else
		tree_insert(tree->right, item);
	return tree;

}

void postorder(BinTreeNode* tree){
	if (tree->left != NULL)
		postorder(tree->left);
	if (tree->right != NULL)
		postorder(tree->right);
	std::cout << tree->value << std::endl;
}

void in_order(BinTreeNode* tree){
	if (tree->left != NULL)
		in_order(tree->left);
	std::cout << tree->value << std::endl;
	if (tree->right != NULL)
		in_order(tree->right);
}
void in_order2(BinTreeNode* tree){
	stack<BinTreeNode*> S;
	BinTreeNode* current = tree;
	S.push(current);
	while (current != NULL && !S.empty()){
		if(current!=NULL)
			S.push(current);
		current = current->left;
		if (current == NULL){
			BinTreeNode* poped=S.top();
			S.pop();
			std::cout << poped->value << std::endl;
			current = poped->right;
		}
	}
}

int main(int argc, char *argv[])
{
	BinTreeNode* t = tree_insert(0, 6);
	tree_insert(t, 10);
	tree_insert(t, 5);
	tree_insert(t, 2);
	tree_insert(t, 3);
	tree_insert(t, 4);
	tree_insert(t, 11);
	in_order2(t);
	getchar();
	return 0;
}