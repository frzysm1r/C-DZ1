
//  Console.WriteLine("Введите 1 ч50исло");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите 2 число");
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a > b)
//  {
//     Console.WriteLine($"Наибольшее число: {a}");
//     Console.WriteLine($"Наиментшее число: {b}");
//  }
//  else 
//  {
//      Console.WriteLine($"Наибольшее число: {b}");
//      Console.WriteLine($"Наиментшее число: {a}");
//  }

 
  //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Введите 1 число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 3 число");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a>b)
// {
//     if (a>c)
//     {
//        Console.WriteLine($"Наибольшее число: {a}");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшее число: {c}");
//     }
// }
// else if (b>a) 
// {
//        if (b>c)
//     {
//         Console.WriteLine($"Наибольшее число: {b}");
//     }
//         else
//     {
//         Console.WriteLine($"Наибольшее число: {c}");
//     }

// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Введите  число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0 )
// {
//  Console.WriteLine("Число четное");
// }
// else
// {
//  Console.WriteLine("Число НЕ четное");
// }


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
                          if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }