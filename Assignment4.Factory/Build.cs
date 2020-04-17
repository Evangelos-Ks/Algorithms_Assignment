using Assignment4.Database;
using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Factory
{
    class Build
    {
        public void GenerateAllCombinationsOfShirts()
        {
            MyDatabase db = new MyDatabase();

            for (int i = 0; i < db.colors.Count; i++)
            {
                for (int j = 0; j < db.fabrics.Count; j++)
                {
                    for (int k = 0; k < db.sizes.Count; k++)
                    {
                        TShirt ts = new TShirt(db.colors[i], db.fabrics[j], db.sizes[k]);
                        db.shirts.Add(ts);
                    }
                }
            }
        }

        
    }
}
