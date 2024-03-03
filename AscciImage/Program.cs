using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace AscciImage
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            var origin = args[0];
            var destination = args[1];

            var writer = new FileWriter(destination);
            var image = new Image(SixLabors.ImageSharp.Image.Load<Rgba32>(origin));
            var converter = new ImageConverterToAsciiImage(writer, image);

            var imageToAsciiFacade = new ImageToAsciiFacade(writer, converter);
            imageToAsciiFacade.Convert();
        }
    }
}