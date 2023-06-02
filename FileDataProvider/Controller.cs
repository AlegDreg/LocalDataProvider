using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Controller<T>
    {
        public T? Data { get; set; }
        private IDataOperations<T> _operations;

        public Controller(IDataOperations<T> dataOperations)
        {
            _operations = dataOperations;
            Read();
        }

        public void Read()
        {
            Data = _operations.Read();
        }

        public void CreateDefault()
        {
            _operations.Write((T)Activator.CreateInstance(typeof(T)));
        }
    }
}