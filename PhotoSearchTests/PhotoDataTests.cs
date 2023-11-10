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

    }
}
