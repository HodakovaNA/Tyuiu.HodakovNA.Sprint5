using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovNA.Sprint5.Task3.V21.Lib;

namespace Tyuiu.HodakovNA.Sprint5.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #17                                                                  *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить         *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.                    *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: " + res);
            Console.WriteLine("Создан!");
            
            Console.ReadKey();
        }
    }
}
