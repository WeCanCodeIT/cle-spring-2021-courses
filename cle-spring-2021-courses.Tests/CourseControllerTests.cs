using cle_spring_2021_courses.Controllers;
using cle_spring_2021_courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace cle_spring_2021_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController sut;

        public CourseControllerTests()
        {
            //sut = new CourseController();
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Arrange
            //CourseController sut = new CourseController();

            //Act

            var result = sut.Index();

            //Assert

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Index_Returns_CourseModel_To_View()
        {
            // Arrange

            // Act
            var result = sut.Index();

            // Assert
            Assert.IsType<Course>(result.Model);

        }

    }
}
