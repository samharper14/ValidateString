using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateString
{
    public class Validation
    {

        public bool ValidateSentence(string sentence)
        {
            bool validate = false;

            if (sentence == "") return false;

            char[] cArray = sentence.ToCharArray();


            validate = IsFirstCapital(cArray) & EvenQuoteMarks(cArray) & EndsWithTermination(cArray) & NoExtraPeriodChars(cArray) & CheckNumsSpeltOut(sentence);

            return validate;

        }

        bool CheckNumsSpeltOut(string sentence)
        {
            sentence = sentence.Replace(",", "");
            sentence = sentence.Replace(".", "");

            string[] wArray = sentence.Split(" ");

            for (int i = 0; i < wArray.Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (wArray[i] == j.ToString())
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

            if (numQuotes % 2 == 0) { evenNum = true; }

            return evenNum;

        }

        bool IsFirstCapital(char[] cArray)
        {
            if (cArray[0].ToString().ToUpper() == cArray[0].ToString())
            {
                return true;
            }

            return false;
        }





    }
}
