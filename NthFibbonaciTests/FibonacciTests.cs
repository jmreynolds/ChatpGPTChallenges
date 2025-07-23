using Microsoft.VisualStudio.TestTools.UnitTesting;
using NthFibonnaci;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NthFibbonaciTests
{

    // Fibonacci Number
    //    Write a function to return the nth Fibonacci number(iterative and recursive versions).

    [TestClass]
    public sealed class FibonacciTests
    {
        [TestMethod]
        public void ShouldReturnNthFibonnaci()
        {
            var expectedList = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            var expected = 34;
            var nthFibonacci = new NthFibonacci();
            var tenthFibonacci = nthFibonacci.GetFibonacci(9).Last();
            Assert.AreEqual(expected, tenthFibonacci, "The count of Fibonacci numbers does not match.");
        }
    }
}
