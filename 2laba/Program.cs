using System;

public class Program
{
    public static void Main()
    {
        RomanNumber a = new RomanNumber(24);
        RomanNumber b = new RomanNumber(1001);
        RomanNumber c = new RomanNumber(8);
        RomanNumber d = new RomanNumber(3900);

        Console.WriteLine("Ожидается A (24): XXIV; " + "Результат: "  + a.ToString());
        Console.WriteLine("Ожидается B (1001): MI; " + "Результат: " + b.ToString());
        Console.WriteLine("Ожидается C (8): VIII; " + "Результат: " + c.ToString());
        Console.WriteLine("Ожидается D (3900): MMMCM; " + "Результат: " + d.ToString());
        Console.WriteLine("");

        Console.WriteLine("Ожидается B + C (1009)= MIX; " + "Результат: " + RomanNumber.Add(b, c).ToString());
        Console.WriteLine("Ожидается D - B (2899)= MMDCCCXCIX; " + "Результат: " + RomanNumber.Sub(d, b).ToString());
        Console.WriteLine("Ожидается A * C (192)= CXCII; " + "Результат: " + RomanNumber.Mul(a, c).ToString());
        Console.WriteLine("Ожидается A / C (3)= III; " + "Результат: " + RomanNumber.Div(a, c).ToString());

        Console.WriteLine("----Сортировка----");
        RomanNumber[] numbers = { a, b, c, d };
        Array.Sort(numbers);
        foreach (RomanNumber number in numbers)
        {
            Console.WriteLine(number.ToString());
        }

        Console.WriteLine("----Копирование----");
        var f = (RomanNumber)c.Clone();
        Console.WriteLine(f.ToString());
    }
}