using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program : GarbageHelper
    {
        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Employee(string n, int a) {
                Age = a;
                Name = n;
            }
        }
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(2.3);
            //stack.Push(55);
            //stack.Push("Hello");
            //stack.Push("World");
            //stack.Push("!");

            //Console.WriteLine("stack.Count = " + stack.Count);
            //Console.WriteLine("stack.Contains(2.3) = " + stack.Contains(2.3));
            //Console.WriteLine("stack.Contains(11) = " + stack.Contains(11));
            //Console.WriteLine("stack.Peek() = " + stack.Peek());

            //Console.WriteLine();
            //foreach (object o in stack)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine();
            //int count = stack.Count;
            //for(int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Console.WriteLine();
            //Console.WriteLine("stack.Count = " + stack.Count);
            //Console.WriteLine();

            //Queue queue = new Queue();
            //queue.Enqueue(2.3);
            //queue.Enqueue(55);
            //queue.Enqueue("Hello");
            //queue.Enqueue("World");
            //queue.Enqueue("!");

            //Console.WriteLine("stack.Count = " + queue.Count);
            //Console.WriteLine("stack.Contains(2.3) = " + queue.Contains(2.3));
            //Console.WriteLine("stack.Contains(11) = " + queue.Contains(11));
            //Console.WriteLine("stack.Peek() = " + queue.Peek());

            //Console.WriteLine();
            //foreach (object o in queue)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine();
            //int countqu = queue.Count;
            //for (int i = 0; i < countqu; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Console.WriteLine();
            //Console.WriteLine("queue.Count = " + queue.Count);
            //Console.WriteLine();

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("001", 2.3);
            //hashtable["002"] = 55;
            //hashtable.Add("003", "Hello");
            //hashtable.Add("004", "World");
            //hashtable.Add(5, "!");

            //foreach(object key in hashtable.Keys) {
            //    Console.WriteLine(key + " : " + hashtable[key]);
            //}

            //Console.WriteLine($"Существует ли элемент \"004)\" : { hashtable.ContainsKey("004")}");
            //hashtable.Remove("004");
            //Console.WriteLine($"Существует ли элемент \"004)\" : {hashtable.ContainsKey("004")}");

            //hashtable["002"] = 66;
            //Console.WriteLine(hashtable["002"]);

            //try
            //{
            //    hashtable.Add("003", "Hello");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine();

            //SortedList sortedList = new SortedList();
            //sortedList["002"] = 55;
            //sortedList.Add("005", "!");
            //sortedList.Add("003", "Hello");
            //sortedList.Add("001", 2.3);
            //sortedList.Add("004", "world");

            //foreach (object key in sortedList.Keys)
            //{
            //    Console.WriteLine( key + " : " + sortedList[key]);
            //}
            //Console.WriteLine($"Существует ли элемент \"004)\" : {sortedList.ContainsKey("004")}");
            //Console.WriteLine("004");
            //Console.WriteLine($"Существует ли элемент \"004)\" : {sortedList.ContainsKey("004")}");

            //sortedList["002"] = 66;
            //Console.WriteLine(sortedList["002"]);

            //try
            //{
            //    sortedList.Add("003", "Hello");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine();

            ////GarbageHelper

            //Console.WriteLine($"Максимальное поколение: {GC.MaxGeneration}");
            //GarbageHelper hlp = new GarbageHelper();
            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            //Console.WriteLine("\nhlp.MakeGarbage()");
            //hlp.MakeGarbage();

            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");   
            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");

            //Console.WriteLine("\nGC.Collect(0)");
            //GC.Collect(0);

            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");

            //Console.WriteLine("\nGC.Collect(0)");
            //GC.Collect(0);

            //Console.WriteLine($"Занято памяти (байт): {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Поколение объекта: {GC.GetGeneration(hlp)}");

            //Console.WriteLine();

            //DisposeExample test1 = new DisposeExample();
            //test1.Dispose();
            //Console.WriteLine();

            //DisposeExample test2 = new DisposeExample();
            //test2.Dispose();
            //Console.WriteLine();

            //DisposeExample test3 = new DisposeExample();
            //try
            //{
            //    test3.DoSomething();
            //}
            //finally
            //{
            //    test3.Dispose();
            //}
            //Console.WriteLine();

            //using (DisposeExample test = new DisposeExample())
            //{
            //    test.DoSomething();
            //}

            //Console.WriteLine();

            //List<int> listInt = new List<int>();

            //Random random = new Random();
            //for(int i = 0; i < 10;  i++) 
            //    listInt.Add(random.Next(10));

            //listInt[0] = 11;
            //Console.WriteLine("listInt.Contains(5): "
            //    + listInt.Contains(5));

            //listInt.ForEach((int x) => Console.WriteLine($"{x} "));
            //Console.WriteLine("\n");

            //listInt.Remove(11);

            //foreach (int i in listInt)
            //{
            //    Console.WriteLine($"{i} ");
            //}
            //Console.Write("\n");
            //List<string> list = new List<string>(new string[]
            //{
            //    "John",
            //    "Jane",
            //    "Tom",
            //    "Bill",
            //    "jack",
            //    "Sam"
            //});

            //string str = "Test";
            //Console.WriteLine(str.StartsWith("T"));

            //list.Sort();

            //foreach (string s in list)
            //{
            //    if (s.StartsWith("J") || s.StartsWith("J")) 
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //Console.WriteLine();

            
            List<Employee> list = new List<Employee>(new Employee[]
           {
                new Employee("John", 21),
                new Employee("Jane", 32),
                new Employee("Tom", 18),
                new Employee("Bill", 19),
                new Employee("jack", 19),
                
           });

            var listJ = list.Where(e => e.Name.ToUpper().StartsWith("J"))
                .OrderBy(e => e.Age);
            foreach(var e in listJ)
            {
                Console.WriteLine(e.Name + " " + e.Age);
            }

           



            Console.ReadKey();
        }
    }
}
