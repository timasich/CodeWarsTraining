using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здесь собраны задачи с CodeWars. Введите 1-2");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    removeDashes();
                    break;
                case "2":
                    numberOfOneInBinary();
                    break;
                default: break;
            }
        }

        //----------------------Задание 1
        //Убрать '-' и '_' из строки и поднять регистр следующих символов
        static void removeDashes()
        {
            Console.WriteLine("rem-ove_dash-es => remOveDashEs");
            string str = Console.ReadLine();
            int index = -1;
            do
            {
                index = str.IndexOf('-');
                if (index != -1) str = removeUp(str, index);
            } while (index != -1);
            do
            {
                index = str.IndexOf('_');
                if (index != -1) str = removeUp(str, index);
            } while (index != -1);
            Console.WriteLine(str);
        }
        static string removeUp(string str, int index)
        {
            string o = str.Substring(index + 1, 1).ToUpper();
            str = str.Remove(index, 2).Insert(index, o);
            return str;
        }

        //----------------------Задание 2
        //Подсчитать количество '1' в двоичном представлении числа
        static void numberOfOneInBinary()
        {
            Console.WriteLine("1234 => 5 (count of 1 in 10011010010");
            int n = Int32.Parse( Console.ReadLine());
            Console.WriteLine((Convert.ToString(n, 2)).Where(x => (x == '1')).Count());   
        }
    }
}
