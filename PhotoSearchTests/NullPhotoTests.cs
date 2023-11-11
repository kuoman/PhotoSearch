using FluentAssertions;
using PhotoSearch;

namespace PhotoSearchTests
{
    [TestClass]
    public class NullPhotoTests
    {
        [TestMethod]
        public void ShouldReturnNotFoundExportString()
        {
            IPhoto nullPhoto = new NullPhoto();

            nullPhoto.ExportString().Should().Be("Photo not found");
        }
    }
}
