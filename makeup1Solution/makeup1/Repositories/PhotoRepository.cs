using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using makeup1.Models;

namespace makeup1.Repositories
{
    public class PhotoRepository : IPhotoRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IEnumerable<Photo> GetAllPhotos() 
        {
           
            return null;
        }
    }
}