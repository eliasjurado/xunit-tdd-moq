using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalPhotos.Controllers;
using PersonalPhotos.Models;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PersonalPhotos.Test
{
    public class PhotosTests
    {
        [Fact]
        public async Task Upload__GivenFileName_ReturnsDisplayAction()
        {
            // Arrange
            var session = Mock.Of<ISession>();
            session.Set("User", Encoding.UTF8.GetBytes("elias.jurado@globant.com"));
            var context = Mock.Of<HttpContext>(x => x.Session == session);
            var accessor = Mock.Of<IHttpContextAccessor>(x => x.HttpContext == context);

            //It's needed to add Mocks of dependecies where are injected
            var fileStorage = Mock.Of<IFileStorage>();
            var keyGen = Mock.Of<IKeyGenerator>();
            var photoMetadata = Mock.Of<IPhotoMetaData>();

            //Also we need a mock for the file we're going to upload
            var fromFile = Mock.Of<IFormFile>();
            var model = Mock.Of<PhotoUploadViewModel>(x => x.File == fromFile);

            //finally, we can test our controller initializing it
            var controller = new PhotosController(keyGen, accessor, photoMetadata, fileStorage);

            //Then call the action we're going to test
            var result = await controller.Upload(model) as RedirectToActionResult;

            //Assert. And what's going to happen
            Assert.Equal("Display", result.ActionName, ignoreCase: true);
        }

    }
}
