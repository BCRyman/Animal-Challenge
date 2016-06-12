
public class Food : IFood
{
    public FoodType foodType;
}

public interface IFood
{
}

public enum FoodType
{
    Dog,
    Cat,
    Other
}

