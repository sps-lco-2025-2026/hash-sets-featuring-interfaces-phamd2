namespace SPSStudent
{
    public interface IHashSet<T> where T : SPSStudent, IEquatable<T>
    {
        T Add(T value);
        bool IsPresent(T value);
        void Rebalance();
    }

    public interface SPSStudent : IEquatable<SPSStudent>
    {
        string Name { get; }
        SchoolYear Year { get; }
        string Tutor { get; }
    }
}
