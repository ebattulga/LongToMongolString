using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongToMongolString.Test
{
     [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void test111()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(50,false), "тавин");
        }

        [TestMethod]
        public void test2()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(1234, false), "нэг мянга хоёр зуун гучин дөрвөн");
        }

        [TestMethod]
        public void test3()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(987000, false), "есөн зуун наян долоон мянган");
        }


        [TestMethod]
        public void test4()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(370, false), "гурван зуун далан");
        }

        [TestMethod]
        public void test5()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(2030, false), "хоёр мянга гучин");
        }

        [TestMethod]
        public void test6()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(123456789123456, false), "нэг зуун хорин гурван их наяд дөрвөн зуун тавин зургаан тэрбум долоон зуун наян есөн сая нэг зуун хорин гурван мянга дөрвөн зуун тавин зургаан");
        }

        [TestMethod]
        public void test7()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20000, false), "хорин мянган");
        }

        [TestMethod]
        public void test8()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(22000, false), "хорин хоёр мянган");
        }

        [TestMethod]
        public void test9()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20200, false), "хорин мянга хоёр зуун");
        }

        [TestMethod]
        public void test10()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20001, false), "хорин мянга нэгэн");
        }

        [TestMethod]
        public void test11()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(200000, false), "хоёр зуун мянган");
        }

        [TestMethod]
        public void test12()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(2000000, false), "хоёр сая");
        }

        [TestMethod]
        public void test13()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20000000, false), "хорин сая");
        }

        [TestMethod]
        public void test14()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(101010, false), "нэг зуун нэг мянга арван");
        }

        [TestMethod]
        public void test15()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(101011, false), "нэг зуун нэг мянга арван нэгэн");
        }
    }
}
