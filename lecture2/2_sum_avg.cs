/// Description: Calculates the sum and average of four integers.
using static System.Console;
Write("Enter #: ");
int n1 = int.Parse(ReadLine());

Write ("Enter #: ");
int n2 = int.Parse(ReadLine());

Write ("Enter #: ");
int n3 = int.Parse(ReadLine());

Write ("Enter #: ");
int n4 = int.Parse(ReadLine());

int sum = n1 + n2 + n3 + n4;
double avg = sum / 4.0;

WriteLine("\nSum: "+ sum); // '\n' is the new line (line break) char
WriteLine("Average: " + avg);