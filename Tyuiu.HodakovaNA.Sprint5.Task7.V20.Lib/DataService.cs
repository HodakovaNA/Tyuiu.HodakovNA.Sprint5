using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.HodakovaNA.Sprint5.Task7.V20.Lib
{
    public class DataService : ISprint5Task7V20
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.HodakovNA.Sprint5\Tyuiu.HodakovaNA.Sprint5.Task7.V20\bin\Debug\InPutDataFileTask7V20.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i] == 'с') && (line[i + 1] == 'с')) || ((line[i] == 'с') && (line[i + 1] == 'С')) || (line[i] == 'С') && (line[i + 1] == 'с'))
                        {
                            strLine += line[i];
                            i++;
                        }
                        else
                        {
                            strLine += line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            
            return pathSaveFile;
        }
    }
}
