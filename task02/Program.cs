// int n = new Random().Next(10, 100);
// int n1 = n / 10;
// int n2 = n % 10;

// Console.WriteLine(n);
// if (n1 > n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);
//................................................................................
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

// int n = new Random().Next(100, 1000);
// Console.WriteLine(n);
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1 * 10 + n3);
//..................................................................................

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// Console.WriteLine("Insert number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("yes");
// else 
//     Console.WriteLine("no");
//.........................................................................

//  Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//  то программа выводит остаток от деления.

// Console.Write("n1 = ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("n2 = ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1 % n2 == 0)
//     Console.WriteLine("n1 is a multiple of n2");
// else
//     Console.WriteLine($"n1 is not a multiple of n2, the remainder is {n1 % n2}.");
//................................................................................

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Write("n1 = ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("n2 = ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (n1 * n1 == n2 || n2 * n2 == n1)
//     Console.WriteLine("yes");
// else 
//     Console.WriteLine("no");