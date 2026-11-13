/// Description: Takes a number of copies to be printed and prices them according to:
/// 0-99     => $0.30/copy
/// 100-499  => $0.28/copy
/// 500-749  => $0.27/copy
/// 750-1000 => $0.26/copy
/// >1000    => $0.25/copy
using static System.Console;

/*
> Greater than
< Less than
>= Greater than / equal to
<= Less than / equal to
== Equal to
!= Not equal to 

Conditional Operators:

&& AND (condition1 and condition2 are both true)
|| OR  (either condition1 OR condition2 are True, or both )
! NOT (condition is not True; i.e., condition is False)
*/

Write("Enter # of copies to print: ");
int copies = int.Parse(ReadLine());
double price = 0;
double cost;
if (copies > 0 && copies <= 99)
    price = 0.30;
else if (copies > 99 && copies <= 499)
    price = 0.28;
else if (copies > 499 && copies <= 749)
    price = 0.27;
else if (copies > 749 && copies <= 1000)
    price = 0.26;
else if (copies > 1000)
    price = 0.25;
else{
    WriteLine("Invalid number of copies!");
    return; // End the program early
}
cost = copies * price;
WriteLine("Price per copy is: $" + price);
WriteLine("Total cost is: $" + cost);
    