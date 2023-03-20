global using NUnit.Framework;
using CSAMGROUP7W23.Models;
using System.Linq;

namespace CSAMGROUP7W23.Tests
{
    [TestFixture]
    public class RepositoryTests
    {
        private IRepository repository;

        [SetUp]
        public void SetUp()
        {
            repository = new Repository();
        }

        [Test]
        public void Students_Property_Returns_All_Students()
        {
            // Arrange: create a list of expected students
            var expectedStudents = new[] {
                new Student { ID = 845788, Name = "Alson Basnet"},
                new Student { ID = 841895, Name = "Bablu Yadav" },
                new Student { ID = 846275, Name = "Bijay Koirala"},
                new Student { ID = 843695, Name = "Emre Uras"},
                new Student { ID = 841087, Name = "Nabin Gurung" }
            };

            // Act: get the list of actual students
            var actualStudents = repository.Students.ToArray();

            // Assert: check that the actual students match the expected students
            Assert.That(actualStudents, Is.EqualTo(expectedStudents));
        }

        [Test]
        public void Indexer_Property_Returns_Student_By_Name()
        {
            // Arrange: create a student to add to the repository
            var newStudent = new Student { ID = 123456, Name = "John Smith" };

            // Act: add the new student to the repository and retrieve it using the indexer
            repository.AddStudent(newStudent);
            var retrievedStudent = repository["John Smith"];

            // Assert: check that the retrieved student matches the added student
            Assert.That(retrievedStudent, Is.EqualTo(newStudent));
        }
    }
}