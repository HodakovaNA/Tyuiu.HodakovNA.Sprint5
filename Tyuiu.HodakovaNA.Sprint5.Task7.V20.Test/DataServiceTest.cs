﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.HodakovaNA.Sprint5.Task7.V20.Lib;

namespace Tyuiu.HodakovaNA.Sprint5.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.HodakovNA.Sprint5\Tyuiu.HodakovaNA.Sprint5.Task7.V20\bin\Debug\InPutDataFileTask7V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            
            Assert.AreEqual(wait, fileExists);
        }
    }
}
