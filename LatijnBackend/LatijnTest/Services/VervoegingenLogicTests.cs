using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.Types;
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
        public void AdjustConjugatie_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            Werkwoord werkwoord = new Werkwoord { WoordID = 29, Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            var vervoegingenLogic = this.CreateVervoegingenLogic();
            List<Werkwoord> werkwoorden = new List<Werkwoord>() { werkwoord };
            List<int> uitgangenIDs = new List<int>() { 6 };

            // Act
            var result = vervoegingenLogic.AdjustConjugatie(
                werkwoorden,
                uitgangenIDs);

            // Assert
            Assert.Equivalent(result, new List<int>() { 137 });
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void Vervoeg_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            Werkwoord werkwoord = new Werkwoord { WoordID = 29, Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            Uitgang uitgang = new Uitgang { UitgangID = 137, Conjugatie = 2, Vorm = "nt", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Stam = "praesens" };
            var vervoegingenLogic = this.CreateVervoegingenLogic();
            List<Werkwoord> werkwoorden = new List<Werkwoord>() { werkwoord };
            List<Uitgang> uitgangen = new List<Uitgang>() { uitgang };

            // Act
            var result = vervoegingenLogic.Vervoeg(
                werkwoorden,
                uitgangen);

            // Assert
            Assert.Equivalent(result, new List<string>() { "abstinent" }); 
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void CreateVervoegingenList_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string vorm = "abstinent";
            Uitgang uitgang = new Uitgang { UitgangID = 137, Conjugatie = 2, Vorm = "nt", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Stam = "praesens" };
            Werkwoord werkwoord = new Werkwoord { WoordID = 29, Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" };
            var vervoegingenLogic = this.CreateVervoegingenLogic();
            List<string> vormen = new List<string>() { vorm };
            List<Uitgang> uitgangen = new List<Uitgang>() { uitgang };
            List<Werkwoord> werkwoorden = new List<Werkwoord>() { werkwoord };
            int toetsId = 1;

            List<Vervoeging> vervoeging = new List<Vervoeging>() { new Vervoeging { ToetsId = toetsId, IsCorrect = false, Vorm = "abstinent", Modus = "indicativus", Tempus = "praesens", Genus = "activum", Persoon = "derde", Getal = "pluralis", Infinitivus = "abstinere", Praesens = "abstineo", Perfectum = "abstinui", Supinum = "abstentum", Conjugatie = 2, Betekenis = "weghouden" } };

            // Act
            var result = vervoegingenLogic.CreateVervoegingenList(
                vormen,
                uitgangen,
                werkwoorden,
                toetsId);

            // Assert
            Assert.Equivalent(result, vervoeging);
            this.mockRepository.VerifyAll();
        }
    }
}
