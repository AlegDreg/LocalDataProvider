namespace DataProvider
{
    public interface IDataOperations<T>
    {
        T? Read();
        void Write(T t);
    }
}