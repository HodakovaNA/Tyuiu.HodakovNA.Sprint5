using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HodakovaNA.Sprint5.Task6.V5.Lib;

namespace Tyuiu.HodakovaNA.Sprint5.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V5.txt";

            Console.Title = "Спринт #5 | Выполнила: Ходакова Н.А. | АСОиУб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Чтение данных из текстового файла                                            *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнила: Ходакова Надежда Антоновна | АСОиУб-23-1                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTas6V5.txt в котором есть набор         *");
            Console.WriteLine("* символьных данных.                                                           *");
            Console.WriteLine("* Найти количество заглавных латинских букв в заданной строке.                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}
