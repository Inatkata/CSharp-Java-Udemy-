/// Description: Takes in a user's shopping cart total and membership status,
/// returns $4.99 for non-premium membership or carts < $50, otherwise free shipping
using static System.Console;

Write("Enter cart total: $");
double cart = double.Parse(ReadLine());
Write("Is user a premium member? (y/n): ");
char isPremium = ReadKey().KeyChar;
isPremium = char.ToLower(isPremium);
if(cart >= 50 || (isPremium == 'y'))
WriteLine("\nYou get free shipping!");
else
WriteLine("\nShipping cost: $4.99");
