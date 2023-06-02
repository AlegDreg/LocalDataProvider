namespace DataProvider
{
    public class FileDataProvider<T> : IDataOperations<T>
    {
        private string _fileName;
        public FileDataProvider(string path)
        {
            _fileName = path;
        }

        public T? Read()
        {
            try
            {
                using (StreamReader st = new StreamReader(_fileName))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(st.ReadToEnd());
                }
            }
            catch
            {
                return default(T);
            }
        }

        public void Write(T t)
        {
            using (StreamWriter st = new StreamWriter(_fileName))
            {
                st.Write(Newtonsoft.Json.JsonConvert.SerializeObject(t));
            }
        }
    }
}