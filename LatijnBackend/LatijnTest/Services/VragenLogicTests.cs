using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.DTOs;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class VragenLogicTests
    {
        private MockRepository mockRepository;

        private Mock<IVervoegingenData> mockVervoegingenData;

        public VragenLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockVervoegingenData = this.mockRepository.Create<IVervoegingenData>();
        }

        private VragenLogic CreateVragenLogic()
        {
            return new VragenLogic(
                this.mockVervoegingenData.Object);
        }

        [Fact]
        public async Task GetVragenByToetsID_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var vragenLogic = this.CreateVragenLogic();
            int toetsId = 0;

            // Act
            var result = await vragenLogic.GetVragenByToetsID(
                toetsId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task SubmitAntwoord_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var vragenLogic = this.CreateVragenLogic();
            AntwoordDTO antwoordDTO = null;

            // Act
            var result = await vragenLogic.SubmitAntwoord(
                antwoordDTO);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
