using Assignment4.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    class TShirt
    {
        //============================= Properties ===========================================================
        public Color color { get; }
        public Fabric fabric { get; }
        public Size size { get; }

        //============================= Constractor ===========================================================
        public TShirt(Color color, Fabric fabric, Size size)
        {
            this.color = color;
            this.fabric = fabric;
            this.size = size;
        }
    }
}
