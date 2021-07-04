using DataStore.Abstracts;
using System.IO;

namespace DataStore.FileStore
{
    public abstract class BaseFileOperations: Operations
    {
        private const string filePath = @"E:\Examples\sparkyflash\abstract-basic\file.txt";
  
        public override bool Delete()
        {
            // Clear the file content
            File.WriteAllText(filePath, string.Empty);
            return true;
        }

        public override string Read()
        {
            return File.ReadAllText(filePath);
        }

        public override bool Write(string data)
        {
            // GetFormatedData should be implemented in the inherited class
            string formatedData = GetFormatedData(data);
            File.AppendAllText(filePath, formatedData);
            return true;
        }
    }
}
