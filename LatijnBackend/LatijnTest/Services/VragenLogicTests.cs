using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.DTOs;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using LatijnLogic.Types;

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
            List<Vervoeging> vervoeging = new List<Vervoeging>() { new Vervoeging { Id = 1, ToetsId = 1, IsCorrect = false, Vorm = "abstinent", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" } };
            mockVervoegingenData.Setup(m => m.GetVervoegingenByToetsID(1).Result).Returns(vervoeging);
            var vragenLogic = this.CreateVragenLogic();
            int toetsId = 1;
            List<VraagDTO> vragen = new List<VraagDTO>() { new VraagDTO() {
                    Id = 1,
                    Vorm = "abstinent",
                    Infinitivus = "abstinere",
                    Praesens = "abstineo",
                    Perfectum = "abstinui",
                    Supinum = "abstentum",
                    Betekenis = "weghouden",
                }};

            // Act
            var result = await vragenLogic.GetVragenByToetsID(
                toetsId);

            // Assert
            Assert.Equivalent( result, vragen );
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task SubmitAntwoord_StateUnderTest_ExpectedBehaviorCorrect()
        {
            // Arrange
            Vervoeging vervoeging = new Vervoeging { ToetsId = 1, IsCorrect = false, Vorm = "abstinent", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            var vragenLogic = this.CreateVragenLogic();
            AntwoordDTO antwoordDTO = new AntwoordDTO { Id = 1, Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis" };
            mockVervoegingenData.Setup(m => m.GetVervoeging(1).Result).Returns(vervoeging);
            mockVervoegingenData.Setup(m => m.UpdateIsCorrect(1, true).Result).Returns(true);

            // Act
            var result = await vragenLogic.SubmitAntwoord(
                antwoordDTO);

            // Assert
            Assert.True(result);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task SubmitAntwoord_StateUnderTest_ExpectedBehaviorIncorrect()
        {
            // Arrange
            Vervoeging vervoeging = new Vervoeging { ToetsId = 1, IsCorrect = false, Vorm = "abstinent", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            var vragenLogic = this.CreateVragenLogic();
            AntwoordDTO antwoordDTO = new AntwoordDTO { Id = 1, Modus = "coniunctivus", Tempus = "perfectum", Genus = "passivum", Persoon = "eerste", Getal = "singularis" };
            mockVervoegingenData.Setup(m => m.GetVervoeging(1).Result).Returns(vervoeging);
            mockVervoegingenData.Setup(m => m.UpdateIsCorrect(1, false).Result).Returns(false);

            // Act
            var result = await vragenLogic.SubmitAntwoord(
                antwoordDTO);

            // Assert
            Assert.False(result);
            this.mockRepository.VerifyAll();
        }
    }
}
