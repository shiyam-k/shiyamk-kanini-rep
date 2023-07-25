using Employee_Management_API.Controllers;
using Employee_Management_API.Models_Reques__Response_;
using Employee_Management_API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace APITest
{
    public class UnitTest1
    {
        [Fact]
        public void Profile_Test_1()
        {
            ProfileResponse user = new ProfileResponse();
            var userRepository = new Mock<IRepoProfile>();
            userRepository.Setup(x => x.ViewProfile(It.IsAny<string>())).Returns(user);
            ProfileController userController = new ProfileController(userRepository.Object);
            var getUserById = userController?.GetProfile("0000");
            Assert.IsType<ActionResult<ProfileResponse>>(getUserById);
        }
        [Fact]
        public void Profile_Test_2()
        {
            var user = new ProfileResponse();
            var userRepository = new Mock<IRepoProfile>();
            userRepository.Setup(x => x.ViewProfile(It.IsAny<string>())).Returns(user);
            ProfileController userController = new ProfileController(userRepository.Object);
            ProfileResponse? getUserById = userController.GetProfile("SID105").Value;
            Assert.IsType<string>(getUserById?.Message);
        }
        [Fact]
        public void Profile_Test_3()
        {
            var user = new ProfileResponse();
            var userRepository = new Mock<IRepoProfile>();
            userRepository.Setup(x => x.ViewProfile(It.IsAny<string>())).Returns(user);
            ProfileController userController = new ProfileController(userRepository.Object);
            var getUserById = userController.GetProfile("SID891");
            Assert.IsType<string>(getUserById);
        }
    }
}