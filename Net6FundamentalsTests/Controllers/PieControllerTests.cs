using Net6Fundamentals.Controllers;
using Net6Fundamentals.Models;
using Net6FundamentalsTests.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace Net6FundamentalsTests.Controllers
{
    public class PieControllerTests
    {
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var mockPieRepository = RepositoryMocks.GetPieRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            //act
            var result = pieController.List("");

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var pieListViewModel = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);
            Assert.Equal(10, pieListViewModel.Pies.Count());
        }
    }
}
