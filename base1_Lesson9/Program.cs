using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Программа простой калькулятор!");
            double result=0;
            // string op = "";
            // Ввод чисел
            Console.Write(" Введите действительное число Х= ");
            string num1 = Console.ReadLine();
            Console.Write(" Введите действительное число Y= ");
            string num2 = Console.ReadLine();
            int expect1;
            int expect2;
            bool flag = true;
            try
            {
                if ((!int.TryParse(num1, out expect1)) | (!int.TryParse(num2, out expect2)))
                {
                    Console.Write(" Ошибка ввода! Формат числа не верен. Прерывание!");
                    flag = false;
                }
                else
                {
                    Console.WriteLine(" Выберите код операции:");
                    Console.WriteLine(" 1 - Сложение");
                    Console.WriteLine(" 2 - Вычитание");
                    Console.WriteLine(" 3 - Умножение");
                    Console.WriteLine(" 4 - Деление");
                    Console.Write(" Код операции: ");
                    int code = Convert.ToInt32(Console.ReadLine());
                    if (code == 1)
                    {
                        result = CalcSum(expect1, expect2);
                    }
                    if (code == 2)
                    {
                        result = CalcSubstr(expect1, expect2);
                    }
                    if (code == 3)
                    {
                        result = CalcMult(expect1, expect2);
                    }
                    if (code == 4)
                    {
                        if (expect2 == 0)
                        {
                            Console.WriteLine(expect1 / expect2);
                            flag = false;
                        }
                        else
                        {
                            result = CalcDev(num1, num2);
                        }
                    }
                    if (code == 0 | code > 5)
                    {
                        flag = false;
                        Console.WriteLine(" Ошибка ввода!Неверный код перации!Прерывание.");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    Console.WriteLine(" Ошибка!" + ex.Message);
                    flag = false;
                }
            }

            finally
            {
                if (flag)
                {

                    Console.WriteLine(" Результат вычислений: {0:0.000}\n", result);
                }    
                
            }
            Console.ReadKey();
        }
        static double CalcSum(int num1, int num2)
        {
            double result = num1 + num2;
            return result;
        }
        static double CalcSubstr(int num1, int num2)
        {
            double result = num1 - num2;
            return result;
        }
        static double CalcMult(int num1, int num2)
        {
            double result = num1 * num2;
            return result;
        }
        static double CalcDev(string num1, string num2)
        {
            /*if (num2 != 0)
            {
                result = num1 / num2;
            }*/
            double result = double.Parse(num1) / double.Parse(num2);
            return result;
        }
    }
}