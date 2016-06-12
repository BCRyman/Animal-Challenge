using System;
using AnimalChallenge.Core;
using NUnit.Framework;

namespace AnimalChallenge.Tests.Unit
{
    [TestFixture]
    public class DogTest
    {
        [Test]
        public void Create_WithName_ShouldSetTheName()
        {
            //Arrange
            const string name = "Doggy McDog";

            //Act
            var dog = new Dog(name);

            //Assert
            Assert.AreEqual(name, dog.Name);
        }

        [Test]
        public void Create_NoNameShouldThrowNullArgumentException()
        {
            //Arrange
            const string name = null;

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => new Dog(name));

            //Assert
            StringAssert.Contains("name", exception.Message);
        }

        [Test]
        public void Speak_ShouldReturnWhatDogSays()
        {
            //Arrange
            var dog = new Dog("Doggy McDog");

            //Act
            var speech = dog.Speak();

            //Assert
            Assert.AreEqual("Woof", speech);
        }

        [Test]
        public void Walk_ShouldReduceEnergyByWalkValue()
        {
            //Arrange
            var dog = new Dog("Doggy");
            var currentEnergy = dog.Energy;


            //Act
            dog.Walk();
            currentEnergy += dog.walkAmount;
            //Assert
            Assert.AreEqual(currentEnergy, dog.Energy);
        }

        [Test]
        public void Run_ShouldReduceEnergyByRunValue()
        {
            //Arrange
            var dog = new Dog("Doggy");
            var currentEnergy = dog.Energy;

            //Act
            dog.Run();
            currentEnergy += dog.runAmount;

            //Assert
            Assert.AreEqual(currentEnergy, dog.Energy);
        }


        [Test]
        public void Eat_DogFoodShouldIncreaseEnegy()
        {
            //Arrange
            var dog = new Dog("Doggy");

            //Act
            var currentEnergy = dog.Energy;
            var dogFood = new DogFood();
            dog.Eat(dogFood);

            //Assert
            Assert.Greater(dog.Energy, currentEnergy);

        }
        
        [Test]
        public void Eat_NotDogFoodShouldDecreaseEnergy()
        {
            //Arrange
            var dog = new Dog("Doggy");
            
            //Act
            var currentEnergy = dog.Energy;
            var catFood = new CatFood();
            dog.Eat(catFood);

            //Assert
            Assert.Greater(dog.Energy, currentEnergy);
        }

        [Test]
        public void Play_ShouldDecreaseEnergyByPlayAmount()
        {
            //Arrange
            var dog = new Dog("Doggy");
            var currentEnergy = dog.Energy;
            var playAmount = dog.playAmount;

            //Act
            currentEnergy += playAmount;
            dog.Play();

            //Assert
            Assert.AreEqual(currentEnergy, dog.Energy);
        }
    }
}
