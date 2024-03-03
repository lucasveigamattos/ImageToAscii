namespace AscciImage
{
    public class ImageConverterToAsciiImage
    {
        private FileWriter _fileWriter;
        private Image _image;
        private char[] _characters = {'.', '\'', '`', '^', '"', ',', ':', ';', 'I', 'l', '!', 'i', '>', '<', '~', '+', '_', '-', '?', ']', '[', '}', '{', '1', ')', '(', '|', '/', 't', 'f', 'j', 'r', 'x', 'n', 'u', 'v', 'c', 'z', 'X', 'Y', 'U', 'J', 'C', 'L', 'Q', '0', 'O', 'Z', 'm', 'w', 'q', 'p', 'd', 'b', 'k', 'h', 'a', 'o', '*', '#', 'M', 'W', '&', '8', '%', 'B', '@', '$' };

        public ImageConverterToAsciiImage(FileWriter fileWriter, Image image)
        {
            _fileWriter = fileWriter;
            _image = image;
        }

        public void SetWriter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void SetImage(Image image)
        {
            _image = image;
        }

        public char GetCharacterCorrespondingToBrightness(float brightness)
        {
            return _characters[(int)Math.Round(brightness * (_characters.Length - 1))];
        }

        public void Convert()
        {
            for (int i = 0; i < _image.Height; i++)
            {
                for (int j = 0; j < _image.Width; j++)
                {
                    float brightness = _image.GetPixelBrightness(j, i);
                    char character = GetCharacterCorrespondingToBrightness(brightness);

                    _fileWriter.Write(character);
                }

                _fileWriter.WriteLine(null);
            }
        }
    }
}