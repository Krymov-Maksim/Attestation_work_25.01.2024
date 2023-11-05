// Аттестационная работа по Первому блоку

void ShowArray(string[] array)                      // Метод вывода массива на консоль
{Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write("]");
}


Console.Clear();                                    // Main (Начало)

string[] array1 = { "Hello", "Hi", ". ", "3,14159", "Max", "Progggrammm", "!", "This is end" };
// int n = NumberConditions (array1);
// string array2 = CreateArray2(n, array1);
ShowArray(array1);
// ShowArray (array2);

