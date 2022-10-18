//ISAIAH FERGUSON
//10/17/22
//Hello World
string digits = "1234567890";
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

if (input.IndexOfAny(digits.ToCharArray()) != -1){
    Console.WriteLine("Unless your the product of Elon Musk and Grimes I don't think that's your name.");
}else{
    Console.WriteLine($"Hello {input} nice to meet you!");
}

Console.WriteLine("Please type End to end the program or Press enter to replay.");
iinput = Console.ReadLine().ToLower();

if (iinput == "end")
{
    loop = false;
}
}
