public class Person
{
    public int Ticket { get; set; }
    public string Name { get; set; }
    public Person(int ticket, string name)
    {
        Ticket = ticket;
        Name = name;
    }
    public string ToString()
    {
        return $"Ticket: {Ticket}, Name: {Name}";
    }
}
