// 01 Introduction to C# and Data Types
// Understanding Data Types
// Test your Knowledge
// 1. What type would you choose for the following “numbers”?
// A person’s telephone number
// A person’s height
// A person’s age
// A person’s salary
// A book’s ISBN
// A book’s price
// A book’s shipping weight
// A country’s population
// The number of stars in the universe
// The number of employees in each of the small or medium businesses in the
// United Kingdom (up to about 50,000 employees per business)

// 2. What are the difference between value type and reference type variables? What is
//    boxing and unboxing?
// a) Value type will directly hold the value,while reference type will hold the memory address or reference for this value
// b) value types are stored in stack memory, while reference type will be stored in heap memory
// c) value type will not be collected by garbage collector, while reference type will be collected by garbage collector because garbage collector work only on heap memory
// d) value type will can be created by struct or enum, while reference type can be created by class, interface, delegate or array
// e) value type cannot accept null value but reference type can accept null value

// boxing: convert a value type to a reference type
// unboxing: convert a reference type to a value type

// 3. What is meant by the terms managed resource and unmanaged resource in .NET
// managed resource is directly under the control of the garbage collector, while unmanaged resource is not directly under the control of the garbage collector

// 4. Whats the purpose of Garbage Collector in .NET?
// Garbage Collector manages the allocation and release of memory for an application.


// Practice number sizes and ranges
// 1. Create a console application project named /02UnderstandingTypes/ that outputs the number of bytes in memory that each of the following number types uses, and the
// minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
// byte bMin = 0;
// byte bMax = 255;
// Console.WriteLine($"The byte range is {bMin} to {bMax}");
// sbyte sbMin = -128;
// sbyte sbMax = -128;
// Console.WriteLine($"The sbyte range is {sbMin} to {sbMax}");
// short sMin = -32768;
// short sMax = 32767;
// Console.WriteLine($"The short range is {sMin} to {sMax}");
// ushort usMin = 0;
// ushort usMax = 65535;
// Console.WriteLine($"The ushort range is {usMin} to {usMax}");
// int iMin = -2147483648;
// int iMax = 2147483647;
// Console.WriteLine($"The int range is {iMin} to {iMax}");
// uint uMin = 0;
// uint uMax = 4294967295;
// Console.WriteLine($"The uint range is {uMin} to {uMax}");
// long lMin = -9223372036854775808;
// long lMax = 9223372036854775807;
// Console.WriteLine($"The long range is {lMin} to {lMax}");
// ulong ulMin = 0;
// ulong ulMax = 18446744073709551615;
// Console.WriteLine($"The ulong range is {ulMin} to {ulMax}");
// float f = 1.2f;
// Console.WriteLine($"The float is {f}");
// double d = 1.23;
// Console.WriteLine($"The double is {d}");
// decimal de = 1.2343232m;
// Console.WriteLine($"The decimal is {de}");


// 2. Write program to enter an integer number of centuries and convert it to years, days, hours,
//    minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//    type for every data conversion. Beware of overflows!
// byte centuries = 100;
// ushort years = 365.24;
// uint days = 876576;
// int hours = 52594560;
// long minutes = 3155673600;
// long seconds = 3155673600000;
// long milliseconds = 3155673600000000;
// long microseconds = 3155673600000000000;
// Console.WriteLine("enter an integer number of centuries: ");
// int countryNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(
//     $"{countryNumber} centuries = {centuries} years = {years} days = {days} hours = {hours} minutes = {minutes} seconds = {seconds}  milliseconds = {milliseconds} microseconds = {microseconds}");

// short centuries = 500;
// uint years = 182621;
// uint days = 4382904;
// int hours = 262974240;
// long minutes = 15778454400;
// long seconds = 15778454400000;
// long milliseconds = 15778454400000000;
// ulong microseconds = 15778454400000000000;
// Console.WriteLine("enter an integer number of centuries: ");
// int countryNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(
//     $"{countryNumber} centuries = {centuries} years = {years} days = {days} hours = {hours} minutes = {minutes} seconds = {seconds}  milliseconds = {milliseconds} microseconds = {microseconds}");


// Controlling Flow and Converting Types
//     Test your Knowledge
// 1. What happens when you divide an int variable by 0?
// 2. What happens when you divide a double variable by 0?
// 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
// 4. What is the difference between x = y++; and x = ++y;?
// 5. What is the difference between break, continue, and return when used inside a loop statement?
// 6. What are the three parts of a for statement and which of them are required?
// 7. What is the difference between the = and == operators?
// 8. Does the following statement compile? for ( ; true; ) ;
// 9. What does the underscore _ represent in a switch expression?
// 10. What interface must an object implement to be enumerated over by using the foreach statement?

// 1. there will be unhandled exception
// 2. there will be a infinity symbol on console
// 3. that will have identifier expected for integral constant is too large
// 4. x = y++; this first value of y will get copied to x, and x = ++y; this y will be incremented and then be copied to x 
// 5. a)The Break statement is used to exit from the loop constructs. The continue statement is not used to exit from the loop constructs.
//    b)The break statement is usually used with the switch statement. The continue statement is not used with the switch statement
//    c) Break statement: When a break statement is encountered then the control is exited from the loop construct immediately. Continue: When the continue statement is encountered then the control automatically passed from the beginning of the loop statement.
// 6. for (statement 1; statement 2; statement 3), Statement 1 is executed (one time) before the execution of the code block.
//     Statement 2 defines the condition for executing the code block. Statement 3 is executed (every time) after the code block has been executed.
// 7. The = is an assignment operator is used to assign the value on the right to the variable on the left.
//    The == operator checks whether the two given operands are equal or not.
// 8. yes, but will creating an infinite loop.
// 9. The underscore (_) character replaces the default keyword to signify that it should match anything if reached. 
// 10. The IEnumerator interface , the GetEmunerator() method of the IEnumerable interface returns an IEnumerator interface.

// Practice loops and operators
// 1. What will happen if this code executes? this will be infinite loop.
// Create a console application and enter the preceding code. Run the console application and view the output. What happens?
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     Console.WriteLine(i);
// }
// What code could you add (don’t change any of the preceding code) to warn us about the problem?
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     if (i < max)
//     {
//         Console.WriteLine("warning!!");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }



