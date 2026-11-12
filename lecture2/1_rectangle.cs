/// Description: Calculates the area and perimeter of a 
/// rectangle given the length and width.

/* Arithmetic Operators:
+ Add
- Subtract
* Multiply
/ Devide
% Modulus (Remainder from longj/int division)
*/ 
// Programs are typpically split into three sections: Input, Calculation, Output

// Input section
Console.Write("Enter length: ");
int length = int.Parse(Console.ReadLine());  // Convert.ToInt32(...)

Console.Write("Enter width: ");
int width = int.Parse(Console.ReadLine());

// Calculation Section

int area = length * width;
int perim = 2 * length + 2 * width;

// Output
Console.WriteLine("Area: " + area);
Console.WriteLine("Perimeter: " + perim);