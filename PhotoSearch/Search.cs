using System.Text;

namespace PhotoSearch
{
    public record Search
    {
        public string GetPhoto(int photoId)
        {
            Photos photos = new Photos();

            IPhoto photo = photos.GetPhotoById(photoId);

            StringBuilder stringBuilder = new StringBuilder();

            return photo.ExportString(stringBuilder).ToString();
        }

        public string GetPhotoOrAlbum(string input)
        {
            if (input.StartsWith("a"))
            {
                Photos photos = new Photos();

                string trimmedAlbumInput = input.Substring(1);

                return photos.GetAlbumBy(int.Parse(trimmedAlbumInput));
            }

            string trimmedInput = input.Substring(1);
            return GetPhoto(int.Parse(trimmedInput));
        }
    }
}