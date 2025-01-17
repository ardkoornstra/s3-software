using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.DTOs;
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
            this.mockRepository = new MockRepository(MockBehavior.Default);

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
            mockToetsenData.Setup(m => m.GetToets(1).Result).Returns(new ToetsDTO() { Id = 1, Name = "Ard", AantalVragen=5, AantalGoed=3, SessionId=1});
            var toetsenLogic = this.CreateToetsenLogic();
            int id = 1;

            // Act
            var result = await toetsenLogic.GetToets(
                id);

            // Assert
            Assert.Equivalent(result, new ToetsDTO() { Id = 1, Name = "Ard", AantalVragen = 5, AantalGoed = 3, SessionId = 1 });
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateToets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ToetsDTO toetsDTO = new ToetsDTO() { Id = 0, Name = "Ard", AantalVragen = 5, AantalGoed = 3, SessionId = 1 };
            mockToetsenData.Setup(m => m.CreateToets(toetsDTO).Result).Returns(1);
            mockVervoegingenLogic.Setup(m => m.CreateVervoegingen(5,1).Result).Returns(true);
            var toetsenLogic = this.CreateToetsenLogic();            

            // Act
            var result = await toetsenLogic.CreateToets(
                toetsDTO);

            // Assert
            Assert.Equivalent(result, 1);
            this.mockRepository.VerifyAll();
        }
    }
}
