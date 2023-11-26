using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HodakovaNA.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                
                double positiveSum = 0;
                double negativeSum = 0;

                foreach (string line in lines)
                {
                    if (double.TryParse(line, out double number))
                    {
                        if (number > 0)
                            positiveSum += number;
                        else
                            negativeSum += number;
                    }
                }

                double difference = positiveSum - negativeSum;
                difference = Math.Round(difference, 3);
                return difference;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }
    }
}
