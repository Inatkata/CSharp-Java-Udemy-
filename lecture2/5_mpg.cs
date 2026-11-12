/// Description: Calculates the MPG (rounded to the nearest 10th gal) 
/// of a car given its miles and gallons used.
using static System.Console;

Write("Enter car model: ");
string model = ReadLine();

Write("Enter miles driven: ");
int miles = int.Parse(ReadLine());

Write("Enter gallons used: ");
int gallons = int.Parse(ReadLine());

double mpg = miles /(double) gallons; // Cast gallons to double to get a double result

WriteLine("\nMPG used by " + model + "is " + Math.Round(mpg, 1) + " m/g");