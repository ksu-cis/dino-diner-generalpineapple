using System;


namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool onion = true;
        private bool mayo = true;


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Three Steakburger Pattie" };
                if (bun) ingredients.add("Whole Wheat Bun");
                if (pickle) ingredients.add("Pickle");
                if (ketchup) ingredients.add("Ketchup");
                if (mustard) ingredients.add("Mustard");
                if (lettuce) ingredients.add("Lettuce");
                if (onion) ingredients.add("Onion");
                if (mayo) ingredients.add("Mayo");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void Holdlettuce()
        {
            this.lettuce = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}