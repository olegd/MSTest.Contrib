namespace MSTest.Contrib.Constraint
{
    public class ObjectsAreEqual : IConstraint
    {
        private readonly object _expected;

        public ObjectsAreEqual (object expected)
        {
            _expected = expected;
        }

        public void Verify(object actual)
        {
            var areEqual = Equals(_expected, actual);

            if (!areEqual)
            {
                throw new AssertFailedException(
                    "Objects are not equal. Expected: {0}, but was: {1}"
                        .With(_expected, actual));
            }
        }
    }
}