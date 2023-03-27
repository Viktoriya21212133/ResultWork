// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключитально массивами.

//Печать одномерного массива 
void Print1DArry(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{array[i]}]\t");
    }

}

// метод находит строки в массиве длиной не больше count
// И возвращает новый массив из строк
string [] GetNewArray(string [] arry, int count)
{   
    string [] result= new string [0];
    for (int index = 0; index < arry.Length; index++)
    {
        if (arry[index].Length<=count)
        {
            result = result.Concat(new string[] { arry[index] }).ToArray();
        }
    }
    return result;    
}

string [] strarray = new string[]{"hello","345","new string","world",":-","r2"};

string [] resultStrarry = GetNewArray(strarray,3);

Console.WriteLine("Исходный массив:");
Print1DArry(strarray);
Console.WriteLine();
Console.WriteLine("Массив из строк длина которых не больше 3:");

if(resultStrarry.Length!=0)
{
    Print1DArry(resultStrarry);
}else
{
    Console.WriteLine("Массив пустой!!!");
}