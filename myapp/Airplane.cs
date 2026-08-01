
/// <summary>
/// 
/// </summary>
public class Airplane
{
    public string Name { get; set; }
    public List<Person> Manifest = new List<Person>();
    public int MaxCapacity {get; set; }
    public int Fuel {get; set; }
    public Airplane(string name, int capacity, int fuel)
    {
        Name = name;
        MaxCapacity = capacity;
        Fuel = fuel; 
    }

    public void PrintManifest()
    {
        Console.WriteLine(this.Name + " " + Manifest.Count.ToString()+ " souls onboard" + this.Fuel.ToString() + " gallons");


        foreach(Person p in Manifest)
        {
            Console.WriteLine(p.ToString());
        }
    }
    public void BoardPerson(Person p) 
    {
        if(Manifest.Count >= MaxCapacity)
        {
            Console.WriteLine("Go Away");

        }
        else
        {
            Manifest.Add(p);
            }
    }
}
