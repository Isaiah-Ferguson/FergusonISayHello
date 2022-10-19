//ISAIAH KEITH FERGUSON
//10/18/22
//Hello World
//Will ask the user for their name, if the user has any numbers or special characters 
//the program restarts, if not the program will print nice to meet you.
//Peer Reviwed by:

Console.Clear();

string digits = "1234567890";
string SpecialChar = "~!@#$%^&*()`[]{}|/?.,><";
string input = "";
string iinput = "";
bool truinput = true;
int trueint = 0;
bool loop = true;

while (loop == true)
{
Console.WriteLine("Hello, what is your name?");
input = Console.ReadLine();
truinput = Int32.TryParse(input, out trueint);

if (truinput == false)
{
if (input.IndexOfAny(digits.ToCharArray()) != -1 || input.IndexOfAny(SpecialChar.ToCharArray()) != -1 )
{
    Console.WriteLine("Unless your the product of Elon Musk and Grimes or Prince, I don't think that's your name.");
}
else{Console.WriteLine($"Hello {input} nice to meet you!");}
}
else{ Console.WriteLine("yea.... that aint it buddy. try again.");}

Console.WriteLine("Please type End to end the program or Press enter to replay.");
iinput = Console.ReadLine().ToLower();

if (iinput == "end"){loop = false;}

}