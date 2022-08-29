using System.Xml;

using (XmlReader reader = XmlReader.Create(@"C:\Users\kater\source\repos\Convertor\Convertor\people.xml"))
{
    while (reader.Read())
    {
        if (reader.IsStartElement())
        {
            switch (reader.Name.ToString())
            {
                case "name":
                    Console.WriteLine("The name of the person is :"+ reader.ReadString());
                    break;

                case "likesProgramming":
                    Console.WriteLine("The person likes to do programming :"+ reader.ReadElementContentAsBoolean());
                    break;
            }
        }
        Console.WriteLine("");
    }

    Console.ReadKey();
}
