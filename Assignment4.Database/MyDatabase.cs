using Assignment4.Entities;
using Assignment4.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Database
{
    public class MyDatabase
    {
        //All the colors
        public List<Color> colors = new List<Color> { Color.Blue, Color.Green, Color.Indigo, Color.Orange, Color.Red, Color.Violet, Color.Yellow };

        //All the Fabrics
        public List<Fabric> fabrics = new List<Fabric> { Fabric.Cashmere, Fabric.Cotton, Fabric.Linel, Fabric.Polyester, Fabric.Rayon, Fabric.Silk, Fabric.Wool };

        //All the sizes
        public List<Size> sizes = new List<Size> { Size.XS, Size.S, Size.M, Size.L, Size.XL, Size.XXL, Size.XXXL };

        //All the shirts
        public List<TShirt> shirts = new List<TShirt>();
    }
}
