//Console.WriteLine("Hello, World!");
Person bob = new Person(1, "Bob");
//  Console.WriteLine(bob.ToString());
Person tom = new Person(2, "Tom");
Person hank = new Person(3, "Hank");
Person al = new Person(4, "Al");
// Console.WriteLine(tom.ToString());
Airplane B757 = new Airplane("Flight1", 5, 100 );

B757.BoardPerson(bob);
B757.BoardPerson(tom);
B757.BoardPerson(hank);
B757.BoardPerson(al);
B757.PrintManifest();
