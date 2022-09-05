// See https://aka.ms/new-console-template for more information
using ValidateString;




Validation validation = new Validation();


Console.WriteLine("Please enter a sentence");
string sentence = Console.ReadLine();

bool ValidSentence = validation.ValidateSentence(sentence);

if (ValidSentence){ 
    Console.WriteLine("Your sentence is valid");
}else
{   Console.WriteLine("Your sentence is invalid");
}









