using makeup1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace makeup1.ViewModels
{
    public class PhotoViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Photo required")]  //eigum vid ekki potto ad hafa thetta med
        public string Photo { get; set; }

        public DateTime DateInserted { get; set; }

        [Required(ErrorMessage = "Text required")]
        public string Text { get; set; }

      //  public List<Hashtag> Hashtags { get; set; }
    }
}