using System.Text;
using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class PhotoTests
    {
        private IPhoto _photo;

        [TestInitialize]
        public void Initialize()
        {
            _photo = new Photo(1, 1, "a", "b", "c");
        }

        [TestMethod]
        public void ShouldCreateProperExportString()
        {
            StringBuilder sb = new StringBuilder();

            _photo.ExportString(sb).ToString().Should().Contain("[1] a");
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectPhotoId()
        {
            _photo.HasId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectPhotoId()
        {
            _photo.HasId(2).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectAlbumId()
        {
            _photo.HasAlbumId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectAlbumId()
        {
            _photo.HasAlbumId(2).Should().BeFalse();
        }
    }
}
