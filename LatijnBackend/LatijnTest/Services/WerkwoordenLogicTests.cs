using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class WerkwoordenLogicTests
    {
        private MockRepository mockRepository;

        private Mock<IWerkwoordenData> mockWerkwoordenData;

        public WerkwoordenLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockWerkwoordenData = this.mockRepository.Create<IWerkwoordenData>();
        }

        private WerkwoordenLogic CreateWerkwoordenLogic()
        {
            return new WerkwoordenLogic(
                this.mockWerkwoordenData.Object);
        }

        [Fact]
        public async Task GetAllWerkwoorden_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var werkwoordenLogic = this.CreateWerkwoordenLogic();

            // Act
            var result = await werkwoordenLogic.GetAllWerkwoorden();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
