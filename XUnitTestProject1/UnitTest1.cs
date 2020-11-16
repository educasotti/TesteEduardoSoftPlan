using System;
using Xunit;
using TesteEduardoSoftPlan.Services;
using System.Threading.Tasks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        protected readonly InterestService _interestService = new InterestService();

        [Fact]
        public void CalcInterest()
        {
            var interest = 0.01;
            var startValue = 100;
            var months = 5;
            var expValue = "105,10";

            var calc = _interestService.Calc(interest, startValue, months);
            Assert.Equal(expValue, calc);

        }
    }
}
