using SixLabors.ImageSharp.PixelFormats;

namespace AscciImage
{
    public class ImageToAsciiFacade
    {
        private FileWriter _writer;
        private ImageConverterToAsciiImage _converter;

        public ImageToAsciiFacade(FileWriter writer, ImageConverterToAsciiImage converter)
        {
            _writer = writer;
            _converter = converter;
        }

        public void Convert()
        {
            try
            {
                _converter.Convert();
                _writer.Dispose();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}