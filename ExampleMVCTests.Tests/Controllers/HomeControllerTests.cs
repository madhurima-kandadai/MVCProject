using System;
using ExampleMVCTests.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceProject;
using ServiceProject.Entities;

namespace ExampleMVCTests.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        Mock<ICategoryService> serviceMock;
        HomeController controller;
        public HomeControllerTests()
        {
            serviceMock = new Mock<ICategoryService>();
            controller = new HomeController(serviceMock.Object);
        }
        [TestMethod]
        public void InsertCategory_Tests()
        {
            serviceMock.Setup(x => x.InsertCategory(It.IsAny<Category>())).Returns(1);
            var result = controller.InsertCategory(new Category { CategoryId = 15 ,CategoryName = "test" });
            serviceMock.VerifyAll();
        }
    }
}
