// See https://aka.ms/new-console-template for more information
using Day14_LinkedList;

Console.WriteLine("Hello, World!");

LinkedLists linkedLists = new LinkedLists();

linkedLists.AppendNode(56);
linkedLists.AppendNode(30);
linkedLists.AppendNode(40);
linkedLists.AppendNode(70);
linkedLists.sort();
linkedLists.Display();