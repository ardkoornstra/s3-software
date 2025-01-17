using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class VervoegingenLogicTests
    {
        private MockRepository mockRepository;

        private Mock<IUitgangenData> mockUitgangenData;
        private Mock<IWerkwoordenData> mockWerkwoordenData;
        private Mock<IRandomNumbers> mockRandomNumbers;
        private Mock<IVervoegingenData> mockVervoegingenData;

        public VervoegingenLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockUitgangenData = this.mockRepository.Create<IUitgangenData>();
            this.mockWerkwoordenData = this.mockRepository.Create<IWerkwoordenData>();
            this.mockRandomNumbers = this.mockRepository.Create<IRandomNumbers>();
            this.mockVervoegingenData = this.mockRepository.Create<IVervoegingenData>();
        }

        private VervoegingenLogic CreateVervoegingenLogic()
        {
            return new VervoegingenLogic(
                this.mockUitgangenData.Object,
                this.mockWerkwoordenData.Object,
                this.mockRandomNumbers.Object,
                this.mockVervoegingenData.Object);
        }

        [Fact]
        public async Task CreateVervoegingen_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var vervoegingenLogic = this.CreateVervoegingenLogic();
            int amount = 0;
            int toetsId = 0;

            // Act
            var result = await vervoegingenLogic.CreateVervoegingen(
                amount,
                toetsId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
