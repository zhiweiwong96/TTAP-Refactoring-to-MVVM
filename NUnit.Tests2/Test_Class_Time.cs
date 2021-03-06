﻿using NUnit.Framework;
using Time_Table_Arranging_Program;

namespace NUnit.Tests2 {
    [TestFixture]
    public class Test_Class_Time {
        [Test]
        public void Test_Time_Equality_1() {
            var input1 = Time.CreateTime_24HourFormat(10 , 10);
            var input2 = Time.CreateTime_24HourFormat(10 , 10);
            Assert.True(input1.Equals(input2));
        }

        [Test]
        public void Test_Time_Equality_2() {
            var input1 = Time.CreateTime_24HourFormat(10 , 10);
            var input2 = Time.CreateTime_24HourFormat(11 , 10);
            Assert.True(!input1.Equals(input2));
        }

        [Test]
        public void Test_Time_Equality_3() {
            var input1 = Time.CreateTime_24HourFormat(10 , 10);
            var input2 = Time.CreateTime_24HourFormat(10 , 11);
            Assert.True(!input1.Equals(input2));
        }


        [Test]
        public void Test_Time_Equality_4() {
            var input1 = Time.CreateTime_24HourFormat(10 , 10);
            var input2 = Time.CreateTime_24HourFormat(11 , 11);
            Assert.True(input1 != input2);
        }

        [Test]
        public void Test_Time_LessThan_1() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(11 , 0);
            Assert.True(input1.LessThan(input2));
        }

        [Test]
        public void Test_Time_LessThan_2() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(10 , 1);
            Assert.True(input1.LessThan(input2));
        }

        [Test]
        public void Test_Time_LessThan_3() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(9 , 0);
            Assert.False(input1.LessThan(input2));
        }

        [Test]
        public void Test_Time_LessThan_4() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(10 , 0);
            Assert.False(input1.LessThan(input2));
        }

        [Test]
        public void Test_Time_LessThan_5() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(10 , 0);
            Assert.False(input1.LessThan(input2));
        }

        [Test]
        public void Test_Time_MoreThan_1() {
            var input1 = Time.CreateTime_24HourFormat(10 , 0);
            var input2 = Time.CreateTime_24HourFormat(9 , 0);
            Assert.True(input1.MoreThan(input2));
        }

        [Test]
        public void Test_Time_MoreThan_2() {
            var input1 = Time.CreateTime_24HourFormat(9 , 30);
            var input2 = Time.CreateTime_24HourFormat(9 , 0);
            Assert.True(input1.MoreThan(input2));
        }

        [Test]
        public void Test_Time_MoreThan_3() {
            var input1 = Time.CreateTime_24HourFormat(9 , 0);
            var input2 = Time.CreateTime_24HourFormat(10 , 0);
            Assert.False(input1.MoreThan(input2));
        }

        [Test]
        public void Test_Time_MoreThan_4() {
            var input1 = Time.CreateTime_24HourFormat(9 , 0);
            var input2 = Time.CreateTime_24HourFormat(9 , 30);
            Assert.False(input1.MoreThan(input2));
        }

        [Test]
        public void Test_Time_MoreThan_5() {
            var input1 = Time.CreateTime_24HourFormat(9 , 0);
            var input2 = Time.CreateTime_24HourFormat(9 , 0);
            Assert.False(input1.MoreThan(input2));
        }

        [Test]
        public void Test_Time_FactoryMethod_1() {
            var t = Time.CreateTime_12HourFormat(12 , 00 , true);
            Assert.True(t.Hour == 12);
        }

        [Test]
        public void Test_Time_FactoryMethod_2() {
            var t = Time.CreateTime_12HourFormat(1 , 00 , true);
            Assert.True(t.Hour == 13);
        }

        [Test]
        public void Test_Time_FactoryMethod_3() {
            var t = Time.CreateTime_12HourFormat(1 , 00 , false);
            Assert.True(t.Hour == 1);
        }
    }
}