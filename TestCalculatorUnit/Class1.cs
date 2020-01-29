using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBasics;
using NUnit.Framework;

namespace TestCalculatorUnit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void AddDoubles_returnDoubles()
        {

            Assert.That(uut.Add(5, 5), Is.EqualTo(5 + 5));

        }

        [Test]
        public void SubtractDoubles_returnDoubles()
        {

            Assert.That(uut.Subtract(5, 5), Is.EqualTo(5 - 5));

        }

        [Test]
        public void MultiplyDoubles_returnDoubles()
        {

            Assert.That(uut.Multiply(5, 5), Is.EqualTo(5 * 5));

        }

        [Test]
        public void PowerDoubles_returnDoubles()
        {

            Assert.That(uut.Power(5, 5), Is.EqualTo(Math.Pow(5, 5)));

        }

    }
}
