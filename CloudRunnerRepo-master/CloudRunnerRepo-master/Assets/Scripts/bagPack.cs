using System;
using System.Collections.Generic;
using System.Linq;



namespace Inventory
{
    public class bagPack<PowerUps> : BagInterface
    {
        private List<Inventory.PowerUps> bag;



        public bagPack()
        {
            bag = new List<Inventory.PowerUps>();
        }





       public  void addItem(Inventory.PowerUps item)
        {
            if (bag.Contains(item))
            {
                // update item internal
               bag.ElementAt(bag.IndexOf(item)).updateItem();
            }
            else
            {
                bag.Add(item);
            }
        }                

        public List<Inventory.PowerUps> viewItems()
        {
            return bag.ToList();
        }
    }

}
