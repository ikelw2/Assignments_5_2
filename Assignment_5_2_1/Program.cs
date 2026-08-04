// 1.Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.
// 
// Example 1:
// Input: s = "Hello World"
// Output: 5
// Explanation: The last word is "World" with length 5.
//
// Example 2:
// Input: s = " fly me to the moon "
// Output: 4
// Explanation: The last word is "moon" with length 4.

// Input: s = "on the moon tiger choose"


Console.WriteLine("Assignment_5_2_1: return length of the last word in the string\n");
// ----------------------------------
while (true)
{
    // create random arrangement of string with words of different length
    Random random = new Random();
    // testing of this worked // string words = "a on\\ the] moon! tiger, choose- briefly. severely3";
    //string words = "a on the moon tiger choose briefly severely";
    string words = "1 22 333 4444 55555 666666 7777777 88888888";
    // split by space, order by a random number, and rejoin (used AI to provide test cases)
    string testStr = string.Join(" ", words.Split(' ').OrderBy(w => random.Next()));
    // testing of this worked // testStr = "a";
    // add spaces to add test case, worked //
    testStr = testStr + "  ";



    // print out test string
    Console.Write($"Testing '{testStr}' -> ");
    
    // test the array, print the results, see below for function
    Console.WriteLine(GetLengthOfLastWork(testStr));












    if (DoesUserWantToQuit() == true)
    {
        break;
    }
}
// ----------------------------------
int GetLengthOfLastWork (string s)
{
    // start at end of string and work backwards to find the last word

    // first trim off any trailing spaces
    //s = s.Trim();
    // if s has spaces at the end, remove them, not using of Trim, per guidance
    while (s[s.Length - 1] == ' ')
    {
        s = s.Remove(s.Length - 1);
    }
    
    // if string is empty return 0
    if (s.Length == 0)
        return 0;

    // method 1: use an integer to count size until space
    int count = 0;
    for (int i = (s.Length - 1); i >= 0; i--)
    {
        if (s[i] != ' ')
        {
            count++;
        }
        else 
        {
            if (count > 0) // if count registers length of a word, and we've found a space, break out of for loop
            {
                break;
            }
        }        
    }

    return count;



    //AI proposed something like this, which seems more efficient than the above
    //    // found the last word, now find the length
    //    int length = 0;
    //    while (i > 0 && s[i - 1] != ' ')
    //    {
    //        length++;
    //        i--;
    //    }
    //    Console.WriteLine($"Length of last word: {length}");
    //    return length;
    //}




}
// ----------------------------------
bool DoesUserWantToQuit()
{
    Console.WriteLine($"\nPress Q or ESC to quit or press any other key to continue.");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if ((keyInfo.Key == ConsoleKey.Q) || (keyInfo.Key == ConsoleKey.Escape))
    {
        return true;
    }
    Console.WriteLine("-------------------------------\n");
    return false;
}