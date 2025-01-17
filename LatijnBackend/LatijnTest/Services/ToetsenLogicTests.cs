using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class ToetsenLogicTests
    {
        private MockRepository mockRepository;

        private Mock<IToetsenData> mockToetsenData;
        private Mock<IVervoegingenLogic> mockVervoegingenLogic;

        public ToetsenLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockToetsenData = this.mockRepository.Create<IToetsenData>();
            this.mockVervoegingenLogic = this.mockRepository.Create<IVervoegingenLogic>();
        }

        private ToetsenLogic CreateToetsenLogic()
        {
            return new ToetsenLogic(
                this.mockToetsenData.Object,
                this.mockVervoegingenLogic.Object);
        }

        [Fact]
        public async Task GetToets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var toetsenLogic = this.CreateToetsenLogic();
            int id = 0;

            // Act
            var result = await toetsenLogic.GetToets(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateToets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var toetsenLogic = this.CreateToetsenLogic();
            ToetsDTO toetsDTO = null;

            // Act
            var result = await toetsenLogic.CreateToets(
                toetsDTO);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
