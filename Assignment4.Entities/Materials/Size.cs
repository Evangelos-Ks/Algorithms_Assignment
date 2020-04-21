using System.Collections.Generic;

namespace Assignment4.Entities.Enums
{
    class Sizes
    {
        public static Dictionary<Size, decimal> Cost = new Dictionary<Size, decimal>()
        {
                { Size.XS, 7m },
                { Size.S, 7.5m },
                { Size.M, 8m },
                { Size.L, 8.5m },
                { Size.XL, 9m },
                { Size.XXL, 10m },
                { Size.XXXL, 11m }
        };
    }
    public enum Size
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL,
        XXXL
    }
}
