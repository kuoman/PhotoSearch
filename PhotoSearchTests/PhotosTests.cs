using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotosTests
    {
        [TestMethod]
        public void ShouldContain5000Photos()
        {
            Photos photos = new Photos();

            photos.NumberOfPhotos().Should().Be(5000);
        }

        [TestMethod]
        public void ShouldContain100Albums()
        {
            Photos photos = new Photos();

            photos.NumberOfAlbums().Should().Be(100);
        }

        [TestMethod]
        [DataRow(53, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            Photos photos = new Photos();

            Photo photo = photos.GetPhotoById(id);

            photo.id.Should().Be(id);
            photo.ExportString().Should().Be(expected);
        }

    }
}
