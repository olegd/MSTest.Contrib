namespace MSTest.Contrib
{
    public interface IConstraint
    {
        void Verify(object actual);
    }
}