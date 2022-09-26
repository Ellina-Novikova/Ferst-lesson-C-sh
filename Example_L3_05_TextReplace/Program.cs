// Задача: в заданном тексте заменить пробелы на черточки, к на К, С на с.

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;  // обнуление переменной result
    int length = text.Length;  // определили длину строки
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "Мощь и энергия эпохи Эллинизма отчетливо выражены в скульптуре." + 
" Среди наиболее динамичных произведений - Лаокоон," + 
" найденный близ Рима в эпоху Возрождения. Старые Сказки";
Console.WriteLine(text);
Console.WriteLine();

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);



