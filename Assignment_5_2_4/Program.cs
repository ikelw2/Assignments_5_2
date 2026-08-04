// 4.Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
// 
// Test Data --
// Input a string : RADAR
// Expected Output : The string is Palindrome.

Console.WriteLine("Assignment_5_2_4: check whether a string is Palindrome using recursion \n");
// ----------------------------------
while (true)
{
    // create random arrangement of string with words of different length
    Random random = new Random();
    int randSize = random.Next(15);

    // print out test string
    Console.Write($"First {randSize} natural numbers are: \n");




    // print out from 1 to x INCREASING
    recursiveNaturalUp(1, randSize);

    Console.WriteLine();

    // print out from x to 1 DECREASING
    recursiveNaturalDown(1, randSize);






    if (DoesUserWantToQuit() == true) { break; }
}
// ----------------------------------
// to print from 1 to x (natural number), I need to:
//
// #1 use a BASE CASE to stop the loop
// #2 print the current number (either #2 or #3 depending upon desired order
// #3 call recursive function with next number
//
// ----------------------------------
void recursiveNaturalUp(int x, int max)
{
    if (x > max) // base case
        return;

    Console.Write(x + " "); // print the output before the recursive function calls,
                            // mean it's a HEAD recursion, prints in forward order

    recursiveNaturalUp(x + 1, max); // recursive step - call the function with the next number
}
// ----------------------------------

void recursiveNaturalDown(int x, int max)
{
    if (x > max) // base case
        return;

    recursiveNaturalDown(x + 1, max); // recursive step - call the function with the next number

    Console.Write(x + " "); // print the output after the recursive function calls,
                            // means it's a TAIL recursion, prints in reverse order
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