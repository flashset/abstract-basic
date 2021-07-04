using DataStore.Abstracts;
using DataStore.FileOperations;

namespace DataStore.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperations customeFileOperations = new FormatNewLineFileOperations();
            customeFileOperations.Write("Welcome to Abstract Basic - New Line");

            IOperations customeDBOperations = new FormatUpperFileOperations();
            customeDBOperations.Write("Welcome to Abstract Basic - Uppercase");
        }
    }
}
