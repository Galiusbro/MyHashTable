using System;

namespace MyHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new HashTable<Person>(100);
            var person = new Person() { Name = "Santa", Age = 18, Gender = 3 };
            HashTable.Add(new Person() { Name = "Bob", Age = 18, Gender = 0 });
            HashTable.Add(new Person() { Name = "Elly", Age = 19, Gender = 1 });
            HashTable.Add(new Person() { Name = "Kate", Age = 18, Gender = 2 });
            HashTable.Add(person);

            Console.WriteLine(HashTable.Search(person));
            Console.WriteLine(HashTable.Search(new Person() { Name = "Santa", Age = 18, Gender = 3 }));

            Console.WriteLine();
        }
    }
}
