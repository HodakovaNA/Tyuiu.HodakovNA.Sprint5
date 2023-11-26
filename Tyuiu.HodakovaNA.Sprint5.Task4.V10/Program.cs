using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.HodakovaNA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.HodakovaNA.Sprint5.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";

            Console.Title = "Спринт #5 | Выполнила: Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Чтение данных из текстового файла                                            *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #10                                                                  *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V10.txt в котором есть             *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо Х в   *");
            Console.WriteLine("* формуле y = x^3 * 1.2x + 2                                                   *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх знаков  *");
            Console.WriteLine("* после запятой) и вернуть полученный результат на консоль.                    *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            Console.WriteLine(" y = x^3 * 1.2x + 2");
            Console.WriteLine($" Данные находятся в файле: {path}");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}
