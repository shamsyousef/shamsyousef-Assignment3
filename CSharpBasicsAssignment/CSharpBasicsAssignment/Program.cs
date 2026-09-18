using CSharpBasicsAssignment;
using System.Drawing;
/*
.csproj:
Contains the project configuration, such as the target framework,
output type, package references, and compiler settings.

Program.cs:
The main source file where the application starts running.

obj/:
Contains temporary and intermediate files generated during the build process.

bin/:
Contains the final compiled output of the project, such as DLL
or executable files.

// This project uses the newer .slnx solution format.
// One advantage of the classic .sln format is wider compatibility
// with older Visual Studio versions and some older tools.

// A file-scoped namespace removes one level of indentation
// because the code does not need to be wrapped inside namespace braces { }.
*/

Console.WriteLine("=== PART A: Project & Structure ===");
Console.WriteLine("Project setup completed successfully.");
Console.WriteLine();

RunTypesDemo();
Console.WriteLine();
RunValueVsReferenceDemo();
Console.WriteLine();
RunScopeAndOperatorsDemo();
Console.WriteLine();
RunSingleNumberDemo();

void RunTypesDemo()
{
    Console.WriteLine("=== PART B: Variables, Types & Casting ===");

    // 1. Variables and Types
    int age = 22;
    long population = 1000000L;
    double temperature = 36.6;
    decimal price = 199.99m;
    bool isActive = true;
    char grade = 'A';
    string name = "Shams";
    var city = "Ashmon";

    Console.WriteLine("\n--- Variables and Types ---");

    Console.WriteLine($"int: {age} - Type: {age.GetType()}");
    Console.WriteLine($"long: {population} - Type: {population.GetType()}");
    Console.WriteLine($"double: {temperature} - Type: {temperature.GetType()}");
    Console.WriteLine($"decimal: {price} - Type: {price.GetType()}");
    Console.WriteLine($"bool: {isActive} - Type: {isActive.GetType()}");
    Console.WriteLine($"char: {grade} - Type: {grade.GetType()}");
    Console.WriteLine($"string: {name} - Type: {name.GetType()}");
    Console.WriteLine($"var: {city} - Type: {city.GetType()}");


    // 2. Implicit Conversion
    Console.WriteLine("\n--- Implicit Conversion ---");

    int smallNumber = 100;
    long largeNumber = smallNumber;

    char letter = 'A';
    int letterCode = letter;

    Console.WriteLine($"int to long: {largeNumber}");
    Console.WriteLine($"char to int: {letterCode}");

    // No explicit cast is required because both conversions are safe
    // and do not lose data.


    // 3. Explicit Conversion
    Console.WriteLine("\n--- Explicit Conversion ---");

    double number = 12.7;

    int castResult = (int)number;
    int convertResult = Convert.ToInt32(number);

    Console.WriteLine($"Using explicit cast: {castResult}");
    Console.WriteLine($"Using Convert.ToInt32: {convertResult}");

    // Casting from double to int truncates the decimal part.
    // Convert.ToInt32 rounds the value to the nearest integer.


    // 4. Integer Division
    Console.WriteLine("\n--- Integer Division ---");

    int integerDivision = 5 / 2;
    double doubleDivision = 5.0 / 2;

    Console.WriteLine($"5 / 2 = {integerDivision}");
    Console.WriteLine($"5.0 / 2 = {doubleDivision}");

    // Integer division removes the fractional part,
    // while double division keeps it.


    // 5. Boxing and Unboxing
    Console.WriteLine("\n--- Boxing and Unboxing ---");

    int originalNumber = 50;

    object boxedNumber = originalNumber;
    Console.WriteLine($"Boxed value: {boxedNumber}");

    int unboxedNumber = (int)boxedNumber;
    Console.WriteLine($"Unboxed value: {unboxedNumber}");


    // 6. Parsing
    Console.WriteLine("\n--- Parsing ---");

    string validNumber = "42";
    int parsedNumber = int.Parse(validNumber);

    Console.WriteLine($"Parsed value: {parsedNumber}");

    string invalidNumber = "abc";

    bool success = int.TryParse(invalidNumber, out int tryParsedNumber);

    Console.WriteLine($"TryParse succeeded: {success}");

    if (!success)
    {
        Console.WriteLine("Could not convert 'abc' to an integer.");
    }


    // 7. Float to Decimal
    Console.WriteLine("\n--- Float to Decimal ---");

    float floatValue = 12.5f;

    // decimal decimalValue = floatValue;
    // This does not compile because there is no implicit conversion
    // from float to decimal.

    decimal decimalValue = (decimal)floatValue;

    Console.WriteLine($"Float value: {floatValue}");
    Console.WriteLine($"Decimal value: {decimalValue}");
}
void RunValueVsReferenceDemo()
{
    Console.WriteLine("=== PART C: Value vs. Reference Types ===");

    Console.WriteLine("\n--- Experiment 1: Struct Copy Semantics ---");

    Point p1 = new Point { X = 1, Y = 2 };
    Point p2 = p1;

    p2.X = 99;

    Console.WriteLine($"p1.X = {p1.X}");
    Console.WriteLine($"p2.X = {p2.X}");

    // Point is a value type, so p2 receives a copy of p1.
    // Changing p2 does not affect p1.


    Console.WriteLine("\n--- Experiment 2: Class Reference Semantics ---");

    Order o1 = new Order
    {
        OrderId = 1,
        CustomerName = "Ali",
        Quantity = 3,
        UnitPrice = 100m,
        TotalPrice = 0m,
        IsPaid = false,
        DiscountPercent = 10,
        ShippingCity = "Cairo",
        Priority = 'H',
        ItemCode = 10001L
    };

    o1.CalculateTotal();

    Order o2 = o1;

    o2.IsPaid = true;

    Console.WriteLine($"o1.IsPaid = {o1.IsPaid}");
    Console.WriteLine($"o2.IsPaid = {o2.IsPaid}");

    // Order is a reference type.
    // o1 and o2 point to the same object on the heap.


    Console.WriteLine("\n--- Object Reference Test ---");

    object boxedOrder = o1;

    // No boxing happens here because Order is already a reference type.

    Order o3 = (Order)boxedOrder;

    Console.WriteLine(
        $"ReferenceEquals(o1, o3): {object.ReferenceEquals(o1, o3)}");


    Console.WriteLine("\n--- Order Summary ---");

    o2.PrintSummary();


    Console.WriteLine("\n--- Explanation ---");

    Console.WriteLine(
        "Value types store their own data, and assignment copies the value.");

    Console.WriteLine(
        "Reference types create objects on the heap, while variables hold references to those objects.");

    Console.WriteLine(
        "Assigning one reference variable to another copies the reference, not the object.");

    Console.WriteLine(
        "Storing a reference type in an object variable does not create a new object.");
}
void RunScopeAndOperatorsDemo()
{
    Console.WriteLine("=== PART D: Scope & Operators ===");

    Console.WriteLine("\n--- D1: Scope ---");

    ProgramScopeDemo scopeDemo = new ProgramScopeDemo();

    scopeDemo.ShowFieldFromMethodOne();
    scopeDemo.ShowFieldFromMethodTwo();
    scopeDemo.ShowLocalScope();
    scopeDemo.ShowBlockScope();


    Console.WriteLine("\n--- D2: Compound Assignment Operators ---");

    int total = 100;

    total += 20;
    Console.WriteLine($"After += 20: {total}");

    total -= 10;
    Console.WriteLine($"After -= 10: {total}");

    total *= 2;
    Console.WriteLine($"After *= 2: {total}");

    total /= 4;
    Console.WriteLine($"After /= 4: {total}");

    total %= 6;
    Console.WriteLine($"After %= 6: {total}");

    // total += 20;
    // is equivalent to:
    // total = total + 20;


    Console.WriteLine("\n--- D3: Bitwise Operators ---");

    int a = 12;
    int b = 10;

    Console.WriteLine($"a & b = {a & b}");
    Console.WriteLine($"a | b = {a | b}");
    Console.WriteLine($"a ^ b = {a ^ b}");

    /*
       a = 12 = 1100
       b = 10 = 1010

       AND:
       1100
       1010
       ----
       1000 = 8

       OR:
       1100
       1010
       ----
       1110 = 14

       XOR:
       1100
       1010
       ----
       0110 = 6
    */

    // & evaluates both sides, while && uses short-circuit evaluation, so if the left condition is false, && does not evaluate the right condition.
}
void RunSingleNumberDemo()
{
    Console.WriteLine("=== PART F: LeetCode 136 - Single Number ===");

    int[] nums1 = { 2, 2, 1 };
    int[] nums2 = { 4, 1, 2, 1, 2 };

    Console.WriteLine($"Result 1: {FindSingleNumber(nums1)}");
    Console.WriteLine($"Result 2: {FindSingleNumber(nums2)}");
}

int FindSingleNumber(int[] nums)
{
    int result = 0;

    foreach (int number in nums)
    {
        result ^= number;
    }

    // XOR cancels equal numbers because x ^ x = 0.
    // The number that appears once remains in the final result.

    return result;
}
struct Point
{
    public int X;
    public int Y;
}
class ProgramScopeDemo
{
    private int _sharedValue = 100;

    public void ShowFieldFromMethodOne()
    {
        Console.WriteLine($"Field from method one: {_sharedValue}");
    }

    public void ShowFieldFromMethodTwo()
    {
        Console.WriteLine($"Field from method two: {_sharedValue}");
    }

    public void ShowLocalScope()
    {
        int localValue = 50;

        Console.WriteLine($"Local variable inside method: {localValue}");

        // localValue only exists inside this method.
    }

    public void ShowBlockScope()
    {
        for (int i = 0; i < 2; i++)
        {
            int insideLoop = i * 10;

            Console.WriteLine(
                $"i = {i}, insideLoop = {insideLoop}");
        }

        // Console.WriteLine(i);
        // Console.WriteLine(insideLoop);

        // These lines would cause compile errors because
        // i and insideLoop only exist inside the for-loop block.
    }
}
