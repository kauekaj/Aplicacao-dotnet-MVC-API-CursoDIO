using CursoDioAPI.Controllers;
using CursoDioMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTeste
{
    public class CategoryControllerTest
    {
        private readonly Mock<DbSet<Category>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Category _category;

        public CategoryControllerTest()
        {
            _mockSet = new Mock<DbSet<Category>>();
            _mockContext = new Mock<Context>();
            _category = new Category { Id = 1, Descricao = "Teste Categoria" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);

            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_category);
        }


        [Fact]
        public async Task Get_Category()
        {
            var service = new CategoriesController2(_mockContext.Object);

            await service.GetCategory(1);

            _mockSet.Verify(m => m.FindAsync(1),
                Times.Once());
        }
    }
}
