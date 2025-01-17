using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.Types;
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
            Uitgang uitgang = new Uitgang { UitgangID = 1, Conjugatie = 1, Vorm = "o", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "eerste", Getal = "singularis", Stam = "praesens" };
            mockUitgangenData.Setup(m => m.GetAllUitgangen().Result).Returns(new List<Uitgang>() { uitgang });
            var uitgangenLogic = this.CreateUitgangenLogic();

            // Act
            var result = await uitgangenLogic.GetAllUitgangen();

            // Assert
            Assert.Equivalent(result, new List<Uitgang>() { uitgang });
            this.mockRepository.VerifyAll();
        }
    }
}
