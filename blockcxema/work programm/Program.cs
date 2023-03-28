void PrintArray(string[] array) // Создание массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i] + " ");
    }
    System.Console.WriteLine(); //Пустая строчка
}

System.Console.WriteLine("Количество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());// Заполняем массив

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine($"Введите {i + 1} элемент: "); 
    string symbol = Console.ReadLine()!;
    arrayStrings[i] = symbol;
}

string[] arrayFinal = new string[size];// Проверка массива согласно задания
int length = 3;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (arrayStrings[i].Length <= length)
    {
        arrayFinal[count] = arrayStrings[i];
        count++;
    }
}

System.Console.WriteLine();
PrintArray(arrayFinal);
