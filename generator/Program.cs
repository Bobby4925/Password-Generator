// See https://aka.ms/new-console-template for more information
string pswd = ""; 
Console.WriteLine("Welcome to this Password Generator");
Random r = new Random(); 
Console.WriteLine("Before We Begin What Size would you like your password to be? (The Number Must be Greater Than 16)");
string input = Console.ReadLine(); 
int length; 
if(!Int32.TryParse(input, out length)){
    throw new Exception("You must enter a valid integer"); 
}
else if(int.Parse(input)<16){
    throw new Exception("You must enter a integer greater than 16"); 
}
else{
    length = int.Parse(input);
}
int arrLength = length + 1; 
char[] passwordArr = new char[arrLength]; 

//Example - 16 is length now for example (Uppercase Lowercase Numbers and Symbols) divide up amount of each equally
//Do a random number generator and on each iteration do a random number generation of 1 - 4 to see whether to put uppercase lowercase numbers or symbols)
int type;
static char generateRandomLetter(){
    //65 - 90 
    var r = new Random(); 
    int x = r.Next(65,91); 
    char letter = (char)x; 
    return letter;
}
static char Lowercase(){
    char c = generateRandomLetter();
    string r = c.ToString(); 
    r = r.ToLower();
    c = r.ToCharArray()[0]; 
    return c; 
}
static char Uppercase(){
    return generateRandomLetter(); 
}
static int generateRandomNum(){
    var r = new Random(); 
    return r.Next(0,10); 
}
static char generateSymbol(){
    var r = new Random();
    int random = r.Next(33,48); 
    return (char)random;
}

for(int i = 0; i<passwordArr.Length; i++){
    type = r.Next(1,5); 
    if(type == 1){
        passwordArr[i] = Uppercase(); 
    }
    else if(type == 2){
        passwordArr[i] = Lowercase(); 
    }
    else if(type == 3){
        char num = char.Parse(generateRandomNum().ToString());
        passwordArr[i] = num;
    }
    else if(type == 4){
        passwordArr[i] = generateSymbol(); 
    }
}

Console.WriteLine("Here is your Password!"); 
Console.WriteLine(new string(passwordArr));
