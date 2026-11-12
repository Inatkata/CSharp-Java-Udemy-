/// Description: Calculates the area and circumference 
/// of a circle (to three decimals) given the radius.
using static System.Console;

Write("Enter radius: ");
double rad = double.Parse(ReadLine());

const double pi = 3.14159; // Constant cannot be modified after assingment (immutable)
double area = pi * Math.Pow(rad, 2); //Function for multiply instead of (rad * rad), Could use Math.Pi instead of pi variable
double circ = 2 * pi * rad;
WriteLine("\nArea: " + Math.Round(area, 3));
WriteLine("Circumference: " + Math.Round(circ, 3));