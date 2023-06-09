﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void AddStudent_WithValidStudent_ShouldAddToDictionary()
        {
            // Arrange
            var repository = new Repository();
            var student = new Student { ID = 123456, Name = "John Doe" };

            // Act
            repository.AddStudent(student);

            // Assert
            Assert.AreEqual(student, repository[student.Name]);
        }

        [TestMethod]
        public void AddStudent_WithDuplicateStudent_ShouldThrowException()
        {
            // Arrange
            var repository = new Repository();
            var student = new Student { ID = 845788, Name = "Alson Basnet" };

            // Act & Assert
            Assert.ThrowsException<System.ArgumentException>(() => repository.AddStudent(student));
        }

    }
