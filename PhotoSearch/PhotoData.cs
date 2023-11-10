﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PhotoSearch
{
    public class PhotoData
    {       
        private string json =

        List<Photo>? result = JsonConvert.DeserializeObject<List<Photo>>(json);
        
        public int NumberOfPhotos()
        {
            return result.Count;
        }

 
        public int NumberOfAlbums()
        {
            return result.DistinctBy(x => x.albumId).Count();
        }
    }
}