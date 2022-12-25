// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Сейчас мы будем узнавать в какой день ты свободный человек, введи цифру обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

switch (Number)
{
case 1:
 Console.WriteLine("Это Понедельник");
 break;

case 2:
 Console.WriteLine("Это Вторник"); 
 break;

case 3:
 Console.WriteLine("Это Среда"); 
 break;

case 4:
 Console.WriteLine ("Это Четверг"); 
 break;

case 5:
 Console.WriteLine("Это Пятница"); 
 break;

case 6:
 Console.WriteLine("Это Субота"); 
 break;

case 7:
 Console.WriteLine ("Это Воскресенье");
 break;

default:
 Console.WriteLine ("В неделе семь дней");
 break;
}

if (Number<=5)

Console.WriteLine ("Иди работать, солнце еще высоко, сегодня будний день");

if (Number == 6 || Number == 7 )

Console.WriteLine ("Иди спи, сегодня выходной день");

if (Number>=8)
Console.WriteLine ("Попробуй еще раз");

