using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory
{
    interface BagInterface
    {
         void addItem(PowerUps item);
         List<Inventory.PowerUps> viewItems();

    }
}
