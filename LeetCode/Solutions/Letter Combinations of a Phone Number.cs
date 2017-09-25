using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Letter_Combinations_of_a_Phone_Number
{
    //https://leetcode.com/problems/letter-combinations-of-a-phone-number/

    /*
     * Given a digit string, return all possible letter combinations that the number could represent.
     * A mapping of digit to letters (just like on the telephone buttons) is given below.
     * Input:Digit string "23"
     * Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
     * Note:
     * Although the above answer is in lexicographical order, your answer could be in any order you want. 
     */
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> list = new List<string>();
            Dictionary<char, char[]> dict = new Dictionary<char, char[]>();
            dict.Add('2', new char[] { 'a', 'b', 'c' });
            dict.Add('3', new char[] { 'd', 'e', 'f' });
            dict.Add('4', new char[] { 'g', 'h', 'i' });
            dict.Add('5', new char[] { 'j', 'k', 'l' });
            dict.Add('6', new char[] { 'm', 'n', 'o' });
            dict.Add('7', new char[] { 'p', 'q', 'r', 's' });
            dict.Add('8', new char[] { 't', 'u', 'v' });
            dict.Add('9', new char[] { 'w', 'x', 'y', 'z' });
            dict.Add('0', new char[] { '0' });
            dict.Add('1', new char[] { '1' });
            foreach (char digit in digits)
            {
                foreach(char c in dict[digit])
                {

                }
            }
            return list;
        }

        public void Run()
        {
            string input = "234";
            IList<string> list = LetterCombinations(input);
        }
    }
}
