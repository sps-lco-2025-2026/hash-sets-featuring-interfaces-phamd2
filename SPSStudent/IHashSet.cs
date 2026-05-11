namespace SPSStudent
{

    public class HashSet<T> : IHashSet<T> where T : SPSStudent, IEquatable<T>
    {
        private List<T>[] _locations;
        private int _count;


        public HashSet(int size = 10)
        {
            _locations = new List<T>[size];
            _count = 0;

            for (int i = 0; i < size; i++)
            {
                _locations[i] = new List<T>();
            }
        }


        public T Add(T value)
        {

            int location = value.GetHashCode() % _locations.Length;
            if(IsPresent(value) == true)
                return value;
            _locations[location].Add(value);
            _count++;
            return value;
        }
        
        public bool IsPresent(T item)
        {
            if (item == null) return false;

            int location = item.GetHashCode() % _locations.Length;

            foreach (T student in _locations[location])
            {
                if (student.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Rebalance()
        {
            int newSize = _locations.Length*2;
            List<T>[] newLocations = new List<T>[newSize];

            for (int i = 0; i < newSize; i++)
            {
                newLocations[i] = new List<T>();
            }
            foreach (List<T> location in _locations)
            {
                foreach (T student in location)
                {
                    int newLocation = student.GetHashCode() % newSize;
                    newLocations[newLocation].Add(student);
                }
            }
            _locations = newLocations;
        }
    }
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
