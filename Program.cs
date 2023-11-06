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
        if (array[i].Length < 4) count ++;
    }       
    return count;
}

string [] CreateArray2 (int n, string [] array1, string [] array2) // Метод заполенения второго массива
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4) 
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}


Console.Clear();                                                                            // Main (Начало)
string[] array1 = { "Hello", "Hi", "3,14159", "Max", "Progggrammm", "!", "This is end" };   // Первичный массив1 с данными
int n = NumberConditions (array1);
string [] array2 = new string [n];                     // Создан массив2 с необходимым количеством элементов n

array2 = CreateArray2(n, array1, array2);               // Заполнен новый массив2
ShowArray(array1);
System.Console.Write("->");
ShowArray(array2);