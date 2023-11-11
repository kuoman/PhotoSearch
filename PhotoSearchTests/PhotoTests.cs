using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Photo photo = new Photo(1, 1, "a", "b", "c");

            photo.ExportString().Should().Be("[1] a");
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectPhotoId()
        {
            Photo photo = new Photo(1, 1, "a", "b", "c");

            photo.HasId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectPhotoId()
        {
            Photo photo = new Photo(1, 1, "a", "b", "c");

            photo.HasId(2).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldBeTrueIfCorrectAlbumId()
        {
            Photo photo = new Photo(1, 1, "a", "b", "c");

            photo.HasAlbumId(1).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldBeFalseIfIncorrectAlbumId()
        {
            Photo photo = new Photo(1, 1, "a", "b", "c");

            photo.HasAlbumId(2).Should().BeFalse();
        }
    }
}
