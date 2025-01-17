using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.Types;
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
            Werkwoord werkwoord = new Werkwoord { WoordID = 29, Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            mockWerkwoordenData.Setup(m => m.GetAllWerkwoorden().Result).Returns(new List<Werkwoord>() { werkwoord } );

            // Act
            var result = await werkwoordenLogic.GetAllWerkwoorden();

            // Assert
            Assert.Equivalent(result, new List<Werkwoord>() { werkwoord});
            this.mockRepository.VerifyAll();
        }
    }
}
