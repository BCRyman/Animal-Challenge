using System;

namespace AnimalChallenge.Core
{
    public class Dog : Animal, IRunner, IWalker, ISpeakable, IPlayable
    {
        public Dog(string n) : base(n)
        {
        }

        string speech = "Woof";
        public int walkAmount = -2, runAmount = -3, playAmount = -4;

        public string Speak()
        {
            return speech;
        }

        public void Walk()
        {
            AlterEnergy(walkAmount);
        }

        public void Run()
        {
            AlterEnergy(runAmount);
        }

        public override void Eat(Food food)
        {
            if (food.foodType == FoodType.Dog)
            {
                AlterEnergy(3);
            }
            else
            {
                AlterEnergy(-4);
            }
        }

        public void Play()
        {
            AlterEnergy(playAmount);
        }
    }
}
