using System.Collections;

namespace SeleniumKP1_2.Framework.Tests
{
    [TestFixture]
    internal class DDTTest
    {
        [TestCaseSource(typeof(AdditionTestData), nameof(AdditionTestData.TestCases))]
        public int AddTest(int a, int b) => Add(a, b);

        private int Add(int a, int b) => a + b;
    }
    public class AdditionTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(3);
                yield return new TestCaseData(5, 7).Returns(12);
                yield return new TestCaseData(-1, -1).Returns(-2);
                yield return new TestCaseData(0, 0).Returns(0);
            }
        }
    }
}
