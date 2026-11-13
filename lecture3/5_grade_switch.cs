/// Description: Takes a grade as a percentage and returns the letter grade according to:
/// 90-100 => A
/// 80-89  => B
/// 70-79  => C
/// 60-69  => D
/// <60    => F
/// Bonus: Return the awarded GPA points for the letter grade
using static System.Console;

Write("Enter the grade percentage: ");
double grade = double.Parse(ReadLine());

// char letGrade = ' ';
// switch (grade) {
//     case >= 90:
//     letGrade = 'A';
//     break;
//  deafault:
//      letGrade = 'F';
//      break;
// }

// Switch expression
char letgrade = grade switch {
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _     => 'F' // The discard operatop '_' acts as the
                 // 'default'
};

// Traditional switch statement ( with no pattern matching)
double gpa;
switch (letgrade){
    case 'A':
    gpa = 4.0;
    break;
    case 'B':
    gpa = 3.0;
    break;
    case 'C':
    gpa = 2.0;
    break;
    case 'D':
    gpa = 1.0;
    break;
    default:
    gpa = 0.0;
    break;
}
WriteLine($"The letter grade is: {letgrade}");
WriteLine($"Points earned: {gpa:F1}");