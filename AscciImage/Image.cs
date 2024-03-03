using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace AscciImage
{
    public class Image
    {
        private Image<Rgba32> _image;

        public Image(Image<Rgba32> image)
        {
            _image = image;
        }

        public int Width
        {
            get { return _image.Width; }
        }

        public int Height
        {
            get { return _image.Height; }
        }

        public float GetPixelBrightness(int x, int y)
        {
            Rgba32 pixel = _image[x, y];
            int maxChannelValue = 255;
            int channelsQuantity = 3;

            return (Convert.ToSingle(pixel.R) + Convert.ToSingle(pixel.G) + Convert.ToSingle(pixel.B)) / (maxChannelValue * channelsQuantity);
        }
    }
}