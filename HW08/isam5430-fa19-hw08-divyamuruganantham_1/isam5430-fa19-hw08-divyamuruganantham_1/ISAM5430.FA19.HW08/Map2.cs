using System;
using System.Collections.Generic;
using System.Text;

namespace isam5430_fa19_hw08_divyamuruganantham_1.ISAM5430.FA19.HW08
{
    public class Map2
    {
        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, 
        /// always with the value 0. For example the string "hello" makes the pair "hello":0. We'll do more complicated counting later, 
        /// but for this problem the value is simply 0.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> Word0(string[] strings)
        {
            var dict = new Dictionary<string, int>();
            if (strings is null || strings.Length == 0) return dict;
            for (int i = 0; i < strings.Length; i++)
            {
                int count = 0;
                for (int j = i; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j]) count++;
                }
                if (count == 1) dict.Add(strings[i], 0);
            }
            return dict;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<string, int> containing a key for every different string in the array, and the value is that string's length.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordLen(string[] strings)
        {
            var dict = new Dictionary<string, int>();
            if (strings is null || strings.Length == 0) return dict;
            for (int i = 0; i < strings.Length; i++)
            {
                int count = 0;
                for (int j = i; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j]) count++;
                }
                if (count == 1) dict.Add(strings[i], strings[i].Length);
            }
            return dict;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, create and return a Dictionary<string, string> as follows: 
        /// for each string add its first character as a key with its last character as the value.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> Pairs(string[] strings)
        {
            var dict = new Dictionary<string, string>();
            if (strings is null || strings.Length == 0) return dict;
            foreach (string word in strings)
            {
                if (!dict.ContainsKey(word[0].ToString()))
                    dict.Add(word[0].ToString(), word[word.Length - 1].ToString());
            }
            return dict;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// The classic word-count algorithm: given an array of strings, 
        /// return a Dictionary<string, int> with a key for each different string, with the value the number of times that string appears in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, int> WordCount(string[] strings)
        {
            var dict = new Dictionary<string, int>();
            if (strings is null || strings.Length == 0) return dict;
            for (int i = 0; i < strings.Length; i++)
            {
                int count = 0;
                for (int j = i; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j]) count++;
                }
                if (count == 1)
                    dict.Add(strings[i], count);
                else
                    if (dict.ContainsKey(strings[i])) dict[strings[i]] = count;
            }
            return dict;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of non-empty strings, return a Dictionary<string, string> with a key for every different first character seen, 
        /// with the value of all the strings starting with that character appended together in the order they appear in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, string> FirstChar(string[] strings)
        {
            var dict = new Dictionary<string, string>();
            if (strings is null || strings.Length == 0) return dict;
            foreach (string str in strings)
            {
                if (dict.ContainsKey(str[0].ToString())) dict[str[0].ToString()] += str;
                else dict[str[0].ToString()] = str;
            }
            return dict;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Loop over the given array of strings to build a result string like this: 
        /// when a string appears the 2nd, 4th, 6th, etc. time in the array, append the string to the result. Return the empty string if no string appears a 2nd time.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string WordAppend(string[] strings)
        {
            var dict = new Dictionary<string, int>();
            string str = "";
            if (strings is null || strings.Length == 0) return str;
            for (int i = 0; i < strings.Length; i++)
            {
                if (!dict.ContainsKey(strings[i])) dict[strings[i]] = 0;
                if (dict.ContainsKey(strings[i]))
                {
                    dict[strings[i]]++;
                    if (dict[strings[i]] % 2 == 0)
                        str += strings[i];
                }
            }

            return str;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of strings, return a Dictionary<String, bool> 
        /// where each different string is a key and its value is true if that string appears 2 or more times in the array.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public Dictionary<string, bool> WordMultiple(string[] strings)
        {
            var dict = new Dictionary<string, int>();
            var dict1 = new Dictionary<string, bool>();
            if (strings is null || strings.Length == 0) return dict1;
            for (int i = 0; i < strings.Length; i++)
            {
                if (!dict.ContainsKey(strings[i])) dict[strings[i]] = 0;
                if (dict.ContainsKey(strings[i]))
                {
                    dict[strings[i]]++;
                    if (dict[strings[i]] >= 2)
                        dict1[strings[i]] = true;
                }
            }

            return dict1;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. 
        /// Loop over and then return the given array of non-empty strings as follows: if a string matches an earlier string in the array, 
        /// swap the 2 strings in the array. When a position in the array has been swapped, it no longer matches anything. 
        /// Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] AllSwap(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            if (strings is null || strings.Length == 0) return new string[0];

            for (int i = 0; i < strings.Length; i++)
            {
                if (!dict.ContainsKey(strings[i])) dict[strings[i]] = i;
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j]) dict[strings[i]] = j;
                    if (strings[i].Substring(0, 1) == strings[j].Substring(0, 1) && dict[strings[i]] == i)
                    {
                        string temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                        dict[strings[i]] = j;
                        dict[strings[j]] = i;
                        break;
                    }
                }
            }
            return strings;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// We'll say that 2 strings "match" if they are non-empty and their first chars are the same. 
        /// Loop over and then return the given array of non-empty strings as follows: 
        /// if a string matches an earlier string in the array, swap the 2 strings in the array. 
        /// A particular first char can only cause 1 swap, so once a char has caused a swap, its later swaps are disabled. 
        /// Using a Dictionary, this can be solved making just one pass over the array. More difficult than it looks.
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public string[] FirstSwap(string[] strings)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            if (strings is null || strings.Length == 0) return new string[0];
            bool flag = false;
            for (int i = 0; i < strings.Length; i++)
            {
                if (!dict.ContainsKey(strings[i])) dict[strings[i]] = i;
                for (int j = i + 1; j < strings.Length; j++)
                {
                    if (strings[i] == strings[j]) dict[strings[i]] = j;
                    if (strings[i].Substring(0, 1) == strings[j].Substring(0, 1) && !flag && dict[strings[i]] == i && !dict1.ContainsKey(strings[i].Substring(0, 1)))
                    {
                        string temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                        dict[strings[i]] = j;
                        dict[strings[j]] = i;
                        dict1[strings[i].Substring(0, 1)] = 1;
                        break;
                    }
                }
            }
            return strings;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Given a string, count the number of unique characters in the string.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>The unique characters.</returns>
        /// <remarks>
        /// Null and empty strings both count as zero unique characters. 
        /// You can determine the length of this Boolean array with char.MaxValue + 1. 
        /// Thus, you can create a Boolean array with a length of char.MaxValue + 1
        /// to tag each character in a string. 
        /// As char is compatible with int, you will need to use 
        /// each char from the string as an index to this Boolean array, 
        /// hence incrementing the counter when a new character is first seen,
        /// while iterating through all the characters in a string.</remarks>
        public int CountUniqueCharacters(string str)
        {
            if (str is null || str.Length == 0 || str == "") return 0;
            char[] ch = str.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (!dict.ContainsKey(ch[i]))
                {
                    dict[ch[i]] = 1;
                    count++;
                }
            }
            return count;
            //throw new NotImplementedException();
        }
    }
}
