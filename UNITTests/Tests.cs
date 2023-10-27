using System;
using Xunit;
using PR_3;

namespace UNITTests {
    public class Tests {
        [Theory]
        [InlineData(15, 0, 0, 5)]
        [InlineData(10, 10, 10, 10)]
        [InlineData(4, 5, 15, 8)]
        public void Nums_Below15(int a, int b, int c, double expected) {
            var nums = new Nums(a, b, c);
            var actual = nums.DoTask();
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(15, 16, 28, 59)]
        [InlineData(123, 123, 123, 369)]
        public void Nums_Upper15(int a, int b, int c, double expected) {
            var nums = new Nums(a, b, c);
            var actual = nums.DoTask();
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(14, 21, 14)]
        [InlineData(1, 30, 42)]
        public void Arr_Default(int a, int b, double expected) {
            var arr = new MyArray(a, b);
            var actual = arr.DoTask();
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(21, 14)]
        [InlineData(1, -1)]
        public void Arr_Exception(int a, int b) {
            Assert.Throws<Exception>(() => new MyArray(a, b));
        }
    }
}