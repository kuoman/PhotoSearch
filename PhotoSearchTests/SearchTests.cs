using FluentAssertions;
using PhotoSearch;


namespace SearchTests
{
    [TestClass]
    public class SearchTests
    {
        [TestMethod]
        [DataRow(53, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            Search photoSearch = new Search();

            string photoData = photoSearch.GetPhoto(id);

            photoData.Should().Be(expected);
        }

        [TestMethod]
        public void ShouldGetPhotoStringFromRawInput()
        {
            Search search = new Search();

            string outputString = search.GetPhotoOrAlbum("p53");

            outputString.Should().Be("[53] soluta et harum aliquid officiis ab omnis consequatur");
        }

        [TestMethod]
        public void ShouldGetPhotoAlbumName()
        {
            Search search = new Search();

            string outputString = search.GetPhotoOrAlbum("a3");

            outputString.Should().Contain("photo-album 3");
        }
    }
}