using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeClass
{
    public class OldPhonePadClass
    {
        public static string OldPhonePad(string input)
        {
            Dictionary<char, string> PhoneNumber = new Dictionary<char, string>() //create variable to store all alphabet 
            {
                // 1 is special alphabet we dont need to use 
                { '2', "ABC" }, { '3', "DEF" }, { '4', "GHI" },
                { '5', "JKL" }, { '6', "MNO" }, { '7', "PQRS" },
                { '8', "TUV" }, { '9', "WXYZ" }, { '0', "" }
            };

            string answer = string.Empty; // create variable to store asnwer alphabet
            int cout = 0;
            while (cout < input.Length - 1) // check length of number
            {
                if (char.IsDigit(input[cout])) //check input is number?
                {
                    int continueNumber = cout;

                    while (continueNumber < input.Length - 1 && input[continueNumber] == input[continueNumber + 1]) //check input is same number?
                    {
                        continueNumber++;
                    }

                    int countConNum = continueNumber - cout + 1; // count how many times that number is repeated 
                    char key = input[cout];

                    if (PhoneNumber.ContainsKey(key))
                    {
                        string apbs = PhoneNumber[key]; // find alphabet in dictionary
                        int index = (countConNum - 1) % apbs.Length; //check alphabet in dictionary
                        char apb = apbs[index]; // select alphabet from dictionary
                        answer += apb; // add alphabet in output
                    }

                    cout = continueNumber + 1; // skip number before 
                }
                else if (input[cout] == ' ')
                {
                    answer += ' ';
                    cout++;
                }
                else if (input[cout] == '*')
                {
                    if (answer.Length > 0)
                    {
                        answer = answer.Substring(0, answer.Length - 1); // if input is * and length of output not equal 0 delete last alphabet from output
                    }
                    cout++;
                }
                else
                {
                    answer += '?';
                    cout++;
                }
            }

            return new string(answer.Where(letter => !char.IsWhiteSpace(letter)).ToArray());
        }
    }
}