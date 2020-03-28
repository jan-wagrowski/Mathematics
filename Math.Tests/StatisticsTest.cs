namespace Math.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Shouldly;

    [TestClass]
    public class StatisticsTest
    {
        [TestMethod]
        public void TestDominant()
        {
            var array = new int[] { 11, 44, 44, 22, 22, 44, 22 };
            var expected_dominant = 44;
            Statistics.Dominant(array).ShouldBe(expected_dominant);


             array = new int[] {  44,11, 44, 22, 22, 44, 22 };

            Statistics.Dominant(array).ShouldBe(expected_dominant);

            array = new int[] { 11, 44, 44, 22, 22, 44 };

            Statistics.Dominant(array).ShouldBe(expected_dominant);

            array = new int[] { 11, 44, 44, 22, 22, 22, 44 };

            Statistics.Dominant(array).ShouldBe(expected_dominant);

            array = new int[] { 11, 22, 44, 44,  22, 22, 44 };

            Statistics.Dominant(array).ShouldBe(22);

            array = null;

            Statistics.Dominant(array).ShouldBe(22);

        }

        [TestMethod]
        public void TestAverage()
        {

            var array = new double[] { 3, 1, -5, 4, 6, -5 };
            var expected_average = 44;
            var x = Statistics.Median(array);
            var m = Statistics.Mean(array);
            var d = Statistics.Dominant(array);



        }
    }
}
