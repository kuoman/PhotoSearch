using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotoDataTests
    {
        [TestMethod]
        public void ShouldContain5000Photos()
        {
            PhotoData photoData = new PhotoData();

            photoData.NumberOfPhotos().Should().Be(5000);
        }

        [TestMethod]
        public void ShouldContain100Albums()
        {
            PhotoData photoData = new PhotoData();

            photoData.NumberOfAlbums().Should().Be(100);
        }

        [TestMethod]
        [DataRow(53, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            PhotoData photoData = new PhotoData();

            Photo photo = photoData.GetPhotoById(id);

            photo.id.Should().Be(id);
            photo.ExportString().Should().Be(expected);
        }

    }
}
