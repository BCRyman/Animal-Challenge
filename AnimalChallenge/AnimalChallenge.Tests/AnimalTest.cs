using System;
using AnimalChallenge.Core;
using NUnit.Framework;

namespace AnimalChallenge.Tests
{
    [TestFixture]
    public class AnimalTest
    {
        [Test]
        public void Create_AnimalShouldBeAlive()
        {
            //Arrange
            var animal = new Dog("Dog");

            Assert.AreEqual(animal.Alive, true);
        }
        [Test]
        public void Sleep_EnergyShouldEqualAnimalSleepEnergy()
        {
            //Arrange
            var animal = new Dog("Animal");

            //Act
            animal.Sleep();

            //Assert
            Assert.AreEqual(animal.SleepEnergy, animal.Energy);
        }
        
        [Test]
        public void AlterEnergy_BelowZeroShouldEqualZero()
        {
            //Arrange
            var animal = new Dog("Animal");

            //Act
            animal.Energy = 10;
            animal.AlterEnergy(-11);

            //Assert
            Assert.AreEqual(animal.Energy, 0);
        }

        [Test]
        public void AlterEnergy_ZeroAndBelowAnimalIsDead()
        {
            //Arrange
            var animal = new Dog("Animal");

            //Act
            animal.Energy = 10;
            animal.AlterEnergy(-11);

            //Assert
            Assert.AreEqual(animal.Alive, false);
        }
    }

}
