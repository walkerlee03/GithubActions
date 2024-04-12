using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Lee()
        {
            Assert.AreEqual(5, Program.Subtract("7", "2"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(-6, Program.Subtract("0", "6"));
        }

        [Test]
        public void Subtract_Invalid_Lee()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("b", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("2", "b"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "b"));
        }

        [Test]
        public void Subtract_Null_Lee()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Multiply_Valid_Lee()
        {
            Assert.AreEqual(25, Program.Multiply("5", "5"));
            Assert.AreEqual(18, Program.Multiply("6", "3"));
            Assert.AreEqual(5, Program.Multiply("1", "5"));
        }

        [Test]
        public void Multiply_Invalid_Lee()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("g", "6"));
            Assert.Throws<FormatException>(() => Program.Multiply("8", "h"));
            Assert.Throws<FormatException>(() => Program.Multiply("f", "x"));
        }

        [Test]
        public void Multiply_Null_Lee()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "9"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("6", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Divide_Valid_Lee()
        {
            Assert.AreEqual(1, Program.Divide("9", "9"));
            Assert.AreEqual(6, Program.Divide("30", "5"));
            Assert.AreEqual(9, Program.Divide("9", "1"));
        }

        [Test]
        public void Divide_Invalid_Lee()
        {
            Assert.Throws<FormatException>(() => Program.Divide("j", "4"));
            Assert.Throws<FormatException>(() => Program.Divide("2", "b"));
            Assert.Throws<FormatException>(() => Program.Divide("w", "l"));
        }

        [Test]
        public void Divide_Null_Lee()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "9"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Exponentiate_Valid_Lee()
        {
            Assert.AreEqual(4, Program.Power("2", "2"));
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(81, Program.Power("9", "2"));
        }

        [Test]
        public void Exponentiate_Invalid_Lee()
        {
            Assert.Throws<FormatException>(() => Program.Power("t", "3"));
            Assert.Throws<FormatException>(() => Program.Power("g", "8"));
            Assert.Throws<FormatException>(() => Program.Power("r", "m"));
        }

        [Test]
        public void Exponentiate_Null_Lee()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "8"));
            Assert.Throws<ArgumentNullException>(() => Program.Power("9", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
