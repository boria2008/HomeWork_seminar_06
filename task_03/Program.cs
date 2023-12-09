Console.Clear();

// Задача 3: Задайте произвольную строку. 
//Выясните, является ли она палиндромом.

bool StringPalindrom(string str)
{
    while (true)
    {
        for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] == str[j])
            {
                return true;
            }
            return false;
        }

    }
}
Console.WriteLine("Enter a string");
if (StringPalindrom(Console.ReadLine()))
{
    Console.WriteLine("Palindrom");
}
else Console.WriteLine("Not palindrom");