using ConsoleApp1;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
//using static SomeGroupOfObjects;

/*SomeGroupOfIntegers someGroupOfIntegers = new SomeGroupOfIntegers();
someGroupOfIntegers.Add(10);
someGroupOfIntegers.Add(20);
someGroupOfIntegers.Add(30);
someGroupOfIntegers.Add(40);

Console.WriteLine(someGroupOfIntegers.Get());
Console.WriteLine(someGroupOfIntegers.Get());
Console.WriteLine(someGroupOfIntegers.Get());
Console.WriteLine(someGroupOfIntegers.Get()); */

SomeGroupOfT<int> someInts = new SomeGroupOfT<int>();
someInts.Add(1);
someInts.Add(20);
someInts.Add(25);
SomeGroupOfT<Customer> someCusts = new SomeGroupOfT<Customer>();
someCusts.Add(new Customer() { FName = "Joe", LName = "Smith" });
someCusts.Add(new Customer() { FName = "Darla", LName = "Ellis" });

//someInts.Add(new Customer());

Console.WriteLine(someInts.Get());
Console.WriteLine(someInts.Get());
Console.WriteLine(someInts.Get());

Customer cust = someCusts.Get();
Console.WriteLine(cust.FName);
Console.WriteLine(cust.LName);

Customer cust1 = someCusts.Get();
Console.WriteLine(cust1.FName);
Console.WriteLine(cust1.LName);

namespace ConsoleApp1
{
    public class SomeGroupOfT <T>
    {
        private T[] _arrOfT;
        private int _positionToAdd;
        private int _positionToRead;
        public SomeGroupOfT()
        {
            _arrOfT = new T[50];
            _positionToAdd = 0;
            _positionToRead = 0;
        }
        public void Add(T x)
        {
            _arrOfT[_positionToAdd] = x;
            _positionToAdd++;
        }
        public T Get()
        {
            T result = _arrOfT[_positionToRead];
            _positionToRead++;
            return result;
        }
    }
    /*internal class SomeGroupOfIntegers
    {
        //static void Main(string[] args)
        //{
            //Console.WriteLine("Hello, World!");
        //}
        private int[] _arrOfInts;
        private int _positionToAdd;
        private int _positionToRead;

        // write ctor and press Tab 2 times for Constructor
        public SomeGroupOfIntegers()
        {
            _arrOfInts = new int[50];
            _positionToAdd = 0;
            _positionToRead = 0;
        }
        public void Add(int x)
        {
            _arrOfInts[_positionToAdd] = x;
            _positionToAdd++;
        }
        public int Get()
        {
            int result = _arrOfInts[_positionToRead];
            _positionToRead++;
            return result;
        }
    }*/


    /*SomeGroupOfObjects someObjects = new SomeGroupOfObjects();
    someObjects.Add(new Customer() { FName = "John", LName = "Smith" });
    someObjects.Add(new Customer() { FName = "John", LName = "Doe" });
    Customer cust = (Customer)someObjects.Get();

    Console.WriteLine(cust.FName);
    Console.WriteLine(cust.LName);

    Customer cust1 = (Customer)someObjects.Get();

    Console.WriteLine(cust1.FName);
    Console.WriteLine(cust1.LName);
    internal class  SomeGroupOfCustomers 
    {
        private Customer[] _arrOfCusts;
        private int _positionToAdd;
        private int _positionToRead;

        // write ctor and press Tab 2 times for Constructor
        public SomeGroupOfCustomers()
        {
            _arrOfCusts = new Customer[50];
            _positionToAdd = 0;
            _positionToRead = 0;
        }

        public void Add(Customer x)
        {
            _arrOfCusts[_positionToAdd] = x;
            _positionToAdd++;
        }
        public Customer Get()
        {
            Customer result = _arrOfCusts[_positionToRead];
            _positionToRead++;
            return result;
        }

    }*/

    /*SomeGroupOfObjects someObjects = new SomeGroupOfObjects();
    someObjects.Add(10);
    someObjects.Add(new Customer() { FName = "John", LName = "Smith" });
    someObjects.Add(new Customer() { FName = "John", LName = "Doe" });
    someObjects.Add(40);

    //Console.WriteLine(someObjects.Get());
    //Console.WriteLine(someObjects.Get());
    //Console.WriteLine(someObjects.Get());

    Customer customer = (Customer)someObjects.Get();
    Console.WriteLine(customer.FName);
    Console.WriteLine(customer.LName);

    Customer customer1 = (Customer)someObjects.Get();
    Console.WriteLine(customer1.FName);
    Console.WriteLine(customer1.LName);
    Console.WriteLine(someObjects.Get());
    internal class SomeGroupOfObjects
    {
        private object[] _arrOfObjects;
        private int _positionToAdd;
        private int _positionToRead;

        // write ctor and press Tab 2 times for Constructor
        public SomeGroupOfObjects()
        {
            _arrOfObjects = new object[50];
            _positionToAdd = 0;
            _positionToRead = 0;
        }

        public void Add(object x)
        {
            _arrOfObjects[_positionToAdd] = x;
            _positionToAdd++;
        }
        public object Get()
        {
            object result = _arrOfObjects[_positionToRead];
            _positionToRead++;
            return result;
        }
    }*/
    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
    }
    public class Calculator<T> where T : Customer
    {
        public T Add (T one, T two)
        {
            return one + two;
        }
        public string GetLastName(T cust)
        {
            return cust.LName;
        }
    }
}