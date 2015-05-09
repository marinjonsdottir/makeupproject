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
            return db.Photos;
        }

        public void Add(Photo photo) //a thetta ad vera photo eda tharf ad vera string?
        {
            db.Photos.Add(photo);
            db.SaveChanges();  //Tharf ad vera e-d meira her?
        }

        //her getum vid verid med delete ef vid viljum
    }
}