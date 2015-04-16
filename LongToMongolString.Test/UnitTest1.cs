using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToString;

namespace LongToMongolString.Test
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void test1()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(50), "тавь");
        }

        [TestMethod]
        public void test2()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(1234), "нэг мянга хоёр зуун гучин дөрөв");
        }

        [TestMethod]
        public void test3()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(987000), "есөн зуун наян долоон мянга");
        }


        [TestMethod]
        public void test4()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(370), "гурван зуун дал");
        }

        [TestMethod]
        public void test5()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(2030), "хоёр мянга гуч");
        }

        [TestMethod]
        public void test6()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(123456789123456), "нэг зуун хорин гурван их наяд дөрвөн зуун тавин зургаан тэрбум долоон зуун наян есөн сая нэг зуун хорин гурван мянга дөрвөн зуун тавин зургаа");
        }

        [TestMethod]
        public void test7()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20000), "хорин мянга");
        }

        [TestMethod]
        public void test8()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(22000), "хорин хоёр мянга");
        }

        [TestMethod]
        public void test9()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20200), "хорин мянга хоёр зуу");
        }

        [TestMethod]
        public void test10()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20001), "хорин мянга нэг");
        }

        [TestMethod]
        public void test11()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(200000), "хоёр зуун мянга");
        }

        [TestMethod]
        public void test12()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(2000000), "хоёр сая");
        }

        [TestMethod]
        public void test13()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(20000000), "хорин сая");
        }

        [TestMethod]
        public void test14()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(101010), "нэг зуун нэг мянга арав");
        }

        [TestMethod]
        public void test15()
        {
            NumberConverter con = new NumberConverter();
            Assert.AreEqual(con.convert(101011), "нэг зуун нэг мянга арван нэг");
        }
    }
}
