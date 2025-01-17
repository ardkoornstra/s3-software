using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class UitgangenLogicTests
    {
        private MockRepository mockRepository;

        private Mock<IUitgangenData> mockUitgangenData;

        public UitgangenLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockUitgangenData = this.mockRepository.Create<IUitgangenData>();
        }

        private UitgangenLogic CreateUitgangenLogic()
        {
            return new UitgangenLogic(
                this.mockUitgangenData.Object);
        }

        [Fact]
        public async Task GetAllUitgangen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var uitgangenLogic = this.CreateUitgangenLogic();

            // Act
            var result = await uitgangenLogic.GetAllUitgangen();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
