// 4.Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
// 
// Test Data --
// Input a string : RADAR
// Expected Output : The string is Palindrome.

using System.Collections;

Console.WriteLine("Assignment_5_2_4: check whether a string is Palindrome using recursion \n");
// ----------------------------------
while (true)
{
    // define test cases
    string[] testStrs = ["123454321", " 12321 ", "123221", "24322", "radar", "radadar", "amanaplanacanalpanama", "raddadar", "raddfar"];
    Random random = new();
    string testStr = testStrs[random.Next(testStrs.Length)];

    Console.WriteLine($"testing '{testStr}'");

    


    if (IsThisPalindrome(0, testStr, true)) 
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
    







    if (DoesUserWantToQuit() == true) { break; }
}
// ----------------------------------




bool IsThisPalindrome (int i, string s, bool result) 
{
    // 1. base condition to exit is if we reach halfway point in string
    if (i >= (s.Length/2))
        return result;

    
    bool retVal = result;
    // 2. action: test if s[i] is diff from s[(len-1)-i], return false immediately if so
    if (s[i] != s[(s.Length - 1) - i]) 
    {
        Console.WriteLine($"     [{s[i]} != {s[(s.Length - 1) - i]}] ");
        return false;
    }
    else
    {
        Console.WriteLine($"     [{s[i]} == {s[(s.Length - 1) - i]}] ");
    }

    // 3. recursive call (occurs after action here to save cycles)
    return IsThisPalindrome(i + 1, s, retVal);

    
    // (tail action here absent because using head recursion here, BEFORE recursion)
}





// ----------------------------------


















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