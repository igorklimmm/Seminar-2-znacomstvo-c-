// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.Write("Введите трех значное число ");
 int number = Convert.ToInt32(Console.ReadLine());
 string stringnumber=Convert.ToString(number);

if (number>0)
 Console.WriteLine ("вторая цифра это " + stringnumber[1]);
 
if (number<0)
 Console.WriteLine ("вторая цифра это " + stringnumber[2]);
 