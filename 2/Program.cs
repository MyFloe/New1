// // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// // 456 -> 46
// // 782 -> 72
// // 918 -> 98


int x =new Random().Next(100,1000);
Console.WriteLine(x);

 int x1=x/100;
 int x2=x%10;
Console.WriteLine($"{x1}{x2}");

// Console.WriteLine("Введите первое число");
// int a=Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b=Convert.ToInt32 (Console.ReadLine());

// if (a %b ==0) Console.WriteLine("кратно");
// else
// {
//     int c = a %b;
//     Console.WriteLine($"Не кратно, остаток {c}");

// }
