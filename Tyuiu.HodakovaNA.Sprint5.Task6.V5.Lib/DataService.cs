using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HodakovaNA.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            List<string> alph = new List<string>();
            
            for (char sim = 'A'; sim <= 'Z'; sim++)
            {
                alph.Add("" + sim);
            }
            
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (alph.Contains("" + line[i]))
                        {
                            count++;
                        }
                    }
                }
            }
            
            return count;
        }
    }
}
