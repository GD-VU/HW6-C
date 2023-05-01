Console.Clear();

// ввод чисел пользователем

int input(string message)
{
    System.Console.Write(message);
    string line = System.Console.ReadLine();
    int result = Convert.ToInt32(line);
    return result;
}

// подсчет положительных чисел

int count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

// Введение чисел в массив

int [] InputArray(int length)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = input($"Введите {i+1}-й этемент: ");
    }
    return array;
}

// печать массива

void PrintArray (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int length = input("Введите количество элементов: ");
int [] array;
array = InputArray(length);
PrintArray(array);

System.Console.WriteLine($"Количество чисел больше нуля - {count(array)}");