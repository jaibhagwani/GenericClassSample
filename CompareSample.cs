
namespace GenericClassSample
{
    public class CompareSample<T>
    {
        public bool CompareValues(T obj1, T obj2)
        {
            if (obj1.Equals(obj2))
            {
                return true;
            }

            return false;
        }
    }
}
