// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num =Prompt("Введите пятизначное число: ");
Comparison(num);

int Prompt(string message)
{
    Console.Write(message);
    int number =int.Parse(Console.ReadLine()!);
    return number;
}

void Comparison(int number)
{
    if(number>9999 && number<100000)
    {
        if (number/10000 ==number%10)
        {
            if (number/1000%10 ==number/10%10)
            {
                Console.WriteLine(number + "->да");
            }
        }
        else
        {
         Console.WriteLine(number + "-> нет");   
        }
    }
    else
    {
      Console.WriteLine("Введено неверное число, введите пятизначное число: ");
      return;
    }
}

