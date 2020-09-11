using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeesLogic
            
                List<Employees> aux = new List<Docente>();
                aux.Add(new Docente("juan", "Perez", 123454, 42, "San martin 323", 63, "Mascu", "Hoa@lasdlkl.com"));
                aux.Add(new Docente("hector", "Paz", 12345412, 32, "San Juan 23", 63, "Fem", "Hoa@lasdlkl.com"));
                SerializacionXML.SerializarBinaria(aux, "AuxDocente.txt");

                Assert.IsTrue(File.Exists("AuxDocente.txt"));
            
        }
    }
}
