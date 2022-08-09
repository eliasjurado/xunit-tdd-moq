using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PersonalPhotos.Controllers;
using PersonalPhotos.Models;
using System.Threading.Tasks;
using Xunit;

namespace PersonalPhotos.Test
{
    public class LoginsTests
    {
        private readonly LoginsController _controller;
        private readonly Mock<ILogins> _logins;
        private readonly Mock<IHttpContextAccessor> _accessor;

        public LoginsTests()
        {
            _logins = new Mock<ILogins>();

            // mocking for test session when the user and pass are ok
            var session = Mock.Of<ISession>();
            var httpContext = Mock.Of<HttpContext>(x => x.Session == session);

            _accessor = new Mock<IHttpContextAccessor>();
            _accessor.Setup(x => x.HttpContext).Returns(httpContext);

            _controller = new LoginsController(_logins.Object, _accessor.Object);
        }
        // when the model is valid
        [Fact]
        public void Index_GivenNorReturnUrl_ReturnLoginView()
        {
            var result = (_controller.Index() as ViewResult);
            Assert.IsAssignableFrom<IActionResult>(result); // do the same as the before line

            Assert.NotNull(result);
            Assert.Equal("Login", result.ViewName, ignoreCase: true);
        }

        // when model is invalid, the app doesnt crash
        [Fact]
        public async Task Login_GivenModelStateInvalid_ReturnLoginView()
        {
            _controller.ModelState.AddModelError("Test", "Test");

            var result = await _controller.Login(Mock.Of<LoginViewModel>()) as ViewResult;
            Assert.Equal("Login", result.ViewName, ignoreCase: true);
        }

        [Fact]
        public async Task Login_GivenCorrectPassword_RedirectToDisplayAction()
        {
            const string password = "123456";
            const string email = "elias.jurado@globant.com";
            var modelView = Mock.Of<LoginViewModel>(x => x.Email == email && x.Password == password);
            var model = Mock.Of<User>(x => x.Password == password);

            // with returnsasync it's no needed to write async at the begining of the line
            _logins.Setup(x => x.GetUser(It.IsAny<string>())).ReturnsAsync(model);
            //It.Any can be used to call parameters or arguments of methods

            var result = await _controller.Login(modelView);

            Assert.IsType<RedirectToActionResult>(result);//this checks if the action finally goes to the view
        }
    }
}
