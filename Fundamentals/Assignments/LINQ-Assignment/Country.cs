class Country
{
    string[] countries = {"Nepal", "India", "USA", "Bhutan", "New Zealand",
                        "Canada", "UK", "Nambia", "China", "Afganistan",
                        "South Korea", "Japan", "Croatia", "Netherlands", "Brazil",
                        "Argentina", "Switzerland", "Spain", "Germany", "Qatar"};

    public void GetAllCountries()
    {
        DisplayValues(countries, "List of all countries: \n");
    }

    public void GetCountriesStartingWithN()
    {
        var getCountries = from x in countries
                           where x.StartsWith("N")
                           select x;

        DisplayValues(getCountries, "List of countries which starts with letter N:\n");
    }

    public void GetCountriesLessOrEqualThan4()
    {
        var c = from x in countries
                where x.Length < 5
                select x;

        DisplayValues(c, "List of countries which length is 4 or less:\n");
    }

    public void GetCountriesToUpperCase()
    {
        var upper = countries.Select(x => x.ToUpper());

        DisplayValues(upper, "List of all Countries name after converting to uppercase:\n");
    }

    void DisplayValues<T>(IEnumerable<T> elements, string label)
    {
        Console.Write($"\n{label}");
        foreach (var x in elements)
        {
            Console.Write(x + ", ");
        }
        Console.WriteLine();

    }
}