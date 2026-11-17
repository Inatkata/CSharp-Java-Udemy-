/// Description: Validates and sums a series of numeric inputs from a user,
/// skips invalid ranges and exits immediately when a 0 is received
using static System.Console;
/*
Do-while loops guarantee at least one iteration:
int x = 10;
while (x < 10) {WriteLine("Yes");}      //Prints nothing
do {WriteLine("Yes"); } while (x < 10); //Prints "Yes" once
Condition is evaluated AFTER the loop body
*/


int sum = 0;
do
{
    Write("Enter a score between 1 - 100 ( or 0 to calculate total): ");
    int input = int.Parse(ReadLine());
    // break condition: exit the loop immediately when the user wants the total
    if(input == 0) break;

    //  skip and ignore numbers outside the valid range
    if (input < 1 || input > 100){
        WriteLine("Error: Out of bonds, please try again.");
        continue;
    }
    sum += input;

} while (true); //Loop runs infinietly until the explicit 'break' statement hit


WriteLine($"Final total of all valid scores: {sum}");