# Basic Password Generator
This is a very basic C# program that generates random passwords.

# How it Works
The program defines four character sets: lowercase letters, uppercase letters, symbols, and numbers.
It then combines these sets into a single string. The user is prompted to enter a desired password length (greater than 16). 
The program then iterates for the specified length, randomly choosing a character set and appending a random character from that set to the password string. Finally, the generated password is returned.

# How to use this Generator
1. Clone this repo from github
2. Make sure .NET and the .NET CLI are installed
3. Now run `dotnet run` in your terminal
4. You will be prompted to enter a desired password length. Enter a number greater than 16 and press Enter.
5. The program will generate a random password of the specified length and print it to the console.

# NOTE: 
  This is a **VERY BASIC PASSWORD GENERATOR** and does not guarantee the strongest passwords. It is **HIGHLY** recommended to use a more secure password generator for most usecases.
