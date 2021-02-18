using cle_spring_2021_courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace cle_spring_2021_courses.Tests
{
    public class CourseTests
    {
        Course sut;

        public CourseTests()
        {
            sut = new Course(42, "Course name", "This is the course description");
        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_CourseModel()
        {
            // Arrange

            // Act
            int result = sut.Id;

            // Assert

            Assert.Equal(42, result);

        }

        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            // Arrange



            // Act
            string result = sut.Name;


            // Assert
            Assert.Equal("Course name", result);
        }
        [Fact]
        public void CourseConstructor_Sets_Description_On_CourseModel()
        {
            // Arrange


            // Act
            string result = sut.Description;


            // Assert
            Assert.Equal("This is the course description", result);

        }







    }
}
