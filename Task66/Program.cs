// Задача 66: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("введите натуральное число M: ");
// int numberM= Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите натуральное число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// if(numberM < 1 || numberN < 1) 
// {
//     Console.WriteLine("Некорректный ввод!");
//     return;
// }

// // int RangNat1Numbers(numberM , numberN);


// int RangNat1Numbers(int numM, int numN)
// {
//     if(numM > numN)
//     {
//         Console.Write($"{numM} ");
//         RangNat1Numbers(numM -1, numN);
//     }
//     else if(numM <numN )
//     {
//         Console.Write($"{numM} ");
//         RangNat1Numbers(numM +1, numN);
//     }
//      else 
//      {
//         Console.Write($"{numM} ");
//      }

// }
// int rangNat = RangNat1Numbers(int numM, int numN);
// Console.WriteLine(rangNat);

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int rangNat = RangNat1Numbers(numberM, numberN);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN}: {rangNat}");


int RangNat1Numbers(int numM, int numN)
{
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        return numM + RangNat1Numbers(numM - 1, numN);
    }
    else if (numM < numN)
    {
        Console.Write($"{numM} ");
        return numM + RangNat1Numbers(numM + 1, numN);
    }
    else
    {
        Console.Write($"{numM} ");
        return numM;
    }
}



