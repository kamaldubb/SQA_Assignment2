using NUnit.Framework;
using SQA_Assignment2;

namespace SQA_Assignment2_UnitTest
{
    [TestFixture]
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
        }
        // Testing for a scalene triangle with all having different values
        [Test]
        public void Analyze_Test1()
        {
            var ts = TriangleSolver.Analyze(7,5,8);
            Assert.AreEqual(7,5,8, ts);
           
        }
        // Testing for a equilateral triangle with all having same values
        [Test]
        public void Analyze_Test2()
        {
            var ts = TriangleSolver.Analyze(6,6,6);
            Assert.AreEqual(6, 6, 6, ts);

        }
        // Testing for an isosceles triangle with having one permutation two same values and one different value
        [Test]
        public void Analyze_Test3()
        {
            var ts = TriangleSolver.Analyze(10,10,18);
            Assert.AreEqual(10, 10, 18, ts);

        }

        // Testing for an isosceles triangle with having two permutation two same values and one different value
        [Test]
        public void Analyze_Test4()
        {
            var ts = TriangleSolver.Analyze(10,18,10);
            Assert.AreEqual(10, 18, 10, ts);

        }

        // Testing for an isosceles triangle with having third permutation two same values and one different value
        [Test]
        public void Analyze_Test5()
        {
            var ts = TriangleSolver.Analyze(18,10,10);
            Assert.AreEqual(18, 10, 10, ts);

        }

        // A test case with three integers greater than 0 and the sum of two of them is less than the third one with one permutation
        [Test]
        public void Analyze_Test6()
        {
            var ts = TriangleSolver.Analyze(5, 8, 12);
            Assert.AreEqual(5, 8, 12, ts);

        }
        // A test case with three integers greater than 0 and the sum of two of them is less than the third two with one permutation        [Test]
        public void Analyze_Test7()
        {
            var ts = TriangleSolver.Analyze(5, 12, 8); ;
            Assert.AreEqual(5, 12, 8, ts);

        }
        // A test case with having one side as zero value
        [Test]
        public void Analyze_Test8()
        {
            var ts = TriangleSolver.Analyze(4,0,9);
            Assert.AreEqual(4, 0, 9, ts);

        }
       
    }
}