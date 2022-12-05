// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначаьлный ммассив можно ввести с клавиатуры, либо задать на 
// старте выпонения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
//




string[] InputArrayStrings()
{
    string[] arrayStrings1 = new string[] { "hello", "2", "world", ":-)" };
    string[] arrayStrings2 = new string[] { "1234", "1567", "-2", "computer science" };
    string[] arrayStrings3 = new string[] { "Russia", "Denmark", "Kazan" };
    int rnd = new Random().Next(1, 4);
    switch (rnd)
    {
        case 1:
            return arrayStrings1;
        case 2:
            return arrayStrings2;
        default:
            return arrayStrings3;
    }
}

void PrintArray(string[] arrayOfStrings)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        Console.Write($"\"{arrayOfStrings[i]}\"");
        if (i<arrayOfStrings.Length-1) Console.Write(", ");
    }
    Console.Write("]");
}

string[] SelectStringsLessThree(string[] incArrayStrings)
{
    int size = 0;
    for (int i = 0; i < incArrayStrings.Length; i++)
    {
        if (incArrayStrings[i].Length<=3) 
            size++;
    }
    string[] selStringsLessThree = new string[size];
    int count = 0;
    for (int i = 0; i < incArrayStrings.Length; i++)
    {
        if (incArrayStrings[i].Length<=3) 
            selStringsLessThree[count++] = incArrayStrings[i];
    }
    return selStringsLessThree;
}

string[] arrayStrings = InputArrayStrings();
PrintArray(arrayStrings);
string[] selectStringsLessThree = SelectStringsLessThree(arrayStrings);
Console.Write(" -> ");
PrintArray(selectStringsLessThree);
