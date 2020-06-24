using System;
using static System.Console;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //KolSymb();
            //HappyTicket();
            //ConvertToRegister();
            //ForFun();
            //TurnTheNumber();
        }
        //Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.
        static void KolSymb()
        {
            WriteLine("Введите символы, введите '.' для остановки считывания символов ");
            char symbol;
            int separator=0;
            do
            {
                symbol = (char)Read();
                if (symbol==' ')
                {
                    ++separator;
                }
            } while (symbol != '.');
            WriteLine("Всего было введено {0} пробелов", separator);
        }
        //Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым
        //(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
        static void HappyTicket()
        {
            WriteLine("Введите номер билета");
            int NumberTicket = Int32.Parse(ReadLine());
            if (99999< NumberTicket&& NumberTicket<1000000)
            {
                int r1, r2, r3, r4, r5, r6;//разряды числа от 1 до 6
                r1 = NumberTicket / 100000;
                r2 = NumberTicket / 10000 % 10;
                r3 = NumberTicket / 1000 % 10;
                r4 = NumberTicket / 100 % 10;
                r5 = NumberTicket / 10 % 10;
                r6 = NumberTicket % 10;
                if ((r1+r2+r3)==(r4+r5+r6))
                {
                    WriteLine("Билет счастливый!:) ");
                }
                else
                {
                    WriteLine("Билет не счастливый!:( ");
                }

            }
            else
            {
                WriteLine("Вы ввели неверный номер! ");
            }
        }
        //Задание 3. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
        //Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
        static void ConvertToRegister()
        {
            WriteLine("Введите символы для конвертации, введите '!' для остановки считывания символов ");
            char symbol;
            do
            {
                symbol = (char)Read();
                int IntASCII = (int)symbol;
                if (65 <= IntASCII && IntASCII <= 90)
                {
                    IntASCII += 32;
                    symbol = (char)IntASCII;
                    Write(symbol);
                }
                else if (97 <= IntASCII && IntASCII <= 122)
                {
                    IntASCII -= 32;
                    symbol = (char)IntASCII;
                    Write(symbol);
                }

            } while (symbol != '!');
        }
        //Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке;
        //при этом каждое число должно выводиться количество раз, равное его значению. 

        static void ForFun()
        {
            int a, b;
            WriteLine("Введите два положительных числа a и b такие, чтобы  a было меньше b ");
            a = Int32.Parse(ReadLine());
            b = Int32.Parse(ReadLine());
            if (a>=b||a<0||b<0)
            {
                WriteLine("Ну просили же либо  a < b, либо a и b положительные! ");
            }
            else
            {
                while (a<=b)
                {
                   for (int i=0;i<a;++i)
                    {
                        Write(a);
                    }
                    Write("\n");
                    ++a;
                }
            }
        }
        //Задание 5. Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
        //Например, если было введено число 345, то программа должна вывести число 543.
       static void TurnTheNumber()
        {
            WriteLine("Введите  положительных число ");
            int number = Int32.Parse(ReadLine());
            int a;
            if (number<0)
            {
                WriteLine("Упс! число отрицательное ");
            }
            else
            {
                while (number!=0)
                {
                   a = number % 10;
                    number /= 10;
                    Write(a);
                }
                
            }
        }
    }
}
