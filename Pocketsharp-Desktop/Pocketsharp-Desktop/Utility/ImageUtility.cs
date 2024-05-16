namespace Pocketsharp_Desktop.Utility
{
    internal class ImageUtility
    {
        public static byte[] ImageToByteArray(Image image)
        {
            using MemoryStream ms = new();
            Bitmap bitmap = new(image);
            bitmap.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] data)
        {
            using MemoryStream ms = new(data);
            return new Bitmap(Image.FromStream(ms));
        }
    }
}
