using System;

namespace MSTest.Contrib
{
    public class ExpectedExceptionConstraint
    {
        public Type ExpectedException;
        public string ExceptionMessageShouldContain { get; set; }
        public Exception ActualException { get; set; }

        public ExpectedExceptionConstraint(Type expectedException, string exceptionMessageShouldContain)
        {
            ExpectedException = expectedException;
            ExceptionMessageShouldContain = exceptionMessageShouldContain;
        }

        public void Verify()
        {
            if (ActualException == null)
            {
                throw new AssertFailedException(
                    "Expected exception of type: {0}, but exception wasn't thrown".With(ExpectedException));
            }

            if (ExpectedException != ActualException.GetType())
            {
                throw new AssertFailedException(
                    "Expected exception of type: {0}, but exception of type: {1} was thrown"
                        .With(ExpectedException, ActualException.GetType()));
            }

            if (!string.IsNullOrWhiteSpace(ExceptionMessageShouldContain))
            {
                bool actualMessageContainsExpectedString = ActualException.Message.Contains(ExceptionMessageShouldContain);
                if (actualMessageContainsExpectedString == false)
                {
                    throw new AssertFailedException(
                        "Actual exception message: {0}, does not contain expected string: {1}"
                            .With(ActualException.Message, ExceptionMessageShouldContain)
                        );
                }
            }
        }
    }
}