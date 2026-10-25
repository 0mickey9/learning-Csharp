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

Console.Write("Enter a number:");
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
else
{
    Console.WriteLine("Invalid input. Please enter an integer.");
}


int i = 0;
while (i < 3)
{
    Console.WriteLine($"While loop iteration: {i}");
    i++;
}

i = 10;

do
{
    Console.WriteLine($"Do-while loop iteration: {i}");
    i++;
} while (i < 3);

int userNumber;

do
{
    Console.WriteLine("Enter a number between 1 and 10:");

} while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 1 || userNumber > 10);


int n = int.TryParse(Console.ReadLine(), out int result ) ? result : 0;
int sum = 0;
for (int k = 1; k <= n; k++)
{
    sum += k;
}
Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");

for (int j = 1 ; j < 3; j++)
{
    if (j == 2)
    {
        Console.WriteLine("Раз не підарас, а от 2 то підарас");
        break;
    }
    if (j == 1)
    {
        Console.WriteLine("Раз підарас, то підарас");
        continue;
    }
    Console.WriteLine(j);
}

int x = 0;

// while (x < 5)
// {
//     if (x == 2)
//     {
//         continue;
//     }

//     Console.WriteLine(x);
//     x++; // х завжди залишатиметься на значенні 2
// }

for (int row = 1; row <= 2; row++)
{
    for (int col = 1; col <= 3; col++)
    {
        if (col == 2)
        {
            break; // Важливий нюанс: break завершує лише найближчий цикл.
        }

        Console.WriteLine($"{row}, {col}");
    }
}

for (int row1 = 1; row1 <= 4; row1++)
{
    for (int col1 = 1; col1 <= row1; col1++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

string word = "Hello";
char firstChar = word[0];
char lastChar = word[word.Length - 1];
Console.WriteLine('A' + 'B');   // 131
Console.WriteLine("A" + "B");   // AB
Console.WriteLine($"{'A'}{'B'}"); // AB
Console.WriteLine(word[^1]); // o: перший із кінця
Console.WriteLine("😀".Length); // 2

string text1 = Console.ReadLine() ?? string.Empty;

for (int index = text1.Length - 1; index >= 0; index--)
{
    Console.Write(text1[index]);
}
Console.WriteLine(text1);