using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("222 2 22"));
            Console.WriteLine(OldPhonePad("33#"));
            Console.WriteLine(OldPhonePad("227*#"));
            Console.WriteLine(OldPhonePad("4433555 555666#"));
            Console.WriteLine(OldPhonePad("8 88777444666*664#"));
            Console.ReadLine();

        }

        public static String OldPhonePad(string input) // create function Phone Pad Number
        {

            Dictionary<char, string> PhoneNum = new Dictionary<char, string>() { 
            
                // 1 is special alphabet we dont need to use 
                { '2', "ABC" }, { '3', "DEF" }, { '4', "GHI" },
                { '5', "JKL" }, { '6', "MNO" }, { '7', "PQRS" },
                { '8', "TUV" }, { '9', "WXYZ" }, { '0', "" }
            };

            string ans = string.Empty; // create variable to store alphabet
            int cout = 0;
            while (cout < input.Length - 1) {      // check length of number
                
                if (char.IsDigit(input[cout])) { //check input is number?
                    
                    int conNum = cout;
                    
                    while (conNum < input.Length - 1 && input[conNum] == input[conNum + 1]) { //check input is same number?
                        
                        conNum++;
                    }

                    int countConNum = conNum - cout + 1; // count how many times that number is repeated 
                    char key = input[cout];

                    if (PhoneNum.ContainsKey(key)) {

                        string apbs = PhoneNum[key]; // find alphabet in dictionary
                        int index = (countConNum - 1) % apbs.Length; //check alphabet in dictionary
                        char apb = apbs[index]; // select alphabet from dictionary
                        ans += apb; // add alphabet in output
                    }

                    cout = conNum + 1; // skip number before 

                } else if (input[cout] == ' ') { 
                    ans += ' ';
                    cout++;

                } else if (input[cout] == '*') {   
                    if (ans.Length > 0) 
                    {
                        ans = ans.Substring(0, ans.Length - 1);  // if input is * and length of output not equal 0 delete last alphabet from output
                    }
                    cout++;

                } else {
                    ans += '?';
                    cout++;
                }
            }
            return new string(ans.Where(letter => !Char.IsWhiteSpace(letter)).ToArray()); // delete space between charecter from ifelse in line 57
        }
    }
}



// how to store string  https://learn.microsoft.com/en-us/dotnet/api/system.string.empty?view=net-7.0 
// how to delete space between alphabet https://code-maze.com/replace-whitespaces-string-csharp/
// how to check input is number? https://learn.microsoft.com/en-us/dotnet/api/system.char.isdigit?view=net-7.0#system-char-isdigit(system-char)
// how to store all of alphabet  and use alphabet only we need  https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0
// how to show output with out '#' https://www.comscidev.com/13-%E0%B9%82%E0%B8%84%E0%B9%89%E0%B8%94-c-%E0%B8%95%E0%B8%B1%E0%B8%94%E0%B8%82%E0%B9%89%E0%B8%AD%E0%B8%84%E0%B8%A7%E0%B8%B2%E0%B8%A1-%E0%B9%82%E0%B8%94%E0%B8%A2%E0%B9%83%E0%B8%8A%E0%B9%89-substring/