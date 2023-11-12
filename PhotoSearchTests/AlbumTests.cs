using FluentAssertions;

namespace PhotoSearchTests
{
    [TestClass]
    public class AlbumTests
    {
        [TestMethod]
        public void ShouldExportString()
        {
            Album album = new Album();

            string actual = album.ExportString();

            actual.Should().Contain("photo-album 3");
        }
    }

    public class Album
    {
        public string ExportString()
        {
            return "photo-album 3";
        }
    }
}
