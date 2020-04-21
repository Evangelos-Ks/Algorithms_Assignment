using System.Collections.Generic;

namespace Assignment4.Entities.Enums
{
    class Fabrics
    {
        public static Dictionary<Fabric, decimal> Cost = new Dictionary<Fabric, decimal>()
        {
                { Fabric.Cashmere, 15m },
                { Fabric.Cotton, 12m },
                { Fabric.Linel, 10m },
                { Fabric.Polyester, 10.5m },
                { Fabric.Rayon, 11m },
                { Fabric.Silk, 22m },
                { Fabric.Wool, 16m }
        };
    }

    public enum Fabric
    {
        Cashmere,
        Cotton,
        Linel,
        Polyester,
        Rayon,
        Silk,
        Wool
    }
}
