using System.Text;
using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotosTests
    {
        [TestMethod]
        [DataRow(53, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        [DataRow(5001, "Photo not found")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            Photos photos = new Photos();

            IPhoto photo = photos.GetPhotoById(id);

            StringBuilder stringBuilder = new StringBuilder();

            photo.ExportString(stringBuilder).ToString().Should().Contain(expected);
        }

        [TestMethod]
        [DataRow(3, "photo-album 3")]
        [DataRow(2, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        public void ShouldReturnGivenAlbumById(int albumId, string containsString)
        {
            Photos photos = new Photos();

            string exportString = photos.GetAlbumBy(albumId);

            exportString.Should().Contain(containsString);
        }
    }
}
