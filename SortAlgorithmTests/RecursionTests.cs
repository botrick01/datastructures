using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    internal class RecursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumber_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var ret = ms.SumUpValues_Recursive(3);
            Assert.AreEqual(ret, 6);
        }
        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }
            public int SumUpValues_Recursive(int number) //+1 Punkt
            {
                int ret = 0;
                int i = 0;
                i++;
                ret += i;
                if(i < number)
                {
                    SumUpValues_Recursive(number);
                }
                return ret;
            }
        }
    }
}
