using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration_Midterm_AryanGajjar
{
    // name: Aryan Gajjar      email: agajjar2211@conestogac.on.ca      student no.: 8972211
    [TestFixture]
    public class registerationTests
    {
        private Registration _registration;

        [SetUp]
        public void Setup()
        {
            _registration = new Registration();
        }

        [Test]
        public void RegisterName_ValidName_ReturnsName()
        {
            // Arrange
            string name = "Aryan Gajjar";

            // Act
            string result = _registration.RegisterName(name);

            // Assert
            Assert.That(result, Is.EqualTo(name));

        }

        [Test]
        public void RegisterName_NullOrEmpty_ThrowsArgumentNullException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => _registration.RegisterName(null));
            Assert.Throws<ArgumentNullException>(() => _registration.RegisterName(""));
        }

        [Test]
        public void RegisterName_TooLong_ThrowsArgumentException()
        {
            // Arrange
            string longName = new string('G', 36);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _registration.RegisterName(longName));
        }

        [Test]
        public void RegisterAge_ValidAge_ReturnsAge()
        {
            // Arrange
            int age = 25;

            // Act
            int result = _registration.RegisterAge(age);

            // Assert
            Assert.That(result, Is.EqualTo(age));
        }

        [Test]
        public void RegisterAge_Negative_ThrowsArgumentOutOfRangeException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _registration.RegisterAge(-1));
        }

        [Test]
        public void RegisterAge_TooHigh_ThrowsArgumentOutOfRangeException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _registration.RegisterAge(100));
        }

        [Test]
        public void RegisterGroupSize_ValidSize_ReturnsSize()
        {
            // Arrange
            int groupSize = 10;

            // Act
            int result = _registration.RegisterGroupSize(groupSize);

            // Assert
            Assert.That(result, Is.EqualTo(groupSize));
        }

        [Test]
        public void RegisterGroupSize_ZeroOrNegative_ThrowsArgumentOutOfRangeException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _registration.RegisterGroupSize(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => _registration.RegisterGroupSize(-1));
        }

        [Test]
        public void RegisterGroupSize_TooHigh_ThrowsArgumentOutOfRangeException()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _registration.RegisterGroupSize(18));
        }


    }
}


