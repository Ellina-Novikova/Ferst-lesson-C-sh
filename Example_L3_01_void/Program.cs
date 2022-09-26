// 1. void метод без аргументов

// void Method1()
// {
//     Console.WriteLine("Привет!");
// }
// Method1();


// 2. void метод с аргументами

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Text");


// 2.1 void метод с именованными аргументами

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
   
}
//Method21("Text", 4);
//Method21(msg: "Text", count: 4);
Method21(count: 4, msg:"Text");  // в таком случае очередность аргументов не имеет значения
