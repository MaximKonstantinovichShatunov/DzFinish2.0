﻿//Задача 13: Напишите программу, которая выводит третью
 //цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
if (A < 100 )
    {
        Console.Write( "третьей цифры нет");
    }
else  
    {
        int B = A % 1000/100;
    
    Console.Write( "Третье число  ");
    Console.WriteLine(B);
    }