using System;
using NUnit.Framework;

namespace MSTest.Contrib.Tests
{
    [TestFixture]
    public class ExpectedExceptionConstraintTests
    {
        [Test]
        public void Verify_ExceptionWasntThrown_ThrowsException()
        {
            var constraint = CreateConstraint(typeof(ArgumentNullException));
            constraint.ActualException = null;

            NUnit.Framework.Assert.Throws<AssertFailedException>(constraint.Verify);
        }

        [Test]
        public void Verify_ExceptionWasThrown_DoesNotThrowException()
        {
            var constraint = CreateConstraint(typeof(ArgumentNullException));
            constraint.ActualException = new ArgumentNullException();

            constraint.Verify();
        }

        [Test]
        public void Verify_ExceptionWasThrownButOfWrongType_ThrowsException()
        {
            var constraint = CreateConstraint(typeof(ArgumentNullException));
            constraint.ActualException = new IndexOutOfRangeException();

            NUnit.Framework.Assert.Throws<AssertFailedException>(constraint.Verify);
        }

        [Test]
        public void Verify_ExceptionThrownMessageDoesntContainExpectedString_ThrowsException()
        {
            var constraint = CreateConstraint(typeof(ArgumentNullException), "argument1");
            constraint.ActualException = new ArgumentNullException("argument52");

            NUnit.Framework.Assert.Throws<AssertFailedException>(constraint.Verify);
        }

        [Test]
        public void Verify_ExceptionThrownAndMessageContainsExpectedStrng_DoesnThrowExpection()
        {
            var constraint = CreateConstraint(typeof(ArgumentNullException), "argument1");
            constraint.ActualException = new ArgumentNullException("argument1");

            constraint.Verify();
        }
        
        private ExpectedExceptionConstraint CreateConstraint(Type expectedExceptionType, string exceptionMessageShouldContain = null)
        {
            return new ExpectedExceptionConstraint(expectedExceptionType, exceptionMessageShouldContain);
        }
    }
}