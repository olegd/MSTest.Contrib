using System;
using System.Globalization;

namespace MSTest.Contrib
{
    public class Assert
    {
        public static void That()
        { 
        }


        #region MSTest Asserts

        public static void IsTrue(bool condition)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsTrue(condition);
        }

        public static void IsTrue(bool condition, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsTrue(condition, message);
        }

        public static void IsTrue(bool condition, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsTrue(condition, message, parameters);
        }

        public static void IsFalse(bool condition)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsFalse(condition);
        }

        public static void IsFalse(bool condition, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsFalse(condition, message);
        }

        public static void IsFalse(bool condition, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsFalse(condition, message, parameters);
        }

        public static void IsNull(object value)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNull(value);
        }

        public static void IsNull(object value, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNull(value, message);
        }

        public static void IsNull(object value, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNull(value, message, parameters);
        }

        public static void IsNotNull(object value)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotNull(value);
        }

        public static void IsNotNull(object value, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotNull(value, message);
        }

        public static void IsNotNull(object value, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotNull(value, message, parameters);
        }

        public static void AreSame(object expected, object actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreSame(expected, actual);
        }

        public static void AreSame(object expected, object actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreSame(expected, actual, message);
        }

        public static void AreSame(object expected, object actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreSame(expected, actual, message, parameters);
        }

        public static void AreNotSame(object notExpected, object actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotSame(notExpected, actual);
        }

        public static void AreNotSame(object notExpected, object actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotSame(notExpected, actual, message);
        }

        public static void AreNotSame(object notExpected, object actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotSame(notExpected, actual, message, parameters);
        }

        public static void AreEqual<T>(T expected, T actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual);
        }

        public static void AreEqual<T>(T expected, T actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, message);
        }

        public static void AreEqual<T>(T expected, T actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, message, parameters);
        }

        public static void AreNotEqual<T>(T notExpected, T actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual);
        }

        public static void AreNotEqual<T>(T notExpected, T actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, message);
        }

        public static void AreNotEqual<T>(T notExpected, T actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, message, parameters);
        }

        public static void AreEqual(object expected, object actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(object expected, object actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, message);
        }

        public static void AreEqual(object expected, object actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, message, parameters);
        }

        public static void AreNotEqual(object notExpected, object actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual);
        }

        public static void AreNotEqual(object notExpected, object actual, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, message);
        }

        public static void AreNotEqual(object notExpected, object actual, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual<object>(notExpected, actual, message, parameters);
        }

        public static void AreEqual(float expected, float actual, float delta)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta);
        }

        public static void AreEqual(float expected, float actual, float delta, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta, message);
        }

        public static void AreEqual(float expected, float actual, float delta, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta, message, parameters);
        }

        public static void AreNotEqual(float notExpected, float actual, float delta)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta);
        }

        public static void AreNotEqual(float notExpected, float actual, float delta, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta, message);
        }

        public static void AreNotEqual(float notExpected, float actual, float delta, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
        }

        public static void AreEqual(double expected, double actual, double delta)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta);
        }

        public static void AreEqual(double expected, double actual, double delta, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta, message);
        }

        public static void AreEqual(double expected, double actual, double delta, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, delta, message, parameters);
        }

        public static void AreNotEqual(double notExpected, double actual, double delta)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta);
        }

        public static void AreNotEqual(double notExpected, double actual, double delta, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta, message);
        }

        public static void AreNotEqual(double notExpected, double actual, double delta, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase, message);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase, message, parameters);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase, culture);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase, culture, message);
        }

        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreEqual(expected, actual, ignoreCase, culture, message, parameters);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase, message);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase, message, parameters);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase, culture);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message);
        }

        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message, parameters);
        }

        public static void IsInstanceOfType(object value, Type expectedType)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsInstanceOfType(value, expectedType);
        }

        public static void IsInstanceOfType(object value, Type expectedType, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsInstanceOfType(value, expectedType, message);
        }

        public static void IsInstanceOfType(object value, Type expectedType, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsInstanceOfType(value, expectedType, message, parameters);
        }

        public static void IsNotInstanceOfType(object value, Type wrongType)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotInstanceOfType(value, wrongType);
        }

        public static void IsNotInstanceOfType(object value, Type wrongType, string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotInstanceOfType(value, wrongType, message);
        }

        public static void IsNotInstanceOfType(object value, Type wrongType, string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.IsNotInstanceOfType(value, wrongType, message, parameters);
        }

        public static void Fail()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Fail();
        }

        public static void Fail(string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Fail(message);
        }

        public static void Fail(string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Fail(message, parameters);
        }

        public static void Inconclusive()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Inconclusive();
        }

        public static void Inconclusive(string message)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Inconclusive(message);
        }

        public static void Inconclusive(string message, params object[] parameters)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting
              .Assert.Inconclusive(message, parameters);
        }

        public new static bool Equals(object objA, object objB)
        {
            return Microsoft.VisualStudio.TestTools.UnitTesting
                .Assert.Equals(objA, objB);
        }

        #endregion
    }
}
