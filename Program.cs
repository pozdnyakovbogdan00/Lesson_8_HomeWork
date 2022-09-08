int Answer = Program_Main_InputData();

switch (Answer)
{
    case 1: arrange_array.arrange_array_method(); break;  
    case 2: summ_string.summ_string_method(); break;
    case 3: three_dimensional_array.three_dimensional_array_method(); break;
    case 4: matrix_multiplication.matrix_multiplication_method(); break;
    default: Console.WriteLine("You have entered an invalid value (Enter 1 - 4)."); break;
}

// START Procedures and functions

static int Program_Main_InputData()
{
    Console.WriteLine("Choose one of the suggested values: ");
    Console.WriteLine("1: Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("2: Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("3: Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    Console.WriteLine("4: ** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine("Your choice? ");
    int InputData = Convert.ToInt32(Console.ReadLine());
    
    return InputData; 
}

// END Procedures and functions



