using Football;

namespace StringFootballTest
{
    [TestClass()]
    public class FootballPlayerTests
    {
        public FootballPlayer player = new FootballPlayer() { Id = 1, Name = "Arian", Age = 21, ShirtNumber = 7 };
        public FootballPlayer playerNull = new FootballPlayer() { Id = 2, Name = null, Age = 15, ShirtNumber = 5 };
        public FootballPlayer playerOneCharacter = new FootballPlayer() { Id = 3, Name = "B", Age = 18, ShirtNumber = 10 };
        public FootballPlayer playerAgeNegative = new FootballPlayer() { Id = 4, Name = "Morten", Age = -1, ShirtNumber = 12 };
        public FootballPlayer playerShirtNumberHigh = new FootballPlayer() { Id = 5, Name = "Nicklas", Age = 25, ShirtNumber = 101 };
        public FootballPlayer playerShirtNumberLow = new FootballPlayer() { Id = 6, Name = "Tim", Age = 26, ShirtNumber = -1 };


        [TestMethod()]
        public void ToStringTest()
        {
            string str = player.ToString(); //Act
            Assert.AreEqual("1 Arian 21 7", str); //Assert
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            player.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => playerNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => playerOneCharacter.ValidateName());
        }
        [TestMethod()]
        public void ValidateAgeTest()
        {
            player.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAgeNegative.ValidateAge());
        }
        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberHigh.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberLow.ValidateShirtNumber());
        }

        [TestMethod()]
        public void Validate()
        {
            player.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => playerNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => playerOneCharacter.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAgeNegative.ValidateAge());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberHigh.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberLow.ValidateShirtNumber());
        }
    }
}