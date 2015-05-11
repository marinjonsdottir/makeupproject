﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace makeup1.Models
{
    public class Photo
    {

        public int ID { get; set; }
        public string photoUrl { get; set; }
        public string UserId { get; set; }
        public string Caption { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("HashtagPhotoId")]
        public List<Hashtag> hashTags { get; set; }
    }
}