
/// <summary>
/// 
/// </summary>
public class Airplane
{
    public string Name { get; set; }
    public List<Person> Manifest = new List<Person>();
    public Airplane(string name)
    {
        Name = name;
    }

    public void PrintManifest()
    {
        Console.WriteLine(this.Name + " " + Manifest.Count.ToString()+ " souls onboard");


        foreach(Person p in Manifest)
        {
            Console.WriteLine(p.ToString());
        }
    }
    public void BoardPerson(Person p) 
    {
        if(Manifest.Count >= 3)
        {
            Console.WriteLine("Go Away");

        }
        else
        {
            Manifest.Add(p);
            }
    }
}
