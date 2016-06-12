using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalChallenge.Core
{
    public class DogFood : Food
    {
        public FoodType foodType;
        public DogFood()
        {
            foodType = FoodType.Dog;
        }
    }
}
