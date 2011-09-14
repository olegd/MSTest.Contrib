using MSTest.Contrib.Constraint;
using NUnit.Framework;

namespace MSTest.Contrib.Tests
{
    [TestFixture]
    public class ObjectsAreEqualTests
    {
        [Test]
        public void Verify_ObjectsAreEqual_DoesNotThrowException()
        {
            var constraint = new ObjectsAreEqual("test");

            constraint.Verify("test");
        }

        [Test]
        public void Verify_ObjectsAreNotEqual_ThrowException()
        {
            var constraint = new ObjectsAreEqual("test");

            Assert.Throws<AssertFailedException>(
                () => constraint.Verify("something else")
            );
        }
    }
}