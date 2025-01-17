using LatijnLogic.Interfaces;
using LatijnLogic.Services;
using LatijnLogic.Types;
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
            mockSessionsData.Setup(m => m.GetSession(1).Result).Returns(new Session() { Id = 1, DocentId = 1 });
            var sessionsLogic = this.CreateSessionsLogic();
            int id = 1;

            // Act
            var result = await sessionsLogic.GetSession(
                id);

            // Assert
            Assert.Equivalent(result, new Session() { Id = 1, DocentId = 1 });
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetSessionsByDocent_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockSessionsData.Setup(m => m.GetSessionsByDocent(1).Result).Returns(new List<Session> { new Session() { Id = 1, DocentId = 1 }, new Session() { Id = 2, DocentId = 1 } });
            var sessionsLogic = this.CreateSessionsLogic();
            int docentId = 1;

            // Act
            var result = await sessionsLogic.GetSessionsByDocent(
                docentId);

            // Assert
            Assert.Equivalent(result, new List<Session> { new Session() { Id = 1, DocentId = 1 }, new Session() { Id = 2, DocentId = 1 } });
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateSession_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            mockSessionsData.Setup(m => m.CreateSession(1).Result).Returns(3);
            var sessionsLogic = this.CreateSessionsLogic();
            int docentId = 1;

            // Act
            var result = await sessionsLogic.CreateSession(
                docentId);

            // Assert
            Assert.Equivalent(result, 3);
            this.mockRepository.VerifyAll();
        }
    }
}
