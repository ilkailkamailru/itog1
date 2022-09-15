// See https://aka.ms/new-console-template for more information
/*Задача: Написать программу, которая из имеющегося массива
 строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

string [] VVodPrimerov(int t) // тупой способ охватить кучу примеров
{string [] rez;
    switch (t)
    {
     case   0: rez=new string[] {"hello", "2", "world", ":-)"};break;
     case   1: rez=new string[] {"1234", "1567", "-2", "computer science"};break;
     case   2: rez=new string[] {"Russia", "Denmark", "Kazan"};break;
     default: rez=new string[] {};break;
    }
    return rez;
}
void PrintMas(string [] mas)
{   if (mas.GetLength(0)==0)
        return;
    Console.Write("[\"");
    for (int i = 0; i < mas.GetLength(0)-1; i++)
        Console.Write($"{mas[i]}\",\"");
    Console.Write($"{mas[mas.GetLength(0)-1]}\"] -> [");
}
{string [] masiv;
    Console.Write("задача \n");
    for (int i = 0; i < 3; i++)// количество примеров можно менять
    {
        masiv=VVodPrimerov(i);//ввод исходных примеров
        if (masiv.GetLength(0)==0)
            continue;
        PrintMas(masiv);
        int count=0;
        string [] rezmas = new string[masiv.GetLength(0)];
        for (int x = 0; x < masiv.GetLength(0); x++)
            if (masiv[x].Length<=3)
                rezmas[count++]=masiv[x];// это заносим в массив)))
        for (int x = 0; x < count; x++)
            Console.Write($"\"{rezmas[x]}\"{((x<count-1)?",":"")}");
        Console.WriteLine("]");
    }
Console.WriteLine("конец задаче");
}
