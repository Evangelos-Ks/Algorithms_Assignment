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

        //============================= Constractors ===========================================================
        public TShirt() { }
        public TShirt(Color color, Fabric fabric, Size size)
        {
            this.color = color;
            this.fabric = fabric;
            this.size = size;
        }

        //============================= Methods ===============================================================
       public void Output(List<TShirt> shirts)
        {
            int count = 1;

            foreach (var shirt in shirts)
            {
                Console.Write("\t");
                Console.WriteLine("{0, -15}{1, -15}{2,-15}{3,-15}", count++,  shirt.color,shirt.fabric, shirt.size);
            }
        }
    }
}
