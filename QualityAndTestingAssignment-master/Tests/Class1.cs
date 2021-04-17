using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QualityAndTestingAssignment;

namespace Tests
{
    [TestFixture]
    public class InsuranceTests
    {
        [Test]
        public void Test1()
        {

            Assert.That(InsuranceService.CalcPremium(20, "female"), Is.EqualTo(5.0));
        }
        [Test]
        public void Test2()
        {

            Assert.That(InsuranceService.CalcPremium(60, "female"), Is.EqualTo(.375));
        }
        [Test]
        public void Test3()
        {

            Assert.That(InsuranceService.CalcPremium(15, "female"), Is.EqualTo(0.0));
        }
        [Test]
        public void Test4()
        {

            Assert.That(InsuranceService.CalcPremium(20, "male"), Is.EqualTo(6.0));
        }
        [Test]
        public void Test5()
        {

            Assert.That(InsuranceService.CalcPremium(60, "male"), Is.EqualTo(.75));
        }
        [Test]
        public void Test6()
        {

            Assert.That(InsuranceService.CalcPremium(15, "male"), Is.EqualTo(0.0));
        }
        [Test]
        public void Test7()
        {

            Assert.That(InsuranceService.CalcPremium(420, "horse"), Is.EqualTo(0.0));
        }
        [Test]
        public void Test8()
        {

            Assert.That(InsuranceService.CalcPremium(4, "horse"), Is.EqualTo(0.0));
        }

    }
}
