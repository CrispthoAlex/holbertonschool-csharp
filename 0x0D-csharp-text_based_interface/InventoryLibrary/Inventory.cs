using System;

class Inventory : BaseClass
{
    public string user_id = User.id;
    public string item_id = Item.id;
    int quantity = 1;

    public Inventory(string user_id="", string item_id, int quantity=1)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        this.quantity = quantity;
    }
}
