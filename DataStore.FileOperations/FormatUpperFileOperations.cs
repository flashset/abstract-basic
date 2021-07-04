using DataStore.FileStore;

namespace DataStore.FileOperations
{ 
    public class FormatUpperFileOperations : BaseFileOperations
    {
        public override string GetFormatedData(string data)
        {
            // change the data to upper case
            return data.ToUpper();
        }
    }
}
