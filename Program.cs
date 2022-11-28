//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int [] ThreeDigRandomArray (int size)   
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray (int [] array)     
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumEvenNum(int[] array)
{
    int SumEven = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        {
            SumEven += array[i];
            count++;
        }
    return count;
}

Console.WriteLine("Input size if array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] createArray = ThreeDigRandomArray(arraySize);
ShowArray(createArray);

int evenNum = SumEvenNum(createArray);
Console.WriteLine($"Summ of even elements is {evenNum} ");
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int [] RandomElemArray (int size, int minValue, int maxValue)   
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray (int [] array)     
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOddElements(int[] array)
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

int [] newArray = RandomElemArray(lenght, minSegment, maxSegment);
ShowArray(newArray);
int resultOddSum = SumOddElements(newArray);
Console.WriteLine($"The sum of odd array elements is {resultOddSum} ");
*/



//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Random().NextDouble(); - генерирует значения От 0 до 1 
// newArray[i] = new Random().Next(minValue, maxValue +1) + Random().NextDouble(); для получения double элементов
// Math.Round(newArray[i], 3); - округление до 3-х знаков после запятой

//Вариант 1

/*
double [] CreateRandomArray (int size, int min, int max)   //метод создания массива с рандом эл-ами - double
{
    double[] newArray = new double [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round (new Random().Next(min, max +1) + new Random().NextDouble(), 3);  // либо решить каждый в отдельной переменной и сложить результаты
        
    }
    return newArray;
}

void ShowArray (double [] array)     
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double MinElemArray(double[] array)
{
    double numMin = array[0];

    for(int i = 0; i < array.Length; i++)
        if (numMin  >  array[i])
            numMin = array[i];
    return numMin;
}

double MaxElemArray(double[] array)
{
    double numMax = array[0];

    for(int i = 0; i < array.Length; i++)
        if (numMax  < array[i])
            numMax = array[i];  
    return numMax; 
}

Console.WriteLine("Enter your array size: ");
int length = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the minimum segment of your array : ");
int minSegment = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the maximum segment of your array : ");
int maxSegment = Convert.ToInt32 (Console.ReadLine());

double [] newArray = CreateRandomArray(length, minSegment, maxSegment);
ShowArray(newArray);
double MinValue = MinElemArray(newArray);
double MaxValue = MaxElemArray(newArray);
double diffMaxMin = MaxValue - MinValue;

Console.WriteLine($"The difference between max {MaxValue} and minimum {MinValue} element of the array is {diffMaxMin}");
*/

//Вариант 2

/*
double [] CreateRandomArray (int size, int min, int max)   //метод создания массива с рандом эл-ами - double
{
    double[] newArray = new double [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round (new Random().Next(min, max +1) + new Random().NextDouble(), 3);  // либо решить каждый в отдельной переменной и сложить результаты
        
    }
    return newArray;
}

void ShowArray (double [] array)     
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double diffElemArray(double[] array)
{
    double numMax = array[0];
    double numMin = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > numMax)
            numMax = array[i];
        if (array[i] < numMin)
            numMin = array[i];
    }
    
    return numMax - numMin; 
}

Console.WriteLine("Enter your array size: ");
int length = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the minimum segment of your array : ");
int minSegment = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Enter the maximum segment of your array : ");
int maxSegment = Convert.ToInt32 (Console.ReadLine());

double [] newArray = CreateRandomArray(length, minSegment, maxSegment);

ShowArray(newArray);
double diffMaxMin = diffElemArray(newArray);


Console.WriteLine($"The difference between max and having an array is {diffMaxMin} ");
*/