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
    }
}
