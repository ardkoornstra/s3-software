using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LatijnTest.Services
{
    public class SessionsLogicTests
    {
        private MockRepository mockRepository;

        private Mock<ISessionsData> mockSessionsData;

        public SessionsLogicTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockSessionsData = this.mockRepository.Create<ISessionsData>();
        }

        private SessionsLogic CreateSessionsLogic()
        {
            return new SessionsLogic(
                this.mockSessionsData.Object);
        }

        [Fact]
        public async Task GetSession_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionsLogic = this.CreateSessionsLogic();
            int id = 0;

            // Act
            var result = await sessionsLogic.GetSession(
                id);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetSessionsByDocent_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionsLogic = this.CreateSessionsLogic();
            int docentId = 0;

            // Act
            var result = await sessionsLogic.GetSessionsByDocent(
                docentId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateSession_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sessionsLogic = this.CreateSessionsLogic();
            int docentId = 0;

            // Act
            var result = await sessionsLogic.CreateSession(
                docentId);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
