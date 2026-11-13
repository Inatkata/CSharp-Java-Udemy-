/// Description: Demonstrates the ternary operator.
Random rand = new Random();

/*
string planet;
if(rand.Next(0, 2) == 0)
planet = "Earth";
else
planet = "Mars";

Ternary operator (inline if/else)
(<condition>) ? <value is true> : <value otherwise>
Think:
? means 'if'
: means 'else'
*/

string planet = (rand.Next(0, 2) == 0) ? "Earth" : "Mars";
Console.WriteLine($"Hello, {planet}!");