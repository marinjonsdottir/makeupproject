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

        // Test constructor, takes a repository as argument.
        public PhotoController(IPhotoRepository photoRepo)
        {
            photoRepository = photoRepo;
        }

            

        public ActionResult MyProfile(int Id)  //er haegt at tengja thennan vid MyProfile i HomeController
        {
            var model = (from p in photoRepository.GetAllPhotos()
                         where p.ID == Id
                         select p).First();

            return View(model);
        }

    /*    [HttpPost]
        public int AddPhoto(string photoUrl, string comment)
        {
            // test if parameters are correct

            var username = "testuser";
            //var username1 = HttpContext.User;
            var model = photoRepository.Add(new Photo(photoUrl,comment,username));

            return RedirectToAction("MyProfile", "Home");
        } */


        // GET: /Photo/
        /*
        public ActionResult Index()
        {
            List<Photo> mockPhotos = new List<Photo>();

            Photo photo1 = new Photo("http://www.pictures4cool.com/media/images/picture-wallpaper.jpg");
            photo1.ID = 0;
            
            Photo photo2 = new Photo("http://globe-views.com/dcim/dreams/photo/photo-06.jpg");
            photo2.ID = 1;
           
            mockPhotos.Add(photo1);
            mockPhotos.Add(photo2);

            return View(mockPhotos);
        }*/
	}
}