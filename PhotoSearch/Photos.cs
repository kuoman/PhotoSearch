﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PhotoSearch
{
    // album 1 = 50
    public class Photos
    {       
        private static string json =

        List<Photo>? photos = JsonConvert.DeserializeObject<List<Photo>>(json);
        
        public int NumberOfPhotos()
        {
            return photos.Count;
        }

        public int NumberOfAlbums()
        {
            return photos.DistinctBy(x => x.albumId).Count();
        }

        public Photo GetPhotoById(int id)
        {
            return photos.FirstOrDefault(x => x.id == id);
        }
    }
}