using System;
using System.Collections.Generic;

namespace MyHashTable
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }

        public Item(int key )
        {
            Key = key;
            Nodes = new List<T>();
        }
    }
    internal class HashTable<T>
    {
        private Item<T>[] items;

        public HashTable(int size)
        {
            items = new Item<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }

        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
