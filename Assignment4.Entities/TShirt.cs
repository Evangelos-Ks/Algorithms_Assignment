using Assignment4.Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Entities
{
    public class TShirt
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

        //============================= Methods ===============================================================
       public void Output(List<TShirt> shirts)
        {
            foreach (var shirt in shirts)
            {
                Console.WriteLine("\t{0, -15}{1,-15}{2,-15}",shirt.color,shirt.fabric, shirt.size);
            }
        }
    }
}
