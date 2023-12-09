Console.Clear();

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string str = "BoRiS_RaZoR";

string FromUpperToLower(string str)
{
    string newStr = String.Empty;
    foreach (char item in str)
    {
        newStr += char.ToLower(item);
    }
    return newStr;
}

Console.WriteLine(str);
Console.WriteLine(
    FromUpperToLower(str));