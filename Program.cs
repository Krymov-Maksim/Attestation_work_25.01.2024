// Аттестационная работа по Первому блоку

using System.Globalization;
using System.Runtime.Serialization;

void ShowArray(string[] array)                // Метод вывода массива на консоль
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

int NumberConditions (string [] array)        // Метод подсчета количества элементов масива, удовлетворяющих условию
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count ++;
    }       
    return count;
}



Console.Clear();                                                                            // Main (Начало)
string[] array1 = { "Hello", "Hi", "3,14159", "Max", "Progggrammm", "!", "This is end" };   // 
int n = NumberConditions (array1);
string [] array2 = new string [n];

array2 = CreateArray2(n, array1, array2);
ShowArray(array1);
System.Console.Write("->");
ShowArray(array2);