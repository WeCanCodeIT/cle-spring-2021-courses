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

        [Fact]
        public void Create_Returns_A_View()
        {
            // Arrange

            //Act

            var result = sut.Create();

            //Assert

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Adds_A_Model()
        {
            //Arrange
            Course model = new Course() { Name = "Sample Course", Description = "Sample course that should be deleted later.", InstructorId = 1 };

            //Act
            var result = sut.Create(model);

            //Assertion
            Assert.Equal("You have successfully saved this course.", result.ViewData["Result"]);

        }

        [Theory]
        [InlineData(1)]
        public void Update_Returns_A_View(int id)
        {
            // Arrange
            var courseToUpdate = new Course();
            courseRepo.GetById(id).Returns(courseToUpdate);
            //Act

            var result = sut.Update(id);

            //Assert

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Passes_Course_To_View()
        {
            // Arrange
            var courseToUpdate = new Course();
            courseRepo.GetById(1).Returns(courseToUpdate);
            courseToUpdate.Description = "Update to description.";

            // Act
            var result = (ViewResult)sut.Update(courseToUpdate);

            //Assertion
            Assert.Equal("You have successfully updated this course.", result.ViewData["Result"]);
        }

        [Fact]
        public void Delete_Course_Successfully()
        {
            // Arrange
            int courseId = 1;
            
            // Act
            var result = (ViewResult)sut.Delete(courseId);

            //Assertion
            Assert.IsType<RedirectToActionResult>(result);
        }



    }
}
