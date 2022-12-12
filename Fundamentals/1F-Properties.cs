class Vehicle
{
    // KISS - Keep It Simple Stupid

    // Auto-implemented property
    public string Model { get; set; }
    public string Color { get; private set; } = "Red";
    public long serialNumber;

    string brand;
    public string Brand     //Full property definition
    {
        get
        {
            return brand;
        }
        set
        {
            if (value.Length > 2)
            {
                brand = value;
            }
        }
    }

    public void PrintDetails()
    {
        var details = $"Brand:{brand}, Model:{Model}, Color Code: {Color}, Serial Number: {serialNumber}";
        Console.WriteLine(details);
    }
}