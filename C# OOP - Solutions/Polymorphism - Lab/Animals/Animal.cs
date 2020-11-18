namespace Animals
{
    public abstract class Animal
    {
        protected  Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favouriteFood;
        }

        public string Name { get; private set; }
        public string FavoriteFood { get; private set; }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
        }
    }
}
