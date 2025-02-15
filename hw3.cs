#include <iostream>

using namespace std;
template <t number>
class number
{
public:
inarySearchTree( );
inarySearchTree( const BinarySearchTree & rhs );
inarySearchTree( BinarySearchTree && rhs );
~BinarySearchTree( );
bool isEmpty( ) const;
void printTree( ostream & out = cout ) const;
void insert( const index & x );
void remove( const index & x );
BinarySearchTree & operator=( const BinarySearchTree & rhs );
inarySearchTree & operator=( BinarySearchTree && rhs );
private:struct BinaryNode{
    index element;
    BinaryNode*left;
    BinaryNode*right;
    BinaryNode( const index & theElement, BinaryNode*lt, BinaryNode*rt ): element
    { theElement }, left{ lt }, right{ rt } { }
    BinaryNode( index && theElement, BinaryNode*lt, BinaryNode*rt ): element
    { std::move( theElement ) }, left{ lt }, right{ rt } { }};
    BinaryNode*root;
    void insert( const index & x, BinaryNode*&t);
    void remove( const index & x, BinaryNode*&t);
    bool contains( const index & x, BinaryNode*t ) const;
    void printTree( BinaryNode*t, ostream & out ) const;
    BinaryNode*clone( BinaryNode*t ) const;
    
};
    bool contains( const index& x ) const{
        return contains( x, root );}
    void insert( const index & x )
    {insert( x, root );}
    void remove( const index & x )
    {remove( x, root );}
    bool contains( const index & x, BinaryNode *t ) const
    {
        if( t == nullptr )
    return false;
    else if( x < t->element )
    return contains( x, t->left );
    else if( t->element < x )
    return contains( x, t->right );
    return true;    
int main(){
    return 0;
}