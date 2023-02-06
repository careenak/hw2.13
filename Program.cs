// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число:");
   int n = Convert.ToInt32(Console.ReadLine());
   int c = n.ToString().Length;
   int p = n/100;
   if (p<1)
   {
    Console.WriteLine("Нет третьей цифры");
   }
    else
    {
    int k = 1;
        for (int i = c; i > 3; i--)
        {
            k = k * 10;
        }

        int r = (n / k) % 10;
   Console.WriteLine("Третья цифра числа:"+ r);
    }