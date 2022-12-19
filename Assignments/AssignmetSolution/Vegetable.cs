//SN,Commodity,Date,Unit,Minimum,Maximum,Average

class Vegetable
{
    public int SN { get; set; }    
    public string Commodity { get; set; } = "";
    public DateOnly Date { get; set; }    
    public string Unit { get; set; } = "Kg";
    public float Minimum { get; set; }    
    public float Maximum { get; set; }    
    public float Average { get; set; }    
}