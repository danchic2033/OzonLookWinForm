using Image = System.Drawing.Image;

namespace OzonLookWinForm
{
    public static class PhotoRepository
    {
        public static string Path = @"c:\Users\Daniil\source\repos\Проекты портфолио\WinForm Online примерка вещей с Озон\Images\Desktop\";
        public static List<Photo> GetPhotos()
        {
            List<Photo> photoList = new List<Photo>();

            var directories = Directory.GetDirectories(Path);

            for (int i = 0; i < directories.Length; i++)
            {
                var photo = new Photo();
                photo.Images = new List<Image>();

                var files = Directory.GetFiles(directories[i]);

                for (int j = 0; j < files.Length; j++)
                {
                    Image img = Image.FromFile(files[j]);
                    photo.Images.Add(img);
                }
                photoList.Add(photo);
            }

            return photoList;
        }
    }
}
