/// Description: Takes two integers and calculates their 
/// sum, difference, product, average, distance (absolute difference), max, and min.
using System.Reflection;
using static System.Console;

Write("Enter num1: ");
int num1 = int.Parse(ReadLine());

Write("Enter num2: ");
int num2 = int.Parse(ReadLine());

int sum = num1 + num2;
int dif = num1 - num2;
int prd = num1 * num2;
double avg = sum / 2.0;
int abs = Math.Abs(dif);
int max, min;
    //Conditional Statements
if (num1 > num2)
{
    // The code here is running only if it's TRUE
max = num1;
}
else
{
max = num2;
}
 // Another statment to check if "max" and "num1" are the same value using "=="
if (max == num1)
{
    min = num2;
}
else {
    min = num1;
}
WriteLine(
    "\nSum: " + sum +
    "\nDifference: " + dif +
    "\nProduct: " + prd +
    "\nAverage: " + avg +
    "\nDistance: " + abs +
    "\nMax: " + max +
    "\nMin: " + min
    );