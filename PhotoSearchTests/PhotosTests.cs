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

            photo.ExportString().Should().Be(expected);
        }
    }
}
