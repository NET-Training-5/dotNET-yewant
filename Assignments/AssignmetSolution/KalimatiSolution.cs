using System;
using System.IO;

class KalimatiSolution
{
    List<Vegetable> vegetables = new List<Vegetable>();

    // File - parse
    public void ParseCsv()
    {
        var filePath = @"..\Data\Kalimati.csv";
        var csvLines = File.ReadAllLines(filePath);

        foreach (var row in csvLines.Skip(1))
        {
            var rowData = row.Split(",");
            var vegetable = new Vegetable()
            {
                SN = int.Parse(rowData[0]),
                Commodity = rowData[1],
                Date = DateOnly.Parse(rowData[2]),
                Unit = rowData[3],
                Minimum = float.Parse(rowData[4]),
                Maximum = float.Parse(rowData[5]),
                Average = float.Parse(rowData[6])               
            };
            vegetables.Add(vegetable);
        }        
    }

    public void Queries()
    {
        var file1Path = @"..\Data\Query1.csv";
        var file2Path = @"..\Data\Query2.csv";

        var sastoTarkariharu = vegetables.Where(x => x.Average < 10);
        var sastoTarkariharuStringified = sastoTarkariharu.Select(x => $"{x.SN}, {x.Commodity}");
        File.WriteAllLines(file1Path, sastoTarkariharuStringified);

        var tardedOn2013 =vegetables.Where(x => x.Date == new DateOnly(2013, 6, 17) && x.Minimum < 40);
        var tardedOn2013Stringified = tardedOn2013.Select(x => $"{x.SN}, {x.Commodity}");
        File.WriteAllLines(file2Path, tardedOn2013Stringified);
    }
}
