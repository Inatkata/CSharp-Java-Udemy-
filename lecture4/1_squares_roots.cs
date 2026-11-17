/// Description: Displays a table of squares and square roots for all numbers [1, 50]
/*
Assingment Operators:
=
+=
-=
*=
/=
%=
++ : for x += 1
--
*/
Console.WriteLine("Number\tSquare\tSquare Root"); // '\t' is the tab-space char
int lcv = 1;  // Loop Control Variable ( index )
while (lcv < 51) {      // or (lcv <= 50)
    int sqr = (int)Math.Pow(lcv, 2);
    double sqrt = Math.Sqrt(lcv);
    Console.WriteLine($"{lcv}\t{sqr}\t{sqrt:F4}");
     lcv++;
}