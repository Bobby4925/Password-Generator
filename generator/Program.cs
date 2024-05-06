// See https://aka.ms/new-console-template for more information
string pswd = ""; 
Console.WriteLine("Welcome to this Password Generator");
Console.WriteLine("Before We Begin What Size would you like your password to be?");
string input = Console.ReadLine(); 
int length; 
if(!Int32.TryParse(input, out length)){
    throw new Exception("You must enter a valid integer"); 
}
else{
    length = int.Parse(input);
}
int arrLength = length + 1; 
string[] passwordArr = new string[arrLength]; 