# Code Challenge

This code challenge is a program that converts a string of numbers and special characters into an old phone keypad representation of the corresponding alphabets.

## Instructions

1. Run the program by executing the `Main` method in the `Program` class.
2. The program takes a string as input and converts it to an old phone keypad representation.
3. The converted output is displayed on the console.

## Example

```csharp
Console.WriteLine(OldPhonePad("222 2 22"));
// Output: "C"

Console.WriteLine(OldPhonePad("33#"));
// Output: "D"

Console.WriteLine(OldPhonePad("227*#"));
// Output: "CAR"

Console.WriteLine(OldPhonePad("4433555 555666#"));
// Output: "HIGHLY"

Console.WriteLine(OldPhonePad("8 88777444666*664#"));
// Output: "TROUBLE"
