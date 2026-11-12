/// Description: Demonstrates passing variables into methods/functions 
/// by value vs. by reference (i.e., pointers), along with the 'ref', 'in', 'out' keywords.
using static System.Console;

/*
Passing by...
- Value     => A copy of the variable is passed to the method. 
               Changes made inside the method do not affect the original variable.
- Reference => A reference (or pointer) to the original variable is passed.
               Changes made inside the method affect the original variable.
- 'ref'     => By reference, but requires the variable to be initialized before being passed.
               The method can modify the original variable.
- 'in'      => By reference, but the method cannot modify the original variable.
               It is read-only.
- 'out'     => By reference, but the variable does not need to be initialized before being passed.
               The method can assign a value to the variable (e.g., TryParse).
'ref' is used when the method needs to read and modify the variable, while 
'out' is used when the method needs to return a value through the parameter.
These are essentially abstractions of the * and & operators in C/C++ (or unsafe pointers in C#).
*/
