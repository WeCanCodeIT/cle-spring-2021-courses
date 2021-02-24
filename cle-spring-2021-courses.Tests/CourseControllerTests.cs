using cle_spring_2021_courses.Controllers;
using cle_spring_2021_courses.Models;
using cle_spring_2021_courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace cle_spring_2021_courses.Tests
{
    public class CourseControllerTests
    {
        CourseController sut;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            courseRepo = Substitute.For<IRepository<Course>>();
            sut = new CourseController(courseRepo);
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
            List<Course> expectedCourses = null;
            courseRepo.GetAll().Returns(expectedCourses);

            // Act
            var result = sut.Index();

            // Assert
            //Assert.IsType<List<Course>>(result.Model);
            Assert.Equal(expectedCourses, result.Model);

        }

        [Fact]
        public void Details_Returns_A_View()
        {
            // Arrange

            // Act
            var result = sut.Details(1);

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            // Arrange
            var expectedCourse = new Course();
            courseRepo.GetById(1).Returns(expectedCourse);

            // Act
            var result = sut.Details(1);

            //Assertion
            Assert.Equal(expectedCourse, result.Model);
        }

    }
}
