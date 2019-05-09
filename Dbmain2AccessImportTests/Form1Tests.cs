using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dbmain2AccessImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dbmain2AccessImport.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        Form1 form;
        string db;

        [TestInitialize()]
        public void Setup()
        {
            form = new Form1();
            db = form.CreateDb();
        }

        [TestCleanup()]
        public void TearDown()
        {
            if (db != null)
                File.Delete(db);
        }

        [TestMethod()]
        public void CreateDbTest()
        { 
            //assert
            Assert.IsNotNull(db);

        }

        [TestMethod()]
        public void ExecuteNonQueryTest()
        {
            form.ExecuteNonQuery(new string[] {"create table Client (id long not null)","select * from client" }, db);

        }
    }
}