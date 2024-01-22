//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int number = 458659;

int CountDigits(int num)
{
    string numToString = num.ToString();
    int numLength = numToString.Length;
    Console.Write($"{numLength} - количество цифр в введенном числе; ");

    int numSum = 0;

    for (int i = 0; i < numLength; i++)
    {
        numSum += num % 10;
        num = num / 10;
    }

    Console.Write($"{numSum} - сумма цифр в числе");

    return numSum;
}

while (input%2 != 0 && input !="q")
{
    Console.WriteLine("Введите целое число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int input = CountDigits(number);
    
}
//Так и не понял как решить ошибку с областью определения переменных, чтобы их можно было использовать как условите в цикле while

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное трехзначное число: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное трехзначное число: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size1, min1, max1);

ShowArray(array);
Console.WriteLine(" ");

void FindCountDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    Console.WriteLine($"{count} - количество чётных чисел в массиве");
}
FindCountDigits(array);
*/
//Задача 3: Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
//Сформируйте целое число, которое будет состоять из цифр из массива. 
//Старший разряд числа находится на 0-м индексе, младший – на последнем.

/*
Console.WriteLine("Введите размер массива(не более8): ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное целое число(от 0 до 9): ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное целое число(от 0 до 9): ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size1, min1, max1);

ShowArray(array);
Console.WriteLine(" ");

void ArrayToNumber(int[] array)
{
    double number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        number += array[i] * Math.Pow(10, (array.Length - i - 1));
        Console.WriteLine($"{number} - целое число на {i} итерации");
        Console.WriteLine(" ");
    }
    Console.WriteLine($"{number} - целое число, которое состоит из цифр из массива");
}
ArrayToNumber(array);
*/