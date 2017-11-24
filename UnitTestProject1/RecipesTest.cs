using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp2;
using WpfApp2.Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class RecipesTest
    {
        [TestMethod]
        public void CheckIfRecipeRepositoryIsOkTest()
        {
            //Arrange
            var instance = new RecipesRepository();
            var repo = instance.Retrieve();
            var expected = true;

            //Act
            var actual = instance.CheckIfRecipeRepositoryIsOk(repo);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CheckInvalidRecipeRepositoryIfFailedTest()
        {
            //Arrange
            var instance = new RecipesRepository();
            var repo = instance.RetrieveBadValueRepo();
            var expected = false;

            //Act
            var actual = instance.CheckIfRecipeRepositoryIsOk(repo);

            //Assert
            Assert.AreEqual(actual, expected);
        }

    }
}
