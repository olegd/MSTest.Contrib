namespace MSTest.Contrib.Constraint
{
    public class Is
    {
        public static IConstraint EqualTo(object expected)
        {
            return new ObjectsAreEqual(expected); 
        }
    }
}