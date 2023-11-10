﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Newtonsoft.Json;

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

    public class PhotoData
    {
        public int NumberOfPhotos()
        {
            List<Photo>? result = JsonConvert.DeserializeObject<List<Photo>>(json);

            return result.Count;
        }

        private string json =
    }

    public record Photo (int albumId, int id, string title, string url, string thumbnailUrl)
    {
    }
}