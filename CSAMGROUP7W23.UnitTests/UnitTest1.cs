using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSAMGROUP7W23.UnitTests
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void CanBeAddedBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange 
            var student = new Student();
            // Act
            var result = student.CanBeAddedBy(new Student { IsAdmin = true });



            // Assert
            Assert.IsTrue(result);
        }
        
       

      
}
}
