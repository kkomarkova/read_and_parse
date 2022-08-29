using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = false,
};
using var streamReader = File.OpenText("C:\\Users\\kater\\source\\repos\\Convertor\\Convertor\\people.csv");
using var csvReader = new CsvReader(streamReader, configuration);
string value;

while (csvReader.Read())
{
    for (int i = 0; csvReader.TryGetField<string>(i, out value); i++)
    {
        Console.Write($"{value} ");
    }

    Console.WriteLine();
}
public record struct Person(
    string name,
    int age,
    bool likesProgramming,
    string city
);
