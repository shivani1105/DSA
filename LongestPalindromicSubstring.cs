using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0) return "";

            bool[,] dp = new bool[n, n];
            int start = 0, maxLength = 1;

            // All substrings of length 1 are palindromes
            for (int i = 0; i < n; i++)
            {
                dp[i, i] = true;
            }

            // Check for substrings of length 2
            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for lengths greater than 2
            for (int len = 3; len <= n; len++)
            {
                for (int i = 0; i < n - len + 1; i++)
                {
                    int j = i + len - 1; // Ending index of current substring

                    // Check if the current substring is a palindrome
                    if (s[i] == s[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;

                        if (len > maxLength)
                        {
                            start = i;
                            maxLength = len;
                        }
                    }
                }
            }

            // Return the longest palindromic substring
            return s.Substring(start, maxLength);
        }
    }
}
