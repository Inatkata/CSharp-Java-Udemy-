/// Description: Generates a random number [1, 20] and tracks how many guesses
/// it takes for the user to match the number; fails after 10 attempts
using static System.Console;

 Random rand = new Random();    // Create a new random number generator object
 int secret = rand.Next(1, 21);

 for (int guesses = 10; guesses > 0; guesses--)
 {
    Write("Enter a number between 1-20: ");

    int num = int.Parse(ReadLine());

    if (num == secret){
      WriteLine($"You win! Guesses used: {10 -(guesses - 1)}");
      break;
    }
   // else if (guesses == 1) {
   // ... ran out of guesses
   // } else {
   // ... try again
   // }
   // Could use ternary instead of if/else

   WriteLine((guesses == 1)
      ? "You ran out of guesses. Better luck next time!"
      : "Try again!"
      );
 }