using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.HodakovNA.Sprint5.Task2.V12.Lib;

namespace Tyuiu.HodakovNA.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.HodakovNA.Sprint5\Tyuiu.HodakovNA.Sprint5.Task2.V12\bin\Debug\OutPutFileTask2.csv";
            
            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;
            
            Assert.AreEqual(wait, fileExists);
        }
    }
}
