// See https://aka.ms/new-console-template for more information
Console.WriteLine(ValidateSentence("The quick brown fox said \"hello Mr lazy dog\"."));
Console.WriteLine(ValidateSentence("The quick brown fox said hello Mr lazy dog."));
Console.WriteLine(ValidateSentence("One lazy dog is too few, 13 is too many."));
Console.WriteLine(ValidateSentence("One lazy dog is too few, thirteen is too many."));
Console.WriteLine(ValidateSentence("How many \"lazy dogs\" are there?"));
Console.WriteLine("");
Console.WriteLine(ValidateSentence("The quick brown fox said \"hello Mr. lazy dog\"."));
Console.WriteLine(ValidateSentence("the quick brown fox said hello Mr lazy dog."));
Console.WriteLine(ValidateSentence("\"The quick brown fox said \"hello Mr. lazy dog\"."));
Console.WriteLine(ValidateSentence("One lazy dog is too few, 12 is too many."));
Console.WriteLine(ValidateSentence("Are there 11, 12, or 13 lazy dogs?"));
Console.WriteLine(ValidateSentence("There is no punctuation in this sentence"));




bool ValidateSentence(string sentence)
{
    bool validate = false;

    if (sentence == "") return false;

    char[] cArray = sentence.ToCharArray();


    validate =  isFirstCapital(cArray) & EvenQuoteMarks(cArray) & EndsWithTermination(cArray) & NoExtraPeriodChars(cArray) & CheckNumsSpeltOut(sentence);

    return validate;

}

bool CheckNumsSpeltOut(string sentence)
{
    sentence = sentence.Replace(",", "");

    string[] wArray = sentence.Split(" ");

    for(int i = 0; i < wArray.Length; i++)
    {
        for(int j = 0; j < 13; j++)
        {
            if(wArray[i] == j.ToString())
            {
                return false;
            }
        }
    }

    return true;
}




bool NoExtraPeriodChars(char[] cArray)
{
   cArray = cArray.SkipLast(1).ToArray();

    for (int i = 0; i < cArray.Length; i++)
    {
        if (cArray[i] == '.') { return false; }
    }

    return true;

}



bool EndsWithTermination(char[] cArray)
{
    char last = cArray.Last();

    if (last == '.') { return true; }
    if (last == '!') { return true; }
    if (last == '?') { return true; }

    return false;
          
}


bool EvenQuoteMarks(char[] cArray)
{
    int numQuotes = 0;

    for (int i = 0; i < cArray.Length; i++)
    {
        if (cArray[i] == '"') { numQuotes++; }
    }

    bool evenNum = false;

    if(numQuotes % 2 == 0) { evenNum = true; }

    return evenNum;

}

bool isFirstCapital(char[] cArray)
{
    if (cArray[0].ToString().ToUpper() == cArray[0].ToString()) {
        return true;
    }
    
    return false;
}