using System;
using Moq;
using NUnit.Framework;
using NUnit.Mocks;

namespace MSTest.Contrib.Tests
{
    [TestFixture]
    public class AssertTests_Throws
    {
        [Test]
        public void ExpectedArgumentException_CodeThrowsArgumentException_Passes()
        {
//            Mock<IAssertCommunicator> _assertCommunicatorMock;

//            Assert.AssertCommunicator

            Assert.Throws<ArgumentException>(
                () => { throw new ArgumentException(); }
            );
        }
    }
}