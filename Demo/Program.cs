using System.Collections;

namespace Demo
{
    internal class Program
    {
        #region Non-Genaric Collection arraylist
        //public static int sumofarraylist(ArrayList list) {
        //    int sum = 0;
        //    if (list != null) { 
        //    for(int i=0;i< list.Count; i++)
        //        {
        //            sum += (int?)list[i] ?? 0; //casting from reference type to int [value type]
        //                                       // unboxing [unsave casting]
        //        }

        //                       }
        //    return sum;


        //} 
        #endregion

        #region Genaric Collection - list
        //public static int sumlist(List<int> list)
        //{
        //    int sum = 0;
        //    if (list?.Count>0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            sum += (int?)list[i] ?? 0; 

        //        }

        //    }
        //    return sum;


        //} 
        #endregion

        static void Main(string[] args)
        {

            #region Non-Genaric Collection arraylist

            //ArrayList numbers = new ArrayList();
            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.AddRange(new int[] { 3, 4 });

            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");
            //numbers.Add(5);
            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");
            //numbers.TrimToSize(); // free || delete|| release || unused bytes =12 bytes

            //Console.WriteLine("after triming ");

            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");



            //ArrayList numbers = new ArrayList(5) {1,2,3,4,5 };
            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");

            //if (numbers.Capacity < 21)
            //{
            //    numbers.Capacity = 21;
            //}
            //for(int i = 6; i <= 21; i++)
            //{
            //    numbers.Add(i);
            //}

            //Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");


            //ArrayList numbers = new ArrayList(5) ;

            //numbers.Add(1) ; //casting from int [value type ] to object [reference type]
            //numbers.Add(2);//casting from int [value type ] to object [reference type]
            //numbers.Add(3);//casting from int [value type ] to object [reference type]
            //numbers.Add(4);//casting from int [value type ] to object [reference type]
            //numbers.Add("hamada"); //compiler can not enforce type saftey
            //int result =sumofarraylist(numbers);
            //Console.WriteLine($"result = {result}");

            #endregion


            #region Genaric Collection - list

            //List<int> numbers = new List<int>();
            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");

            ////numbers.Add(1);
            ////numbers.Add(2);
            ////numbers.AddRange(new int[] { 3, 4 });

            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");
            ////numbers.Add(5);
            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");
            ////numbers.TrimExcess(); // free || delete|| release || unused bytes =12 bytes

            ////Console.WriteLine("after triming ");

            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");



            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");

            ////numbers.EnsureCapacity(21);
            ////for (int i = 6; i <= 21; i++)
            ////{
            ////    numbers.Add(i);
            ////}

            ////Console.WriteLine($"count is {numbers.Count}  : capacatiy {numbers.Capacity}");



            ////numbers.Add(1); 
            ////numbers.Add(2);
            ////numbers.Add(3);
            ////numbers.Add(4);
            ////numbers.Add("hamada"); //compiler can not enforce type saftey
            ////int result = sumlist(numbers);
            ////Console.WriteLine($"result = {result}"); 
            #endregion

            #region list methode
            //List<int> numbers= new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Insert(0, 3);
            //numbers.InsertRange(1,new int[] { 1, 2, 3 });


            //foreach (int i in numbers) {
            //    Console.WriteLine(i);
            //}

            //IReadOnlyList<int> numbers2= new List<int>();
            // numbers2[0] = 100;


            //numbers.AddRange([1, 2, 3, 4, 5]);

            //foreach (int i in numbers2)
            //{
            //    Console.WriteLine(i);
            //}




            //int index = numbers.BinarySearch(10); //-6

            //Console.WriteLine($"index ={index} ");

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(10,"ahmed",5_000),

            //                    new Employee(30,"omar",8_000),
            //    new Employee(10,"nadia",2_000)


            //};

            //employees.Sort(new EmployeeComparier());

            //int index = employees.BinarySearch(new Employee() {id=20});

            //index = employees.BinarySearch(new Employee() { name = "nadia" },new EmployeeComparier());

            //Console.WriteLine($"index is {index}"); //2

            //List<int> numbers= new List<int>(5) {1,2,3,4,5 };

            //List<long> numbers2 = numbers.ConvertAll< long>(x => x);

            //List<long> numbers3 = numbers.Select<int , long>(x => x).ToList();


            //foreach (long x in numbers2) {
            //    Console.WriteLine(x);
            //}


            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //int[] arr = new int[10];

            //numbers.CopyTo(arr);
            //foreach (int x in arr )
            //{
            //    Console.WriteLine(x);
            //}

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int evennumber = numbers.Find((x) => x % 2 == 0);
            //Console.WriteLine(evennumber);

            //int index = numbers.FindIndex(x=> x % 2 == 0);
            //Console.WriteLine($"index is {index}");

            //int evennumber2 = numbers.FindLast((x) => x % 2 == 0);
            //Console.WriteLine(evennumber2);

            //int[] evennumber3=numbers.FindAll(x=> x %2 == 0).ToArray();



            //            List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //            bool isExsist= numbers.Exists(x=>x%2==0);
            //            Console.WriteLine(isExsist);

            //            Console.WriteLine(numbers.TrueForAll(x=>x%2==0));

            //            numbers.ForEach(n =>
            //            {

            //                n += 100;
            //                Console.WriteLine(n);
            //            });




            //            List<int> numbers2 = new List<int>();
            //            numbers2=numbers.GetRange(0, 5);

            //            foreach(int x in numbers2)
            //            {
            //                Console.WriteLine(x);
            //            }



            //            Console.WriteLine(numbers.IndexOf(5));

            //            Console.WriteLine(numbers.IndexOf(5,2));
            //            Console.WriteLine(numbers.IndexOf(5,2,3));

            //            Console.WriteLine(numbers.LastIndexOf (5));

            //numbers.RemoveAll(x=>x%2==1);
            //            foreach (int x in numbers2)
            //            {
            //                Console.WriteLine(x);
            //            }


            #endregion

            #region Genaric Collection - linked List
            //LinkedList<int> numbers = new LinkedList<int>();

            //LinkedListNode<int> firstNode = numbers.AddFirst(1);
            //LinkedListNode<int> fourthnode = numbers.AddLast(2);

            //LinkedListNode<int> secondnode = numbers.AddAfter(firstNode,2);

            //LinkedListNode<int> thirdnode = numbers.AddBefore(fourthnode, 3);

            //Console.WriteLine(firstNode.Previous.Value); 
            #endregion


            #region Genaric Collection - stack

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.TryPop(out int valu1));
            //Console.WriteLine(stack.TryPop(out int valu2));
            //Console.WriteLine(stack.TryPop(out int valu3));

            //Console.WriteLine(stack.TryPeek(out int value));

            //Console.WriteLine(value);

            #endregion


            #region Genaric Collection - Queue

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.TryDequeue(out int valu1));
            //Console.WriteLine(queue.TryDequeue(out int valu2));
            //Console.WriteLine(queue.TryDequeue(out int valu3));

            //Console.WriteLine(valu1);
            //Console.WriteLine(valu2);
            //Console.WriteLine(valu3); 
            #endregion


        }
    }
}
