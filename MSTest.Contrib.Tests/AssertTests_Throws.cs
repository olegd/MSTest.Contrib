using System;
using Moq;
using NUnit.Framework;

namespace MSTest.Contrib.Tests
{
    [TestFixture]
    public class AssertTests
    {
        [Test]
        public void Throws_CallsVerifyOnConstraint()
        {
            var constraintMock = new Mock<ExpectedExceptionConstraint>(typeof(ArgumentException), "");
            
            Assert.Throws(constraintMock.Object,
                () => { throw new ArgumentException(); }
            );

            constraintMock.Verify(x => x.Verify(), Times.Once());
        }

        [Test]
        public void Throws_InvokesAction()
        {
            var constraintMock = new Mock<ExpectedExceptionConstraint>(typeof(ArgumentException), "");

            bool actionWasInvoked = false;
            Assert.Throws(constraintMock.Object,
                () => { actionWasInvoked = true; }
            );

            Assert.IsTrue(actionWasInvoked);
        }
    }
}