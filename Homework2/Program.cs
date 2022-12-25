// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Сейчас будем узнавать третью цифру числа, введите число состоящее из ТРЕХ и более чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringnumber=Convert.ToString(number);

if (number<100)
 Console.WriteLine ("ты обманщик, третьей цифры нет");

else
 Console.WriteLine ("третья цифра это " + stringnumber[2]);
