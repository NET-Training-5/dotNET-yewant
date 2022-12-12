/* Think of a real world class with following:
    1. Two fields
    1. Two properties: one autoimplemented, one write-only
    1. A method which prints details of objects of that class */

class Doctor
{
    public string Name {get; set; }
     public long phone;
    string address;
    public string Address
    {
        get
        {
            return address;
        }
        set 
        {
            if (value.Length > 4)
            {
                address = value;
            }

        }
    }

    public void DoctorDetails()
    {
        var detail = $"Name: {Name}, Phone: {phone}, Address: {address}";
        Console.WriteLine(detail);
    }


}
