

using RandMeTonight;
/*
Console.WriteLine("Please give me number you want to check ");

string input = Console.ReadLine();
Int32.TryParse(input, out var checkedNumber);


Console.WriteLine("Please write scope in what you want to check");
string input2 = Console.ReadLine();
Int32.TryParse(input2, out var scope);

Console.WriteLine("Please write number of try");
string input3 = Console.ReadLine();
Int32.TryParse(input3, out var renewals);
*/

Randomizer numberOfCorrectTry = new RandomizerFactory().Calculate(01,10000,10000000);
Console.WriteLine(numberOfCorrectTry.ToString());