
using CSharpBasicsAssignment;
//CreateRunTypesDemo();
//RunValueVsReferenceDemo();
var numberArray = new int[] { 4, 1, 2, 1, 2 ,4,23};
Console.WriteLine(SingleNumber(numberArray));
void CreateRunTypesDemo()
{
    
    Console.WriteLine("PartB==>Variables and Types");

    int myInt = 10;
    long myLong = 100000L;
    double myDouble = 10.5;
    decimal myDecimal = 99.99m;
    bool myBool = true;
    char myChar = 'A';
    string myString = "Hello";
    var myVar = 20;

    Console.WriteLine($"{myInt} - {myInt.GetType()}");
    Console.WriteLine($"{myLong} - {myLong.GetType()}");
    Console.WriteLine($"{myDouble} - {myDouble.GetType()}");
    Console.WriteLine($"{myDecimal} - {myDecimal.GetType()}");
    Console.WriteLine($"{myBool} - {myBool.GetType()}");
    Console.WriteLine($"{myChar} - {myChar.GetType()}");
    Console.WriteLine($"{myString} - {myString.GetType()}");
    Console.WriteLine($"{myVar} - {myVar.GetType()}");
    //////////////////////////////////////////////////////////////////////////////////
    int number = 10;
    long longNumber = number;
    char Acrc = 'a';
    int intArc = Acrc;
    Console.WriteLine($"(Implict)===> convert from int to long: {longNumber}. cast from char to int {intArc}");       // the convert implict succed because the long bigger than int && int convert letter to number 
      //////////////////////////////////////////////////////////////////////////////////
    double price = 12.4;
    int intprice = (int)price;
    int convertResult = Convert.ToInt32(number);
    Console.WriteLine($"(Explcit )===> convert from double to int: {intprice}. cast to from char to int {convertResult}");       //intprice is (Truncation) , convertResult is (Rounding)
      //////////////////////////////////////////////////////////////////////////////////
    int divisionAsInt = 5 / 2;
    double divisionAsDouble = 5.0 / 2;
    Console.WriteLine($"compute division by int & double: division on int {divisionAsInt}. division on double {divisionAsDouble}");         //int print the Truncation Number & double print the Rounding Number
      //////////////////////////////////////////////////////////////////////////////////
    int boxing1 = 20;
    object unboxing1 = boxing1;
    Console.WriteLine($"convert from boxing to unboxing  {unboxing1}.");
    object unboxing2 = 34;
    int boxing2 = (int)unboxing2;
    Console.WriteLine($"convert from unboxing to boxing  {boxing2}.");
    //////////////////////////////////////////////////////////////////////////////////
    string NumberString = "42";
    Console.WriteLine($"convert from string to int   {int.Parse(NumberString)}.");
    string Letters = "Abc";
    var result = int.TryParse(Letters, out int intLetters);
    if (!result)
    {
        Console.WriteLine($"The operation failed {result}");
    }
    Console.WriteLine($"convert from string to int by using tryParse {result}");
    //////////////////////////////////////////////////////////////////////////////////
    float num = 10.5f;
    decimal num1 = (decimal)num; // no implicit convert because the c# It is considered explicit convert
    Console.WriteLine($"The result from (Float==>decimal) is {num1}");

}

void RunValueVsReferenceDemo()
{
    var p1 = new Point { X = 1, Y = 2 };
    var p2 = p1;
    p2.X = 99;
    Console.WriteLine($"{p1.X}=======================>{p2.X}");// the p1=1 & p2=99 ,because the struct is valuetype so the p2 copy value 
}
Order o1 = new Order
{
    OrderId = 1,
    CustomerName = "Omar",
    Quantity = 3,
    UnitPrice = 100m,
    TotalPrice = 0m,
    IsPaid = false,
    DiscountPercent = 10,
    ShippingCity = "Menoufia",
    Priority = 'H',
    ItemCode = 123456L
};

o1.CalculateTotal();

Order o2 = o1;

o2.IsPaid = true;

Console.WriteLine($"o1.IsPaid: {o1.IsPaid}");// Order is a reference type.
                                             // o1 and o2 point to the same Order object in the heap.
Console.WriteLine($"o2.IsPaid: {o2.IsPaid}");

object boxedOrder = o1;
Order o3 = (Order)boxedOrder;
Console.WriteLine(object.ReferenceEquals(o1, o3));
o2.PrintSummary();//o1&o2 refferent same objct so when the o2 any filed change the o1 too change 


// Value types store their actual values in stack , while reference types store a reference  on the heap.
// Assignment copies the actual value for value types, but copies the reference for reference types.
// Therefore, two reference variables can point to the same object on the heap.
// Storing a reference type in an object variable does not create a new object; it only stores another reference to the same object.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int SingleNumber(int[]nuns)
{
    int result = 0;
    for (int i = 0; i < nuns.Length; i++)
    {
        result ^= nuns[i];
    }
    return result;
}
