// 2.Write a program in C# Sharp to print the first n natural number using recursion.
// 
// Test Data :
// How many numbers to print : 10
// Expected Output :
// 1 2 3 4 5 6 7 8 9 10

Console.WriteLine("Assignment_5_2_2-3: Print first N natural numbers using recursion, both upwards, and downwards \n");
// ----------------------------------
while (true)
{
    // create random arrangement of string with words of different length
    Random random = new Random();
    int randSize = random.Next(15);
    
    // print out test string
    Console.Write($"First {randSize} natural numbers are: \n");




    // print out from 1 to x INCREASING
    recursiveNaturalUp(randSize);
    //recursiveNaturalUp(1, randSize);

    Console.WriteLine();

    // print out from x to 1 DECREASING
    recursiveNaturalDown(randSize);
    //recursiveNaturalDown(1, randSize);






    if (DoesUserWantToQuit() == true) { break; }
}
// ----------------------------------
// to print from 1 to x (natural number), I need to:
//
// #1 use a BASE CASE to stop the loop
// 
// #2 ACTION: print the current number                     ( <-- either 2-3 or 3-2 depending upon desired order)
// #3 call recursive function with next number
//
// ----------------------------------
void recursiveNaturalUp(int x)
{
    if (x <= 0) // base case
        return;

    recursiveNaturalUp(x - 1); // recursive step - call the function with the next number

    Console.Write(x + " "); // ACTION (print the output) AFTER the recursive function calls,
                            // mean it's a TAIL recursion, prints in REVERSE order since recursively passing x - 1

}
// ----------------------------------

void recursiveNaturalDown(int x)
{
    if (x <= 0) // base case
        return;

    Console.Write(x + " "); // ACTION (print the output) BEFORE the recursive function calls,
                            // means it's a HEAD recursion, prints in proper order, since passing x - 1

    recursiveNaturalDown(x - 1); // recursive step - call the function with the next number
}
// ----------------------------------

// ----------------------------------
//void recursiveNaturalUp(int x, int max)
//{
//    if (x > max) // base case
//        return;

//    Console.Write(x + " "); // print the output before the recursive function calls,
//                            // mean it's a HEAD recursion, prints in forward order

//    recursiveNaturalUp(x + 1, max); // recursive step - call the function with the next number
//}
//// ----------------------------------

//void recursiveNaturalDown(int x, int max)
//{
//    if (x > max) // base case
//        return;

//    recursiveNaturalDown(x + 1, max); // recursive step - call the function with the next number

//    Console.Write(x + " "); // print the output after the recursive function calls,
//                            // means it's a TAIL recursion, prints in reverse order
//}
//// ----------------------------------













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