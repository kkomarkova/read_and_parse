using System.Text.Json;

var incoming = new List<Person>();

using (StreamReader r = new StreamReader("C:\\Users\\kater\\source\\repos\\Convertor\\Convertor\\me.json"))
{
    string json = r.ReadToEnd();
    incoming = JsonSerializer.Deserialize<List<Person>>(json);
}

if (incoming != null && incoming.Count > 0)
{
    foreach (var customer in incoming)
    {
        Console.WriteLine($"{customer.name} {customer.age}");
    }
    Console.WriteLine("There are {0} total records", incoming.Count);
}
public record struct Person(
    string name,
    int age,
    bool likesProgramming,
    string city
);
