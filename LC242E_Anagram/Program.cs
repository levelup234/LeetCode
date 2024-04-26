// See https://aka.ms/new-console-template for more information
using LC242E_Anagram;

string str1 = "listen";
string str2 = "silent";

AnagramChecker anagramChecker = new AnagramChecker();

if (anagramChecker.AreAnagrams(str1, str2))
    Console.WriteLine("The strings are anagrams");
else
    Console.WriteLine("The strings are not anagrams");