using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Функция
{
    internal static class Function
    {
        private static string func = string.Empty; //Функция до перевода в обратную польскую запись
        private static string funcRPN = string.Empty; //Функция после перевода в обратную польскую запись

        public static string Func { get { return func; } }
        public static string FuncRPN { get { return funcRPN; } }


        public static bool GetFunction(string input) //Получаем функцию и переводим ее в обратную польскую запись
        {
            func = input;
            Stack<char> operators = new Stack<char>(); //Здесь храним операторы
            string result = string.Empty; //Результат
            char prev = '!'; //Предыдущий символ

            for (int i = 0; i < input.Length; i++) //Проходимся во всем символам
            {
                if (input[i] == ' ') continue; //Если пробел, то пропускаем
                else if (Char.IsDigit(input[i]))
                {
                    if (!"!+-/*^(".Contains(prev)) return false; //Проверяем предыдущий символ, это должен быть оператор
                    int countDots = 0; //Считаем точки (запятые) для десятичных дробей
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '.' || input[i] == ','))
                    {
                        if (input[i] == '.' || input[i] == ',') countDots++;
                        result += input[i].ToString();
                        prev = input[i];
                        i++;
                    }
                    if (result[result.Length - 1] == '.' || result[result.Length - 1] == ',' || countDots > 1) return false; //Если точек больше чем одна, число введено некорректно
                    result += " ";
                    i--;
                }
                else if (input[i] == 'x')
                {
                    if (!"!+-/*^(".Contains(prev)) return false; //Проверяем предыдущий символ, это должен быть оператор
                    result += "x ";
                    prev = 'x';
                }
                else if ("+-/*^()".Contains(input[i]))
                {
                    if (input[i] == '(')
                    {
                        if (!"!+-/*^(".Contains(prev)) return false; //Проверяем предыдущий символ, это должен быть оператор
                        operators.Push(input[i]);
                        prev = input[i];
                    }
                    else if (input[i] == ')')
                    {
                        if (operators.Count == 0 || "!+-/*^(".Contains(prev)) return false; //Проверяем количество операторов до данного и предыдущий символ, это не должен быть оператор
                        char c = operators.Pop();
                        while (c != '(') //Записываем все операторы, вплоть до открывающейся скобки, если ее не было, то ввод был произведен некорректно
                        {
                            if (operators.Count == 0) return false;
                            result += c.ToString() + " ";
                            c = operators.Pop();
                        }
                        prev = input[i];
                    }
                    else if (input[i] == '-' && "!(".Contains(prev)) //Если символ - знак минуса перед отрицательным числом
                    {
                        if (++i >= input.Length) return false;
                        while (input[i] == ' ')
                        {
                            if (++i >= input.Length) return false;
                        }
                        result += "0 ";
                        if (char.IsDigit(input[i]))
                        {
                            int countDots = 0;
                            while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '.' || input[i] == ','))
                            {
                                if (input[i] == '.' || input[i] == ',') countDots++;
                                result += input[i].ToString();
                                prev = input[i];
                                i++;
                            }
                            if (result[result.Length - 1] == '.' || result[result.Length - 1] == ',' || countDots > 1) return false; //Если точек больше чем одна, число введено некорректно
                            result += " - ";
                            i--;
                        }
                        else if (input[i] == 'x')
                        {
                            result += "x - ";
                            prev = 'x';
                        }
                        else return false;
                    }
                    else
                    {
                        if ("!+-/*^(".Contains(prev)) return false; //Проверяем предыдущий символ, это не должен быть оператор
                        prev = input[i];
                        if (operators.Count > 0)
                        {
                            while (operators.Count != 0 && GetPriority(input[i]) <= GetPriority(operators.Peek()))
                            {
                                result += operators.Pop().ToString() + " "; //Вводим в строку операторы из стэка, если их приоритет больше данного
                            }
                        }
                        operators.Push(input[i]);
                    }
                }
                else return false;
            }

            while (operators.Count > 0) //Оставшиеся операторы записываем в строку
            {
                char c = operators.Pop();
                if (c != '(') result += c.ToString() + " ";
            }

            funcRPN = result;
            if (funcRPN == string.Empty) return false;
            return true;
        }
        private static int GetPriority(char c) //Получаем приоритет оператора
        {
            switch (c)
            {
                case '(': return 0;
                case ')': return 0;
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;
            }
            return -1;
        }
        public static double FuncValue(double x) //Значение функции в точке
        {
            double result = 0;
            Stack<double> tmp = new Stack<double>();
            string funcInX;
            if (x >= 0) funcInX = funcRPN.Replace("x", x.ToString());
            else funcInX = funcRPN.Replace("x", "0 " + (-x).ToString() + " -");

            for (int i = 0; i < funcInX.Length; i++)
            {
                if (char.IsDigit(funcInX[i])) //Если число, то читаем его полностью, затем засовываем в стэк
                {
                    string a = string.Empty;
                    while (i < funcInX.Length && funcInX[i] != ' ')
                    {
                        if (funcInX[i] != '.') a += funcInX[i].ToString();
                        else a += ',';
                        i++;
                    }
                    tmp.Push(double.Parse(a));
                    i--;
                }
                else if ("+-/*^".Contains(funcInX[i])) //Если оператор, выполняем операцию относительно последних двух чисел в сстэке и засовывавем результат в стэк
                {
                    double b = tmp.Pop();
                    double a = tmp.Pop();
                    switch (funcInX[i])
                    {
                        case '+': result = a + b; break;
                        case '-': result = a - b; break;
                        case '*': result = a * b; break;
                        case '/': result = a / b; break;
                        case '^': result = Math.Pow(a, b); break;
                    }
                    tmp.Push(Math.Round(result, 2));
                }
            }

            return tmp.Peek();
        }
    }
}
