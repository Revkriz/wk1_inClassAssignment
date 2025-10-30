// See https://aka.ms/new-console-template for more information

//Prompt the user to write something
Console.Write("You had better type something. \n");

//Get the users response
int resp = Console.Read();

//Respond with the users input and insult them in a subtle way
Console.WriteLine($"You typed {resp}, but it doesn't make sense.  Type something normal");

//Get the users response again
ConsoleKeyInfo keyInfo = Console.ReadKey();

//Add a line
Console.WriteLine();

//Politely tell the user their response and admonish them gently.
Console.WriteLine($"You typed {keyInfo.KeyChar}, but that is also a dumb thing to type. Why don't you try to write something that isn't dumb.");
//I added this because it was keeping the first additional character from the readkey if the user inputted more than 2 characters then passing the second to the resp2 variable.
Console.ReadLine();

//Get the users input
string resp2 = Console.ReadLine();

//Congratulate them on their successful response
Console.WriteLine($"You typed: {resp2}.  We can all rest easy knowing that you finally learned to follow instructions.");