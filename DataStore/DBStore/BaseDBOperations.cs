using DataStore.Abstracts;
using System.Configuration;

namespace DataStore.DBStore
{
    public abstract class BaseDBOperations : Operations
    {
        private readonly string connectionString = ConfigurationManager.AppSettings["DBConnection"];
      
        public override bool Delete()
        {
            return true;
        } 

        public override string Read()
        {
            return string.Empty;
        }

        public override bool Write(string data)
        {
            string formatedData = GetFormatedData(data);           
            return true;
        }
    }
}

