using Xunit;
using myWebApp.Models;

namespace myWebApp.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Student_Constructor_Should_Set_Properties()
        {
            // Arrange
            int id = 1;
            string lastName = "Akshay";
            string firstMidName = "S";
            DateTime enrollmentDate = new DateTime(2023, 3, 10);

            // Act
            Student student = new Student
            {
                ID = id,
                LastName = lastName,
                FirstMidName = firstMidName,
                EnrollmentDate = enrollmentDate
            };

            // Assert
            Assert.Equal(id, student.ID);
            Assert.Equal(lastName, student.LastName);
            Assert.Equal(firstMidName, student.FirstMidName);
            Assert.Equal(enrollmentDate, student.EnrollmentDate);
        }
    }
}
