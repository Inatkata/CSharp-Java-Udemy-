# C# versus Java

C# and Java are similar because both are C-style, statically typed, object-oriented 
languages that compile to intermediate code executed by a managed runtime with 
garbage collection, massive standard libraries, exceptions, interfaces, and generics. 

Microsoft developed C# for the .NET platform after disputes with Sun Microsystems 
over Microsoft's licensed implementation of Java, giving Microsoft a Java-like language 
and runtime that it could design, extend, and license independently.

## Major Differences
  - Primitives: `int`, `double`, `char`, `boolean` (also `long`, `float`, etc.)
  - `String` is a class, not a primitive (no `decimal` type either, use `BigDecimal`)
  - Primitives have no methods, must use the boxed (i.e., class) version (e.g., `int x = Integer.parseInt("123");`)
  - No `[]` operator on strings, use `str.charAt(index)` for a single char, iterate using `str.toCharArray()`
  - Arrays are objects, not primitives
  - Use `final` instead of `const` for constant variables
  - Multidimensional arrays are always technically arrays of arrays (like jagged) but can take in a column size
  - `ArrayList` works similar to C# `List` but no `[]` operator; must use class version of primitives
  - Arrays use `.length` to get their capacity, `ArrayList` uses `.size()` to get the current item quantity
  - Javadoc comments use `/** ... */` instead of C#'s `/// ...`
  - `Math.round()` does not take in a decimal place; use string formatting or (not good) `Math.round(value * 100.0) / 100.0;`
  - You can use the `Random` class for numbers OR `Math.random()`; e.g., [1, 10] is `(int)(Math.random() * 10) + 1;`
  - Conventional Java prefers camelCase for methods, C# prefers PascalCase
  - Likewise, Java prefers K&R indentation (open curly brace on statement line), C# prefers Allman (open curly brace on separate line)
  - Switches fall-through by default, must use break to prevent it OR use modern arrow syntax
  - String formatting uses format specifiers (`%s`, `%d`, `%f`, etc.) instead of in-place interpolation
  - Comparing object types (including strings) uses `.equals()` instead of `==` (which checks for reference equality)
  - Foreach loops use `for (TYPE x : items)` (enhanced-for) instead of `foreach (TYPE x in items)`
  - Inheritance uses `extends` instead of `:`; interfaces use `implements`, `super` instead of `base`
  - Programs must (typically) be inside a class (or a `void main()` like C), no true top-level statements
  - Java files must be named after the public class; C# files can named anything
  - User input requires a `Scanner` object instead of `Console.ReadLine()`
  - Files also can be read/written using `Scanner` and `PrintWriter` instead of `StreamReader/StreamWriter`
  - In C#, no access modifier means private; in Java, it means package-private (accessible to all classes in the same package)
  - Java requires exception checking for certain operations, C# does not
  - Java uses `instanceof` for class membership checking; C# uses `is`
  - Java `enum` is a special type of class; C# `enum` is a value type
  - Class instance methods allow overriding by default; C# methods are non-virtual by default (must use `virtual` keyword)
  - In C#, the `override` keyword is required; in Java, it is optional but recommended to use the `@Override` annotation
  - No `using` statements for streams, but `try` blocks can do the same thing with 'try-with-resources' (Java 7+)
  - No class properties; always fields (use getter/setter methods instead)
  - No expression-bodied properties/methods, make utility methods instead
  - No destructors; use try-with-resources instead
  - No primary constructors or `new(...)` syntax; must use the constructor instead (or `<>` operator for generic classes)
  - No `struct` (use classes instead); `record` was introduced in Java 14 (finalized in Java 16)
  - No tuples; make your own class with generics or use an array
  - No null coalescing (`??`) or forgiving (`!`) operators, but alternatives exist
  - No pointer control (`ref`, `in`, `out`, `unsafe`, etc.), objects are always passed by value (reference is copied, not the object itself)
  - No operator overloading, but you can override `equals` and `toString`
  - No optional/named parameters (use method overloading instead)
  - Java compiles to bytecode executed by the Java Virtual Machine (JVM); C# compiles to Common Intermediate Language (CIL, formerly MSIL) executed by the Common Language Runtime (CLR), but now also offers native compilation to machine-specific native code
  - For GUIs, Jetbrains IntelliJ IDEA offers a Swing UI designer plugin for the Java Swing library; very similar to Visual Studio (and Jetbrains Rider) with its Windows Form designer

### TLDR - Top 10
 1. File names matter; traditional Java files start with `public class Thing {...}` and must be named `Thing.java` accordingly
 2. Strings are objects and must be compared with `str1.equals(str2)`
 3. `Scanner` for user- and file-input, 
 4. `ArrayList` instead of `List`; `List` in Java is an interface
 5. No interpolated strings `$"..."` (use `String.format()` or `System.out.printf` with format specifiers)
 6. Encapsulated class fields with getter/setter methods instead of properties
 7. `for (var x : items)` instead of `foreach (var x in items)`,
 8. `extends` or `implements` instead of `:`
 9. No operator overloading, method overloading and overriding still works (no `virtual`  or `override` keywords)
 10. `try (var thing = new Resource()) {...}` instead of `using (var thing = new Resource()) {...}`; also, you will need to use `try-catch` more often or denote that a method may throw a certain unhandled exception

## Documentation
 - C# (latest): https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/
 - Java (26): https://docs.oracle.com/en/java/javase/26/docs/api/index.html


## Hello World

### In C#
In a console app created with `dotnet new console -n Hello`, in `Program.cs`:
```cs
// run with "dotnet run" inside the folder 
// or with "dotnet run -p Hello" outside it
class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Hello, world!");
    }
}
```
or (with top-level statements), in a file named anything with `.cs`:
```cs
// run with "dotnet filename.cs"
Console.WriteLine("Hello, world!");
```


### In Java
In a file named `Hello.java`:
```java
// run with "java Hello.java" for a single-file program
// or with "javac *.java && java Hello" for a multi-file program
public class Hello {
    public static void main(String[] args) {
        System.out.println("Hello, world!");
    }
}
```
or (as a compact source file in Java 25+), in a file named anything with `.java`:
```java
// run with "java filename.java"
void main() {
    System.out.println("Hello, world!");
}
```
