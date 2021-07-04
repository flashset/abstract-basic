namespace DataStore.Abstracts
{
    public interface IOperations
    {
        bool Write(string data);

        string Read();

        bool Delete();

        string GetFormatedData(string data);
    }

    public abstract class Operations: IOperations
    {
        public abstract bool Write(string data);

        public abstract string Read();

        public abstract bool Delete();

        public abstract string GetFormatedData(string data);
    }
}
