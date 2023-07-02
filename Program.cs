// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

static string[] ReadInputArray()
{
    Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(' ');
    return inputArray;
}

static string[] FilterStrings(string[] inputArray)
{
    int count = 0;
    
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}

static void PrintResultArray(string[] resultArray)
{
    Console.WriteLine("Новый массив:");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write(resultArray[i] + " ");
    }
}


void Complex()
{
    string[] inputArray = ReadInputArray();

    string[] resultArray = FilterStrings(inputArray);

    PrintResultArray(resultArray);
}

Complex();

