// 3. Метод без входного аргумента, возвращающий значение

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// 4. Метод, принимающий аргумент и возвращающий значение

string Method4(int count, string text)
{
    int i = 0;
    string result = "";  // string result = String.Empty;  обнуление строки
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "am");
Console.WriteLine(res);
