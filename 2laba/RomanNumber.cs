using System;
using System.Collections.Generic;
using System.Text;

    internal class RomanNumber : ICloneable, IComparable
    {
        private ushort number = 0;
        public RomanNumber(ushort n)
        {
            number = n;
        }
        //Сложение римских чисел
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null)
                return new RomanNumber((ushort)(n1.number + n2.number));
            else
                throw new RomanNumberException("Невозможно выполнить сложение");
        }
        //Вычитание римских чисел
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.number > n2.number)
                return new RomanNumber((ushort)(n1.number - n2.number));
            else
                throw new RomanNumberException("Невозможно выполнить вычитание");
        }
        //Умножение римских чисел
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.number * n2.number <= 3999)
                return new RomanNumber((ushort)(n1.number * n2.number));
            else
                throw new RomanNumberException("Невозможно выполнить умножение");
        }
        //Целочисленное деление римских чисел
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n2.number != 0 && n1.number % n2.number == 0)
                return new RomanNumber((ushort)(n1.number / n2.number));
            else
                throw new RomanNumberException("Невозможно выполнить деление");
        }

        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            string str = "";
            ushort num = number;
            ushort[] digit = new ushort[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] roman_num = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

            for (int i = 12; i >= 0; --i)
            {
                if (num / digit[i] != 0)
                {
                    for (int j = 0; j < num / digit[i]; ++j)
                        str += roman_num[i];
                    num %= digit[i];
                }
            }
            return str;
        }
        //Реализация интерфейса IClonable
        public object Clone()
        {
            return new RomanNumber(number);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber num)
                return number.CompareTo(num.number);
            else
                throw new RomanNumberException("Error: сравнение невозможно");
        }
    }