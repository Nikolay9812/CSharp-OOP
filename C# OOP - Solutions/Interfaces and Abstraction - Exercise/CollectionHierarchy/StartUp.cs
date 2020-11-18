using System;
using System.Text;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputElements = Console.ReadLine().Split(' ');
            var removeTimes = int.Parse(Console.ReadLine());

            var addCollection = new AddCollection<string>();
            var addRemoveCollection = new AddRemoveCollection<string>();
            var myList = new MyList<string>();

            var addCollectionAdded = new StringBuilder();
            var addRemoveCollectionAdded = new StringBuilder();
            var myListAdded = new StringBuilder();
            var addRemoveCollectionRemoved = new StringBuilder();
            var myListRemoved = new StringBuilder();

            foreach (var inputElement in inputElements)
            {
                addCollectionAdded.Append($"{addCollection.Add(inputElement)} ");
                addRemoveCollectionAdded.Append($"{addRemoveCollection.Add(inputElement)} ");
                myListAdded.Append($"{myList.Add(inputElement)} ");
            }

            for (int i = 0; i < removeTimes; i++)
            {
                addRemoveCollectionRemoved.Append($"{addRemoveCollection.Remove()} ");
                myListRemoved.Append($"{myList.Remove()} ");
            }

            Console.WriteLine(addCollectionAdded);
            Console.WriteLine(addRemoveCollectionAdded);
            Console.WriteLine(myListAdded);
            Console.WriteLine(addRemoveCollectionRemoved);
            Console.WriteLine(myListRemoved);
        }
    }
}
