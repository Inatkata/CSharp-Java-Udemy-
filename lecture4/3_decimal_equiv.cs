/// Description: Displays a table of decimal equivalents of all proper fractions
/// with denominators [2, 15] with the numerator < denominator

int n = 0;
int d = 1;
double fraction = 0;
while(n < 16 && d <= 15){
    n +=1;
    if (n == d){
        d++;
    
        if (n != 15) {
            n = 1;
        }
    }
    fraction = (double)n / d;
    Console.WriteLine($"{n}/{d}\t\t{fraction:F5}");
}