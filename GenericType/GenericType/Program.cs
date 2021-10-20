using System;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 2

            //Alphabet a1 = new Alphabet("English");
            //a1[0] = 'A';
            //a1[1] = 'B';
            //Console.WriteLine(a1[0]);

            //a1.SetLetter(2, 'C');
            //Console.WriteLine(a1.GetLetter(2));

            #endregion

            #region Homework 3

            //string text = "Hello world! Bye P320 group";
            //foreach (var item in text.GetUpperWords())
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generic type

            //MyIntList myIntList = new MyIntList();
            //myIntList.AddItem(1);
            //myIntList.AddItem(2);
            //myIntList.AddItem(5);
            //myIntList.AddItem(8);
            //myIntList.ShowItems();

            //MyStringList myStringList = new MyStringList();
            //myStringList.AddItem("Emil");
            //myStringList.AddItem("Parviz");
            //myStringList.AddItem("Akif");
            //myStringList.AddItem("Orkhan");
            //myStringList.ShowItems();

            //MyPersonList myPersonList = new MyPersonList();
            //myPersonList.AddItem(new Person());
            //myPersonList.AddItem(new Person());
            //myPersonList.AddItem(new Person());
            //myPersonList.AddItem(new Person());
            //myPersonList.ShowItems();

            //MyList<int> intList = new MyList<int>();
            //intList.AddItem(1);
            //intList.AddItem(1);
            //intList.AddItem(1);
            //intList.AddItem(1);
            //intList.AddItem(1);
            //intList.ShowItems();

            //MyList<string> stringList = new MyList<string>();
            //stringList.AddItem("Alisimran");
            //stringList.AddItem("Idris");
            //stringList.AddItem("Aziz");
            //stringList.ShowItems();

            //MyList<Person> personList = new MyList<Person>();
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.AddItem(new Person());
            //personList.ShowItems();

            //MyList<string, string> myList = new MyList<string, string>();
            //MyList<string> myList = new MyList<string>();
            //MyList<Person> myList = new MyList<Person>();
            //MyList<int> myList = new MyList<int>();
            //MyList<Person, Test> myList = new MyList<Person, Test>();
            MyList<Person, int> myList = new MyList<Person, int>();

            #endregion

            //Mylist generic type yaradib, AddItem, ShowItem, RemoveItem, UpdateItem
            //methodlarini yazmaq.
        }
    }

    #region Generic type - wrong way

    class MyIntList
    {
        private int[] _items;

        public MyIntList()
        {
            _items = new int[0];
        }

        public void AddItem(int value)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = value;
        }

        public void ShowItems()
        {
            foreach (int item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyStringList
    {
        private string[] _items;

        public MyStringList()
        {
            _items = new string[0];
        }

        public void AddItem(string value)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = value;
        }

        public void ShowItems()
        {
            foreach (string item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Person : Test, IMove
    {
        public Person()
        {

        }
    }

    class MyPersonList
    {
        private Person[] _items;

        public MyPersonList()
        {
            _items = new Person[0];
        }

        public void AddItem(Person value)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = value;
        }

        public void ShowItems()
        {
            foreach (Person item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    #endregion

    #region Better way

    interface IMove
    {

    }

    class Test
    {

    }

    //class MyList<T, U>
    //class MyList<T> where T:class
    //class MyList<T> where T:class, new()
    //class MyList<T> where T:struct
    //class MyList<T> where T : IMove
    //class MyList<T, U> where T : U
    class MyList<T, U> where T : class where U : struct
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void AddItem(T value)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = value;
        }

        public void ShowItems()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }

    #endregion
}
