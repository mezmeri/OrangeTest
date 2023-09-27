
namespace Tree
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                } else
                {
                    Console.WriteLine($"Umuligt du er {value}. Idiot.");
                }
            }
            get { return age; }
        }
        public int Height;
        public bool TreeAlive { get; set; }
        public int NumOranges { get; }
        public int OrangesEaten { get; }

        public void OneYearPasses()
        {
            // Add 1 year to age
            this.age = age + 1;

            // Every 1 year sets oranges eaten and number oranges 0 
            this.numOranges = 0;
            this.orangesEaten = 0;

            // Check if age is under 80, if yes add 2 to height
            // Every 1 year adds 5 oranges to production
            if (this.age < 80)
            {
                this.height = height + 2;
                this.numOranges = age * 5 - 5;
            }

            if (this.age < 80)
            {
                this.treeAlive = true;
            } else
            {
                this.treeAlive = false;
                this.numOranges = 0;
            }

        }

        public void EatOrange(int count)
        {
            if (this.numOranges >= count)
            {
                this.numOranges = numOranges - count;
                this.orangesEaten = orangesEaten + count;
            } else
            {
                this.numOranges = 0;
                this.orangesEaten = numOranges + orangesEaten;
            }
        }
    }
}
