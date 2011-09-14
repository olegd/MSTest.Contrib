using System;

namespace MSTest.Contrib
{
    public class ExpectedExceptionConstraint : IConstraint
    {
        public Type ExpectedException;
        public string ExceptionMessageShouldContain { get; set; }
        
        public ExpectedExceptionConstraint(Type expectedException, string exceptionMessageShouldContain = null)
        {
            ExpectedException = expectedException;
            ExceptionMessageShouldContain = exceptionMessageShouldContain;
        }

        public virtual void Verify(object actual)
        {
            if (actual == null)
            {
                throw new AssertFailedException(
                    "Expected exception of type: {0}, but exception wasn't thrown".With(ExpectedException));
            }

            var actualException = (Exception) actual;

            if (ExpectedException != actual.GetType())
            {
                throw new AssertFailedException(
                    "Expected exception of type: {0}, but exception of type: {1} was thrown"
                        .With(ExpectedException, actual.GetType()));
            }

            if (!string.IsNullOrWhiteSpace(ExceptionMessageShouldContain))
            {
                bool actualMessageContainsExpectedString = actualException.Message.Contains(ExceptionMessageShouldContain);
                if (actualMessageContainsExpectedString == false)
                {
                    throw new AssertFailedException(
                        "Actual exception message: {0}, does not contain expected string: {1}"
                            .With(actualException.Message, ExceptionMessageShouldContain)
                        );
                }
            }
        }
    }
}