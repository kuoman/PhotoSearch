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
    }
}