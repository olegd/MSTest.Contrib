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
            
            Assert.Throws(() => { throw new ArgumentException(); }, constraintMock.Object);

            constraintMock.Verify(x => x.Verify(It.IsAny<ArgumentException>()), Times.Once());
        }

        [Test]
        public void Throws_InvokesAction()
        {
            var constraintMock = new Mock<ExpectedExceptionConstraint>(typeof(ArgumentException), "");

            bool actionWasInvoked = false;
            Assert.Throws(() => { actionWasInvoked = true; }, constraintMock.Object);

            Assert.IsTrue(actionWasInvoked);
        }

        [Test]
        public void That_CallsVerifyOnConstraint()
        {
            var constraintMock = new Mock<IConstraint>();
            const string actualObject = "actual object";

            Assert.That(actualObject, constraintMock.Object);

            constraintMock.Verify(x => x.Verify(actualObject), Times.Once());
        }
    }
}