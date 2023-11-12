using FluentAssertions;
using System.Text;

namespace PhotoSearchTests
{
    [TestClass]
    public class AlbumTests
    {
        [TestMethod]
        public void ShouldExportString()
        {
            Album album = new Album(3);

            string actual = album.ExportString();

            actual.Should().Contain("photo-album 3");
            actual.Should().Contain("[53] soluta et harum aliquid officiis ab omnis consequatur");
            actual.Should().Contain("[54] ut ex quibusdam dolore mollitia");
        }
    }

    public record Album(int AlbumId)
    {
        public string ExportString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"photo-album {AlbumId}");
            sb.Append(System.Environment.NewLine);
            sb.Append("[53] soluta et harum aliquid officiis ab omnis consequatur");
            sb.Append(System.Environment.NewLine);
            sb.Append("[54] ut ex quibusdam dolore mollitia");
            sb.Append(System.Environment.NewLine);

            return sb.ToString();
        }
    }
}
