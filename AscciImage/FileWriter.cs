namespace AscciImage
{
    public class FileWriter : IDisposable
    {
        private StreamWriter _streamWriter;

        public FileWriter(string file)
        {
            _streamWriter = new StreamWriter(file);
        }

        public void SetFile(string file)
        {
            _streamWriter = new StreamWriter(file);
        }

        public void Write(char content)
        {
            _streamWriter.Write(content);
        }

        public void WriteLine(string? content)
        {
            _streamWriter.WriteLine(content);
        }

        public void Close()
        {
            _streamWriter.Close();
        }

        public void Dispose()
        {
            Close();
            _streamWriter.Dispose();
        }
    }
}