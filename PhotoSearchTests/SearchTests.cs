using FluentAssertions;
using PhotoSearch;


namespace SearchTests
{
    [TestClass]
    public class SearchTests
    {
        private Search _search;

        [TestInitialize]
        public void Initialize()
        {
            _search = new Search();
        }

        [TestMethod]
        [DataRow(53, "[53] soluta et harum aliquid officiis ab omnis consequatur")]
        [DataRow(54, "[54] ut ex quibusdam dolore mollitia")]
        public void ShouldReturnPhotoGivenId(int id, string expected)
        {
            string photoData = _search.GetPhoto(id);

            photoData.Should().Contain(expected);
        }

        [TestMethod]
        public void ShouldGetPhotoStringFromRawInput()
        {
            string outputString = _search.GetPhotoOrAlbum("p53");

            outputString.Should().Contain("[53] soluta et harum aliquid officiis ab omnis consequatur");
        }

        [TestMethod]
        public void ShouldGetPhotoAlbumName()
        {
            string outputString = _search.GetPhotoOrAlbum("a3");

            outputString.Should().Contain("photo-album 3");
        }
    }
}