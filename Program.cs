//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int [] ThreeDigRandomArray (int size)   //метод создания массива с рандом трехзначными эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(99, 1000);
    return newArray;
}

void ShowArray (int [] array)     // метод демонстрации массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumEvenNum(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            SumEven += array[i];
    return SumEven;
}

Console.WriteLine("Input size if array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] createArray = ThreeDigRandomArray(arraySize);
ShowArray(createArray);

int even = SumEvenNum(createArray);
Console.WriteLine($"Summ of even elements is {even} ");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int [] RandomElemArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray (int [] array)     // метод демонстрации массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOddNum(int[] array)
{
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0)
            sumOdd += array[i];
    return sumOdd;
}

Console.WriteLine("Enter your array size: ");
int lenght = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the minimum segment of your array : ");
int minSegment = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the maximum segment of your array : ");
int maxSegment = Convert.ToInt32 (Console.ReadLine());

int [] array = RandomElemArray(lenght, minSegment, maxSegment);
ShowArray(array);
int resultOddSum = SumOddNum(array);
Console.WriteLine($"The sum of odd array elements is {resultOddSum} ");




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Random().NextDouble(); - генерирует значения От 0 до 1 
// newArray[i] = new Random().Next(minValue, maxValue +1) + Random().NextDouble(); для получения double элементов
// Math.Round(newArray[i], 3); - округление до 3-х знаков после запятой

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1) + Random().NextDouble();   // либо решить каждый в отдельной переменной и сложить результаты
        Math.Round(newArray[i], 3);
    return newArray;
}
*/