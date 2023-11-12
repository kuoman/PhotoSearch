using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotoTests
    {
        [TestMethod]
        public void ShouldCreateProperExportString()
        {
            IPhoto photo = new Photo(1, 1, "a", "b", "c");

            photo.ExportString().Should().Be("[1] a");
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectPhotoId()
        {
            IPhoto photo = new Photo(1, 1, "a", "b", "c");

            photo.HasId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectPhotoId()
        {
            IPhoto photo = new Photo(1, 1, "a", "b", "c");

            photo.HasId(2).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectAlbumId()
        {
            IPhoto photo = new Photo(1, 1, "a", "b", "c");

            photo.HasAlbumId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectAlbumId()
        {
            IPhoto photo = new Photo(1, 1, "a", "b", "c");

            photo.HasAlbumId(2).Should().BeFalse();
        }
    }
}
