using CC_Struct_Exception_Lesson14;

int x = 5;
int x2 = 5;
Console.WriteLine(x == x2);
ComparisionTypes ct1 = new ComparisionTypes();
ComparisionTypes ct2 = null;
bool theyEquals = ct1.Equals(ct2);

object.Equals(ct1, ct2);




Chef chef = new Chef();
Waiter waiter = new Waiter("ran",chef);
Waiter waiter1 = new Waiter("dano", chef);
Client c = new Client(waiter);

c.OrderDish(Dishes.Falafel);
c.OrderDish(Dishes.Falafel);
c.OrderDish(Dishes.Falafel);

int i = new int();
Console.WriteLine(i);
bool b = new bool();

Waiter w;
//w.Name = ""
MyFirstStruct myFirstStruct = new MyFirstStruct();

Console.WriteLine(myFirstStruct.myType);
myFirstStruct.myType = "";
//Console.WriteLine(myFirstStruct.MyProp);

int myInt = 5;
int myInt2 = myInt;
GetInt(myInt);
GetStruct(myFirstStruct);


Point p1 = new Point();
ref Point p2 = ref p1;
int myIntWithRef = new int();
ref int myIntWithRef2 = ref myIntWithRef;

static void GetInt(int i)
{
    i += 100;
}
static void GetStruct(MyFirstStruct firstStruct)
{
    firstStruct.MyProp = 10;
}