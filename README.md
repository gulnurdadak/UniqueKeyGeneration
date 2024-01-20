# UniqueKeyGeneration

This project is written using .NET Framework 4.7.2 and contains a simple C# program-algorithm to generate unique keys. Each unique key is created by combining randomly selected characters from a specified character set.

## How It Works

The program generates unique keys of a specified length using the `GenerateUniqueCode` method. This method utilizes the `RNGCryptoServiceProvider` class to provide cryptographically secure random numbers. These random numbers are combined with characters selected from a predefined character set to create unique keys.

## Project Structure

- `Program.cs`: The main program file. Execution of the code and generation of unique keys is performed here.
- `UniqueKeyGeneration.csproj`: C# project file.

## How to Use

1. Clone the project to your computer or download it as a ZIP file.
2. Open the project files in a C# IDE (e.g., Visual Studio).
3. Verify that it targets `.NET Framework 4.7.2`.
4. Explore how unique keys are generated by examining the `Program.cs` file.
5. Run the project and observe the generated unique keys on the console screen by uncommenting the line with `Console.ReadKey()`.

## Important Notes

- This program is written with .NET Framework 4.7.2. If you are using a different .NET version, you may need to update the project to an appropriate version.
- The purpose of this program is to provide a simple and secure algorithm example. Real-world applications may require more complex security measures.
