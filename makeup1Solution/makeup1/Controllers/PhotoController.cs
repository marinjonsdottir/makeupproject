using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using makeup1.Models;
using makeup1.Repositories;

namespace makeup1.Controllers
{
    public class PhotoController : Controller
    {
        // Hann ætti að hafa photo repository 
        IPhotoRepository photoRepository;

        public PhotoController()
        {
            photoRepository = new PhotoRepository();
        }

        public PhotoController(IPhotoRepository photoRepo)
        {
            photoRepository = photoRepo;
        }

        //
        // GET: /Photo/
        public ActionResult Index()
        {
            List<Photo> mockPhotos = new List<Photo>();

            Photo photo1 = new Photo();
            photo1.ID = 0;
            photo1.photo = "http://www.pictures4cool.com/media/images/picture-wallpaper.jpg";

            Photo photo2 = new Photo();
            photo2.ID = 1;
            photo2.photo = "http://globe-views.com/dcim/dreams/photo/photo-06.jpg";

            mockPhotos.Add(photo1);
            mockPhotos.Add(photo2);

            return View(mockPhotos);
        }
	}
}