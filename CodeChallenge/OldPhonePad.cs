using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePad {

    public static String OldPhonePad(string input) {

        Dictionary<string, string> PhoneNum = new Dictionary<string, string>() {
        // 1 is special alphabet we dont need to use 

        {'2', 'A'}, {'22', 'B'}, {'222', 'C'}, {'3', 'D'}, {'33', 'E'}, {'333', 'F'}, {'4', 'G'}, {'44', 'H'}, {'444', 'I'},
        {'5', 'J'}, {'55', 'K'}, {'555', 'L'}, {'6', 'M'}, {'66', 'N'}, {'666', 'O'}, {'7', 'P'}, {'77', 'Q'}, {'777', 'R'},
        {'7777', 'S'}, {'8', 'T'}, {'88', 'U'}, {'888', 'V'}, {'9', 'W'}, {'99', 'X'}, {'999', 'Y'}, {'9999', 'Z'}, {'0', ' '}
    };

        int cout = 0
        while (cout < input.Length - 1) {      // check length of number
            if (char.IsDigit(input[cout])) { //check input is number?
                string ans = string.Empty; // create variable to store alphabet
                int conNum = i;
                while (conNum < input.Length - 1 && input[conNum] == input[conNum + 1]) { //check input is same number?
                    conNum++;
                }
                int countConNum = conNum - i + 1; // count how many times that number is repeated 
                string apb = input[i];

                if (PhoneNum.ContainsKey(apb)) {
                    string value = new string(PhoneNum[apb], countConNum); // find alphabet in dictionary
                    ans += value; // add alphabet in output
                }

                cout = conNum + 1; // skip number before 
            } else if (input[cout] == ' ') {
                ans += ' ';
                cout++;
            } else if (input[cout] == '*') {
                ans = ans.TrimEnd();
                cout++;
            } else {
                ans += '?';
                cout++;
            }
        }

        return ans;
    }
}
