using NUnit.Framework;
using System;
using ConverterHelper.Tests.Utils;
using AutoFixture;
using ConverterHelper.Tests.Fakes;

namespace ConverterHelper.Tests
{
    [TestFixture]
    public class ExtensionsMethodsTests
    {
        [GenericTestCase(typeof(bool))]
        [GenericTestCase(typeof(byte))]
        [GenericTestCase(typeof(sbyte))]
        [GenericTestCase(typeof(char))]
        [GenericTestCase(typeof(decimal))]
        [GenericTestCase(typeof(double))]
        [GenericTestCase(typeof(float))]
        [GenericTestCase(typeof(int))]
        [GenericTestCase(typeof(uint))]
        [GenericTestCase(typeof(long))]
        [GenericTestCase(typeof(ulong))]
        [GenericTestCase(typeof(short))]
        [GenericTestCase(typeof(ushort))]
        [GenericTestCase(typeof(FakeEnum))]
        public void ConvertToOrDefault_WhenItFailsToConvertAndNoDefaultValueIsProvided_ShouldConvertToTheTypeDefault<T>()
        {
            // Arrange
            object predicate = null;

            // Act
            var result = predicate.ConvertToOrDefault<T>();

            // Assert
            Assert.That(result, Is.EqualTo(default(T)));
        }

        [GenericTestCase(typeof(bool?))]
        [GenericTestCase(typeof(byte?))]
        [GenericTestCase(typeof(sbyte?))]
        [GenericTestCase(typeof(char?))]
        [GenericTestCase(typeof(decimal?))]
        [GenericTestCase(typeof(double?))]
        [GenericTestCase(typeof(float?))]
        [GenericTestCase(typeof(int?))]
        [GenericTestCase(typeof(uint?))]
        [GenericTestCase(typeof(long?))]
        [GenericTestCase(typeof(ulong?))]
        [GenericTestCase(typeof(short?))]
        [GenericTestCase(typeof(ushort?))]
        [GenericTestCase(typeof(FakeEnum?))]
        public void ConvertToOrDefault_WhenItFailsToConvertAndNoDefaultValueIsProvidedForANullableType_ShouldReturnNull<T>()
        {
            // Arrange
            object predicate = new object();

            // Act
            var result = predicate.ConvertToOrDefault<T>();

            // Assert
            Assert.That(result, Is.Null);
        }

        [GenericTestCase(typeof(bool))]
        [GenericTestCase(typeof(byte))]
        [GenericTestCase(typeof(sbyte))]
        [GenericTestCase(typeof(char))]
        [GenericTestCase(typeof(decimal))]
        [GenericTestCase(typeof(double))]
        [GenericTestCase(typeof(float))]
        [GenericTestCase(typeof(int))]
        [GenericTestCase(typeof(uint))]
        [GenericTestCase(typeof(long))]
        [GenericTestCase(typeof(ulong))]
        [GenericTestCase(typeof(short))]
        [GenericTestCase(typeof(ushort))]
        [GenericTestCase(typeof(FakeEnum))]
        public void ConvertToOrDefault_WhenItIsAbleToConvert_ShouldConvertToTheTypeDefault<T>()
        {
            // Arrange
            T expected = new Fixture().Create<T>();
            string predicate = expected.ToString();

            // Act
            var result = predicate.ConvertToOrDefault<T>();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(FakeEnum.OptionA, 1)]
        [TestCase(FakeEnum.OptionB, 2)]
        [TestCase(FakeEnum.OptionC, 3)]
        public void ConvertToOrDefault_WhenAEnumItemIsGiven_ShouldConvertToTheCorrespondentIndex(FakeEnum enumItem, int enumIndex)
        {
            // Act
            var result = enumItem.ConvertToOrDefault<int>();

            // Assert
            Assert.That(result, Is.EqualTo(enumIndex));
        }

        [TestCase(1, FakeEnum.OptionA)]
        [TestCase(2, FakeEnum.OptionB)]
        [TestCase(3, FakeEnum.OptionC)]
        public void ConvertToOrDefault_WhenAEnumItemIsGiven_ShouldConvertToTheCorrespondentIndex(int enumIndex, FakeEnum enumItem)
        {
            // Act
            var result = enumIndex.ConvertToOrDefault<FakeEnum>();

            // Assert
            Assert.That(result, Is.EqualTo(enumItem));
        }

        [TestCase(typeof(bool), false)]
        [TestCase(typeof(bool?), true)]
        public void IsNullable_WhenTypeIsGiven_ShouldReturnAsExpectedParameter(Type type, bool expected)
        {
            // Act
            var result = type.IsNullable();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(typeof(object), false)]
        [TestCase(typeof(bool), true)]
        public void IsConvertible_WhenTypeIsGiven_ShouldReturnAsExpectedParameter(Type type, bool expected)
        {
            // Act
            var result = type.IsConvertible();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
