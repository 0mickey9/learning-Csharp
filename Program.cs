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
Console.Write("do yo want to launch block with reading commands? (1/0): ");
if (Console.ReadLine() == "1")
{
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

    Console.Write("Enter a string: "); 
    string text1 = Console.ReadLine() ?? string.Empty;

    for (int index = text1.Length - 1; index >= 0; index--)
    {
        Console.Write(text1[index]);
    }
    Console.WriteLine("\n" + text1);

    string phrase = " Hello, World! ";
    string cleaned_phrase = phrase.Trim(); // Remove leading and trailing whitespace
    Console.WriteLine($"Original phrase: '{phrase}'");
    Console.WriteLine($"Cleaned phrase: '{cleaned_phrase}'");

    string word1 = "Computer";
    Console.WriteLine(word1.Substring(2,3)); // mpu

    string email = "user@example.com";
    int position = email.IndexOf("@"); // якщо не знайдено, то повертає -1
    string message = "cat and dog";
    string changes = message.Replace("cat", "dog");
    Console.WriteLine(changes); 

    Console.Write("Enter your email: ");
    string text2 = Console.ReadLine() ?? string.Empty;
    text2 = text2.Trim();
    Console.WriteLine($"You entered: {text2.Substring(0, text2.IndexOf("@")) }");


    Console.Write("Try to write exit");
    string user = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrEmpty(user))
    {
        Console.WriteLine("You entered an empty string.");
    }
    else
    {
        user = user.Trim();
        user = user.ToLower();
        if (user == "exit")
        {
            Console.WriteLine("Exiting");
        }
        else
        {
            Console.WriteLine("You entered wrong input" );
        }
    }
}
else
{
    Console.WriteLine("You chose not to launch the block.");
}



int Add(int a, int b)
{
    return a + b;
}
int total = Add(2,4);
Console.WriteLine($"The total is: {total}");

void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

decimal Average(int a, int b)
{
    return (decimal)(a + b) / 2;
}
Console.WriteLine($"The average is {Average(5, 10)}");

void Change(out int value1)
{
    value1 = 100;
}
int number1 = 5;
Change(out number1);
Console.WriteLine($"The changed value is: {number1}");

bool TryDivide(int a, int b, out decimal result)
{
    if (b == 0)
    {
        result = 0;
        return false;
    }
    else
    {
        result = (decimal)a / b;
        return true;
    }
}


static bool TryAverage(int a, int b, out decimal result)
{
    if (a < 0 || b < 0 )
    {
        result = 0;
        return false;
    }
    else
    {
        result = (decimal)(a + b)/ 2;
        return true;
    }
}

int[] numbers = new int[5]; // or int[] numbers = { 1, 2, 3, 4, 5 };
numbers[0] = 10; // Change the first element to 10
Console.WriteLine($"The first element is: {numbers[0]}");

// | Тип масиву | Початкове значення кожного елемента |
// | `int[]` | `0` |
// | `decimal[]` | `0m` |
// | `bool[]` | `false` |
// | `string?[]` | `null` |


for (int index = 0; index < numbers.Length; index++)
{
    Console.Write($"Element at index {index}: {numbers[index]}; ");
}
Console.WriteLine("\nUsing foreach loop:");
foreach (int num in numbers)
{
    Console.Write($"Element: {num}; ");
}

int[] values = { 4, -2, 7, 0, 3 };
int counter = 0;
int sum1 = 0;
foreach (int intnum in values)
{
    sum1 += intnum;
    if (intnum > 0)
    {
        counter++;
    }
}
Console.WriteLine($"\nThe sum of all numbers is: {sum1}");
Console.WriteLine($"The count of positive numbers is: {counter}");

int[] second = (int[])values.Clone(); // if you want to clone the array

values = new int[] { -8, -3, -12, -3};
int max = values[0];
int maxi = 0;
for (int i = 0; i < values.Length; i++)
{
    if (values[i] > max)
    {
        max = values[i];
        maxi = i;
    }
}
Console.WriteLine($"Maximum: {max}, index: {maxi}");
