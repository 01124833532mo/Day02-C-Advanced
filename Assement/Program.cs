using System.Collections;

namespace Assement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X


            //string[] nums = Console.ReadLine().Split(' ');
            //int arraySize = int.Parse(nums[0]);
            //int numberOfQueries = int.Parse(nums[1]);

            //string[] arrayElements = Console.ReadLine().Split(' ');
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < arraySize; i++)
            //{
            //    numbers.Add(int.Parse(arrayElements[i]));
            //}

            //for (int i = 0; i < numberOfQueries; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int count = 0;
            //    foreach (int number in numbers)
            //    {
            //        if (number > X)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}

            #endregion

            #region  Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //int num = int.Parse(Console.ReadLine());

            //string[] numbers = Console.ReadLine().Split(" ");

            //List<int> list = new List<int>();

            //for(int i=0; i<num; i++)
            //{
            //    list.Add(int.Parse(numbers[i]));
            //}
            //int left = 0 , right = list.Count-1 ;
            //bool flag= false;


            //while (left < right) {

            //    if (list[left ] == list[right])
            //    {
            //        flag = true;
            //    }
            //    else
            //    {
            //        flag= false;
            //        break;
            //    }
            //    left++;
            //    right--;


            //}
            //if (flag) {
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //} 
            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> basequeue = new Queue<int>();
            //basequeue.Enqueue(1);
            //basequeue.Enqueue(2);
            //basequeue.Enqueue(3);
            //basequeue.Enqueue(4);
            ////revers(basequeue);


            #endregion


            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string numbers = Console.ReadLine();

            //char[] chars = numbers.ToCharArray();

            //Stack<char> stack = new Stack<char>();

            //for(int i = 0; i < chars.Length; i++)
            //{
            //    if (stack.Count == 0)
            //    {
            //        stack.Push(chars[i]);
            //    }
            //    else
            //    {
            //        if (stack.Peek() == '(' && chars[i]==')') {
            //            stack.Pop();
            //        }
            //        else if(stack.Peek() == '[' && chars[i] == ']')
            //        {
            //            stack.Pop();
            //        }
            //        else if (stack.Peek() == '{' && chars[i] == '}')
            //        {
            //            stack.Pop();
            //        }
            //        else
            //        {
            //            stack.Push((char)chars[i]);
            //        }

            //    }


            //}
            //if(stack.Count == 0) Console.WriteLine("Balanced");
            //else
            //{
            //    Console.WriteLine("NONBalanced");
            //} 
            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            //List<int> array = new List<int>{ 1, 2, 2, 3, 4, 4, 5 };
            // List<int> removed = RemoveDuplicat(array);

            // Console.WriteLine("array with duplicates removed");
            // foreach (int item in removed)
            // {
            //     Console.Write(item + " ");
            // } 
            #endregion


            #region 6. Given an array list , implement a function to remove all odd numbers from it.


            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };

            //List<int> removed = chikeoddNumber(list);

            //Console.WriteLine("array after removed odd numbers");
            //foreach (int item in removed)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

            #region 7. Implement a queue that can hold different data types. 
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).


            //            int target = int.Parse(Console.ReadLine());

            //CheckTarget(target);

            #endregion

            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //string[] nums = Console.ReadLine().Split(',');
            //int num1=int.Parse(nums[0]);
            //int num2=int.Parse(nums[1]);

            //Console.WriteLine("Enter elements of the first array");
            //string[] arr1 = Console.ReadLine().Split(",");

            //List<int> list1= new List<int>();
            //for(int i = 0; i < num1; i++)
            //{
            //    list1.Add(int.Parse(arr1[i]));
            //}
            //Console.WriteLine("Enter elements of the second array");
            //string[] arr2 = Console.ReadLine().Split(",");

            //List<int> list2 = new List<int>();
            //for (int i = 0; i < num2; i++)
            //{
            //    list2.Add(int.Parse(arr2[i]));
            //}


            //list1.Sort();
            //list2.Sort();


            //List<int> result = new List<int>();

            //int left = 0, right = 0;
            //while (left < list1.Count && right < list2.Count)
            //{
            //    if (list1[left] < list2[right])
            //    {
            //        left++;
            //    }
            //    else if (list1[left] > list2[right])
            //    {
            //        right++;
            //    }
            //    else
            //    {
            //        result.Add(list1[left]);
            //        left++;
            //        right++;
            //    }
            //}

            //Console.WriteLine(" [" + string.Join(", ", result) + "]"); 
            #endregion

            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //string[] arr1 = Console.ReadLine().Split(",");

            //List<int> nums = new List<int>();
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    nums.Add(int.Parse(arr1[i]));
            //}

            //int target = int.Parse(Console.ReadLine());
            //int left = 0;
            //int sum = 0;
            //int right = 0;
            //bool found = false;

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    sum += nums[right];

            //    while (sum > target)
            //    {
            //        sum -= nums[left];
            //        left++;
            //    }
            //    if (sum == target)
            //    {
            //        Console.Write("[");
            //        for (int j = left; j <= right; j++)
            //        {
            //            Console.Write(nums[j]);
            //            if (j < right) Console.Write(", ");
            //        }
            //        Console.WriteLine("]");
            //        break;
            //    }
            //    right++;
            //}
            //if (!found)
            //{
            //    Console.WriteLine("No sublist found with the target sum");
            //}
            #endregion

            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            //     string[] nums = Console.ReadLine().Split(",");

            //     int k = int.Parse(Console.ReadLine());
            //Queue<int> queue1= new Queue<int>();

            //     for(int i=0;i<nums.Length; i++)
            //     {
            //         queue1.Enqueue(int.Parse(nums[i]));
            //     }


            //     Stack<int> stack= new Stack<int>();

            //     for(int i = 0; i < k; i++)
            //     {
            //         stack.Push(queue1.Dequeue());
            //     }

            //     Queue<int> queue2 = new Queue<int>();

            //    for(int i = 0; i < k; i++)
            //     {
            //         queue2.Enqueue(stack.Pop());
            //     }

            //    for(int i = 0; i <= queue1.Count; i++)
            //     {
            //         queue2.Enqueue(queue1.Dequeue());
            //     }

            //    foreach(int i in queue2)
            //     {
            //         Console.Write(i + " ");
            //     }
            #endregion
        }

        #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
        //static void CheckTarget(int target)
        //{
        //    int count = 0;
        //    bool flag= false;
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(1);
        //    stack.Push(2);
        //        stack.Push(3);
        //    stack.Push(4);
        //    stack.Push(5);

        //    foreach (int element in stack) {
        //        if (element == target) {
        //            flag = true;
        //            break;

        //                }
        //        else
        //        {
        //            flag= false;
        //            count++;

        //        }
        //    }

        //    if (flag) {
        //        Console.WriteLine($"Target was found successfully and the count = {count}");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Target was not found");
        //    }

        //} 
        #endregion

        #region 6. Given an array list , implement a function to remove all odd numbers from it.
        //static List<int> chikeoddNumber(List<int> arr) 
        //{

        //    arr.RemoveAll(x => x %2 !=0 );

        //    return arr.ToList();

        //}

        #endregion

        #region 5. Given an array, implement a function to remove duplicate elements from an array.
        //static List<int> RemoveDuplicat(List<int> arr)
        //{
        //    List<int> list = new List<int>();

        //    foreach (int item in arr)
        //    {
        //        if (!list.Contains(item))
        //        {
        //            list.Add(item);
        //        }
        //    }

        //    return list.ToList();
        //} 
        #endregion

        #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
        //static void revers(Queue<int> que)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    while (que.Count > 0)
        //    {
        //        stack.Push(que.Dequeue());
        //    }


        //    foreach (int i in stack)
        //    {

        //        Console.Write(i + " ");
        //    }

        //}
        #endregion



    }
}
