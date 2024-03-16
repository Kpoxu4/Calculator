using Calculator;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;

while (true)
{
    Console.Clear();
    Console.WriteLine("Калькулятор");
    string stringResult = Console.ReadLine();
    double result = 0;
    char[] arithmeticOperations = { '+', '-', '*', '/' };
    var arithmetic = stringResult.IndexOfAny(arithmeticOperations) != -1 ?
                stringResult[stringResult.IndexOfAny(arithmeticOperations)] : '!';

    if (stringResult.Contains('.'))
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    else
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Ru");

    if (stringResult.Contains(arithmetic) && arithmetic != '!')
    {
        var array = stringResult.Split(arithmetic).ToArray();
        if (double.TryParse(array[0], out double x) && double.TryParse(array[1], out double y))
        {
            result = ArithmeticOperations.Arithmetic(x, y, arithmetic);

            Console.Clear();
            Console.WriteLine(y == 0 && arithmetic == '/' ? "На ноль делить нельзя" :
                 $"{stringResult} = {Math.Round(result, 3, MidpointRounding.ToEven)}");
        }
        else
            Console.WriteLine("Ввели не корректные значения цифр"); 
    }
    else
        Console.WriteLine("Ввели не корректные значения арифметического действия");

    Console.WriteLine("для продолжение нажмите любую кнопку");
    Console.WriteLine("для выхода нажмите ESC");
    var key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
        break;
}        
    


