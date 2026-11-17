/// Description: Displays a table of cubes and cube roots for all numbers [-25, 25]
/// Note: the nth-root of a number is number^(1/n)

Console.WriteLine("Number\t\tCube\t\tCube Root");
// int index = -25; while (index < 26 ) {......; index++;}
for (int i = -25; i < 26; i++){
    // double cbrt = Math.Pow(Math.Abs(i), 1.0/3.0);
    // if (i < 0) cbrt *= -1;
    double cbrt = Math.Cbrt(i);
    Console.WriteLine($"{i}\t\t{cube}\t\t{cbrt:F5}");
}