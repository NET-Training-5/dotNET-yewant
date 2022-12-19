class Brand : IShop
{

    public float price {get; set;}
    public int quantity;

    public Brand(float p, int q)
    {
        price = p;
        quantity = q;

    }

       public int Quantity     //Full property definition
    {
        get
        {
            return quantity;
        }
        set
        {
            if (value > 0)
            {
                quantity = value;
            }
        }
    }

    public float GetTotalPrice() => price * quantity;
    public int GetQuantity() => quantity;
}