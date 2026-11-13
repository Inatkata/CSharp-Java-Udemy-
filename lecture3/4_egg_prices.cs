/// Description: Takes a number of eggs and prices them according to:
/// [0, 4)  dozen => $0.50/dozen
/// [4, 6)  dozen => $0.45/dozen
/// [6, 11) dozen => $0.40/dozen
/// 11+     dozen => $0.35/dozen
/// Extra eggs    => 1/12th the per dozen price
using static System.Console;

Write("Enter the number of eggs: ");
int eggs = int.Parse(ReadLine());
int dozen = eggs / 12;
int extra = eggs % 12;
double price, total;

if(dozen > 0 && dozen < 4)
{
    price = 0.50;
}
else if (dozen >= 4 && dozen < 6)
{
    price = 0.45;
}
else if (dozen >= 6 && dozen < 11)
{
    price = 0.40;
}
else 
{
    price = 0.35;
}
total = (dozen * price) + (extra * (price / 12));

WriteLine($"The prise of {eggs} is ${total:F2}");

