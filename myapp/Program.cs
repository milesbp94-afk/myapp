//Console.WriteLine("Hello, World!");
Person bob = new Person(1, "Bob");
//  Console.WriteLine(bob.ToString());
Person tom = new Person(2, "Tom");
Person hank = new Person(3, "Hank");
Person al = new Person(4, "Al");

// Console.WriteLine(tom.ToString());
Airplane B747 = new Airplane("Flight1");
B747.BoardPerson(bob);
B747.BoardPerson(tom);
B747.BoardPerson(hank);
B747.BoardPerson(al);
B747.PrintManifest();
