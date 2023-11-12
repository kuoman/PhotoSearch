using System.Text;
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

            StringBuilder stringBuilder = new StringBuilder();

            nullPhoto.ExportString(stringBuilder).ToString().Should().Contain("Photo not found");
        }
    }
}
