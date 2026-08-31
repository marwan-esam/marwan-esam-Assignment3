/*
  .csproj: A project-specific configuration file that includes: the SDK used, Framework version, Output type, Whether
    implicit usings are enabled, And whether reference types are nullable
*/

/*
  Program.cs: Contains the Main method entry point for the entire project
*/

/*
  obj/: A folder that holds temporary, and unlinked object files and metadata such as the individual, and intermediate
    .dll files. This folder acts as a cache storing builds so when rebuilding the project, it checks for only the modified files
    compiling only what changes.
*/

/*
  bin/: A folder that holds the final executable application (.exe and class library .dll) after linking completes. 
*/


/*
  This project uses the newer .slnx format. An advnatage of using the .sln format would be backward compatibility
  and widespread tooling support. Older tools have been configured to correctly identify and deal with the .sln format.
  The newer .slnx format is still preview, meaning older tools might fail to open or build the solution.
*/

// Note: I removed the line below because C# does not allow a file-scoped namespace in the same file as top-level statements
// namespace CSharpBasicsAssignment; // This line ending with a semicolon replaces the one with curly braces, preventing the entire file contents from being intended.

using System.Reflection.Metadata;
using CSharpBasicsAssignment;

Console.WriteLine("=== PART A: Project & Structure ===");
Console.WriteLine("Setup initial project structure & added comments");

Console.WriteLine("\n=== PART B: Variables, Types & Casting ===");

RunTypesDemo();

static void RunTypesDemo() {
  int a = 5;
  long b = 425245345345;
  double c = 345345345.345345;
  decimal d = 123245345.13234234m;
  bool e = true;
  char f = 'a';
  string g = "some string";
  var h = 123.456f;


  Console.WriteLine($"Value: {a}, Type: {a.GetType()}");
  Console.WriteLine($"Value: {b}, Type: {b.GetType()}");
  Console.WriteLine($"Value: {c}, Type: {c.GetType()}");
  Console.WriteLine($"Value: {d}, Type: {d.GetType()}");
  Console.WriteLine($"Value: {e}, Type: {e.GetType()}");
  Console.WriteLine($"Value: {f}, Type: {f.GetType()}");
  Console.WriteLine($"Value: {g}, Type: {g.GetType()}");
  Console.WriteLine($"Value: {h}, Type: {h.GetType()}");

  int i = 5;
  long j = i;
  char k = 'b';
  int l = k;

  Console.WriteLine("");
  Console.WriteLine($"An int with value {i} implicitly casted in a long gives value {j}");
  Console.WriteLine($"A char wit value {k} implicity casted into an int gives value {l}");
  /*
    No implicit cast was required for the first example because an int (4 bytes) already fits within a long type (8 bytes), so no data loss is expected.
    No implcit cast was required for the second example because a char (2 bytes) also already fits within an int (4 bytes), so no data loss is expected as well 
    Casting a a char into an int just gives the ASCII number of that character.
  */

  double m = 2.5;
  int n = (int) m;
  int o = Convert.ToInt32(m);

  Console.WriteLine("");
  Console.WriteLine($"Explicit casting of a double with value {m} into an int gives value {n}");
  Console.WriteLine($"Conversion (using Convert.ToInt32 method) of a double with value {m} into an int gives value {o}");
  /*
    Explicitly casting a double into an int truncates the fractional part, and leaves only the integer part.
    Converting a double to an int rounds the fraction to the nearest integer, but if the fraction is halfway between two whole numbers, then the even number is returned.
  */

  int integerDivision = 5 / 2;
  double regularDivision = 5.0 / 2;
  Console.WriteLine("");
  Console.WriteLine($"Integer division of 5 / 2 gives value: {integerDivision}");
  Console.WriteLine($"Regular division of 5 / 2 gives value: {regularDivision}");
  // Integer division happens when dividing an integer by another integer giving an integer value (truncation), but when providing a numeric value that isn't an integer, a regular division happens yielding a fractional answer.

  Console.WriteLine("");
  int intVal = 150;
  object boxedInt = intVal;
  Console.WriteLine($"Boxing {boxedInt}: The variable 'boxedInt' (sitting on the stack) will store the reference (address) of the int val (on the heap)"); 
  int back = (int) boxedInt;
  Console.WriteLine($"Unboxing {back}: copies back the value to stack leaving the one on the heap unitl garbage collected ");

  string validString = "42", invalidString = "abc";
  int intParsed = int.Parse(validString);
  bool isParseDone = int.TryParse(invalidString, out int tryParsed);
  Console.WriteLine("");
  if(isParseDone) {
    Console.WriteLine($"Prasing {validString} succeeded with value: {tryParsed}");
  } else {
    Console.WriteLine($"Parse Failed! {invalidString} is not a valid numerical string.");
  }

  // decimal invalidConversion = 50.70f;
  decimal validConversion = (decimal) 50.70f; // Since these types store number in different ways (IEEE 754 and base 10 respectively), the compiler refuses to implicitly risk losing precision
}


Console.WriteLine("\n=== PART C: Value vs. Reference Types ===");

RunValueVsReference();

static void RunValueVsReference() {
  Point p1 = new Point {X = 1, Y = 2};
  Point p2 = p1;
  p2.X = 99;
  Console.WriteLine($"Point 1's x value: {p1.X}");
  Console.WriteLine($"Point 2's x value: {p2.X}");
  /*
    because struct is a value type, assigning p2 = p1 copies the entire value onto the stack.
    They are completely different buckets of memory now.
  */

  Console.WriteLine("");
  Order o1 = new Order {
    OrderID = 123,
    CustomerName = "Marwan",
    Quantity = 3,
    UnitPrice = 50,
    IsPaid = false,
    DiscountPercent = 20,
    ShippingCity = "Aswan",
    Priority = 'H',
    ItemCode = 123456
  };
  o1.CalculateTotal();
  Order o2 = o1;
  o2.IsPaid = true;
  Console.WriteLine($"Order 1 Paid Value: {o1.IsPaid}");
  Console.WriteLine($"Order 2 Paid Value: {o2.IsPaid}");
  /*
    because order is a reference type, assigning o2 = o1 stores the reference (address) of o1 inside o2 
    making it point to the same block of memory
  */

  object boxedOrder = o1; // no boxing happens here because Order is already a reference type so the only address gets copied
  Order o3 = (Order) boxedOrder;
  Console.WriteLine($"\nAre Instances o1 and o3 equal references: {object.ReferenceEquals(o1, o3)}");
  Console.WriteLine("\nO2 Instance Summary:-");
  o2.PrintSummary();

  /*
    Value type data such as (int, double, bool, char, struct, enum) live on the stack 
    whereas Reference type data such as (class, interface) live on the heap (but a reference still exists on the stack).
    When assigning value type data, data gets copied into a new block of memory on the stack. On the other hand, when 
    assigning reference type data, a reference of the data gets stored in the other already existing object on the stack,
    meaning no new object is created.
  */
}

struct Point { public int X; public int Y; }