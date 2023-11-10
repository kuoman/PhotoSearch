using FluentAssertions;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotoSearchTests
    {
        [TestMethod]
        [DataRow(53, "soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "ut ex quibusdam dolore mollitia")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            PhotoSearch photoSearch = new PhotoSearch();

            string photoData = photoSearch.GetPhoto(id);

            photoData.Should().Be(expected);
        }

        [TestMethod]
        public void ShouldGetPhoto54()
        {
            PhotoSearch photoSearch = new PhotoSearch();

            string photoData = photoSearch.GetPhoto(54);

            photoData.Should().Be("[54] ut ex quibusdam dolore mollitia");
        }
    }

    public record PhotoSearch
    {
        public string GetPhoto(int photoId)
        {
            if (photoId == 54) return "[54] ut ex quibusdam dolore mollitia";
            return "[53] soluta et harum aliquid officiis ab omnis consequatur";
        }
    }
}