using System;
using Moq;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CursoMVC.Models;
using CursoMVC.Controllers;

namespace CursoTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTest()
        {
        _mockSet = new Mock<DbSet<Categoria>>();
        _mockContext = new Mock<Context>();
        _categoria = new Categoria();

        _mockContext.Setup(m => m.Categoria).Returns(_mockSet.Object);
        _mockContext.Setup(m => m.Categoria.FindAsync(1)).ReturnsAsync(_categoria);
        _mockContext.Setup(m => m.Categoria.SetModified(_categoria));
        _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);

        

        }

        [Fact]
        public async Task Get_Categoria()
        {
        //Given
            var service = new CategoriasController(_mockContext.Object);
        //When
            await service.Get_Categoria(id:1);
        //Then
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}