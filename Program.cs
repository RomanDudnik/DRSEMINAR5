﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// Random().NextDouble(); - генерирует значения От 0 до 1 
// newArray[i] = new Random().Next(minValue, maxValue +1) + Random().NextDouble(); для получения double элементов
// Math.Round(newArray[i], 3); - округление до 3-х знаков после запятой

int [] CreateRandomArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1) + Random().NextDouble();   // либо решить каждый в отдельной переменной и сложить результаты
        Math.Round(newArray[i], 3);
    return newArray;
}