using CollabProject;

List<Person> classmates = new List<Person>()
{
    new Person("Christopher Washington", 23),
    new Person("Allison Jones", 33),
    new Person("Jason Garrison", 49),

};

foreach (Person L in classmates)
{
    Console.WriteLine($"{L.Name}: {L.Age}");
}