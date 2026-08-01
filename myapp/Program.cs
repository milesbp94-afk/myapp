//Console.WriteLine("Hello, World!");
Person bob = new Person(1, "Bob");
//  Console.WriteLine(bob.ToString());
Person tom = new Person(2, "Tom");
// Console.WriteLine(tom.ToString());
Airplane B747 = new Airplane("Flight1");
B747.BoardPerson(bob);
B747.BoardPerson(tom);
B747.PrintManifest();
