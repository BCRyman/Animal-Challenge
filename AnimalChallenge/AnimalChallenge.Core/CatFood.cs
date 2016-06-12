using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalChallenge.Core
{
    public class CatFood : Food
    {
        public FoodType foodType;
        public CatFood()
        {
            foodType = FoodType.Cat;
        }
    }
}
