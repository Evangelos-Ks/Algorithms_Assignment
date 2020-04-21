using System.Collections.Generic;

namespace Assignment4.Entities.Enums
{
    class Colors
    {
        public static Dictionary<Color, decimal> Cost = new Dictionary<Color, decimal>()
        {
                { Color.Blue, 1m },
                { Color.Green, 1.6m },
                { Color.Indigo, 1.5m },
                { Color.Orange, 0.5m },
                { Color.Red, 1.7m },
                { Color.Violet, 2.1m },
                { Color.Yellow, 2m }
        };

    }

    public enum Color
    {
        Blue ,
        Green,
        Indigo,
        Orange,
        Red,
        Violet,
        Yellow
    }
}
