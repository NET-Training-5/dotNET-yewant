class A
{
    public int x;
}

// Single Inheritance
class B: A      //B inherits from A, B is of type A, A is parent of B
{
    public int y;
}

// Multilevel inheritance
class C: B
{
    public int z;
}

// Multiple inheritance
interface ID
{

}

interface IF
{

}

class E: B, ID, IF
{

}