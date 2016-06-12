using System.Collections.Generic;

namespace AnimalChallenge.Core
{
    public abstract class Animal
    {
        public int Energy { get; set; }

        public string Name{ get; set; }

        public bool Alive { get; set; }

        public int SleepEnergy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        protected Animal(string name)
        {
            if(name == null)
            {
                throw new System.ArgumentNullException(name,"Animal name is Null");
            }
            this.Name = name;
            this.Alive = true;
            this.Energy = 10;
            this.SleepEnergy = 10;
        }

        public abstract void Eat(Food f);

        public void Sleep()
        {
            this.Energy = SleepEnergy;
        }

        public void Die()
        {
            this.Alive = false;
        }

        public void AlterEnergy(int en)
        {
            this.Energy += en;
            if (this.Energy <= 0)
            {
                this.Energy = 0;
                Die();
            }
        }
    }

    
}
