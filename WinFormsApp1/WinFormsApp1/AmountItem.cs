namespace WinFormsApp1

{

        public class AmountItem{
            
            private readonly Inventory _inventory;
            private int _amount { get; set; }


            public AmountItem(Inventory inventory, string PartID)
            {
                _inventory = inventory;

                foreach (var part in _inventory.AllParts)
                {
                    if (part.PartID == Convert.ToInt32(PartID))
                    {
                        _amount += 1;
                    }
                }
            }


            public string GetAmount()
            {   
                
                return Convert.ToString(_amount);
            }
        }
    }// Use this this is how we will always get Private variables
