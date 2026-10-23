Console.Write(" as you ");
Console.Write("see the diff \n");
Console.WriteLine("getting started \n ok\n\t try this use ('\\' double)  for typing the path to the file, I do not know what is it but let's try \"Hi!\"");

// string favoritecolor = Console.ReadLine();
// Console.WriteLine("oh i love "  + favoritecolor + " too");

string name = "Alex";
Console.WriteLine($"Hello, {name}");

// string name2 = Console.ReadLine()";
// Console>writeLine($"Hello, {name2}");

// string (.ToUpper, .ToLower,
//  .Trim-- removws white spaces from the beginning and end,
//  .Length,
//  .Substring(startIndex, Length) -- returns a substring from the string starting at the  index and with the specified length,
//  .Replace(old,new),
//  .Contains -- checks if the string contains a specified substring,
//  .StartsWith -- checks whether the string begins with some text,
//  .EndsWith,
//  .IndexOf -- like .index in python, .LastIndexOf,
//  .Split -- splits the string into an array of substrings,
//  .Join -- string.Join(", ", new[] { "red", "blue" }) → "red, blue",
//  .Format, .IsNullOrEmpty, .IsNullOrWhiteSpace)


string? text = Console.ReadLine();
if (int.TryParse(text, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"The number {number} is even.");
    }
    else
    {
        Console.WriteLine($"The number {number} is odd.");
    }
    Console.WriteLine($"You entered the number: {number}");
}
else
{
    Console.WriteLine("Invalid input. Please enter an integer.");
}


if (int.TryParse(text, out int daynumber))
{
switch (daynumber)
    {
        case > 0 and < 6:
            Console.WriteLine("It's a weekday.");
            break;
        case 6 or 7:
            Console.WriteLine("It's a weekend.");
            break;
        default:
            Console.WriteLine("Invalid day number. Please enter a number between 1 and 7");
            break;
    }
}