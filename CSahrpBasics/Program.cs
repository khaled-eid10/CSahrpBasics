using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace CSahrpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //string[] arrayInput = Console.ReadLine().Split(' ');
            //bool isPalindrome = true;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arrayInput[i] != arrayInput[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isPalindrome ? "YES" : "NO"); 
            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Original Queue:");
            //PrintQueue(queue);

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue:");
            //PrintQueue(queue);
            //static void ReverseQueue(Queue<int> queue)
            //{
            //    Stack<int> stack = new Stack<int>();

            //    // Dequeue all elements from the queue and push them onto the stack
            //    while (queue.Count > 0)
            //    {
            //        stack.Push(queue.Dequeue());
            //    }

            //    // Pop all elements from the stack and enqueue them back to the queue
            //    while (stack.Count > 0)
            //    {
            //        queue.Enqueue(stack.Pop());
            //    }
            //}
            //static void PrintQueue(Queue<int> queue)
            //{
            //    foreach (int item in queue)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //string input = Console.ReadLine();
            //Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");
            //static bool IsBalanced(string input)
            //{
            //    Stack<char> stack = new Stack<char>();

            //    foreach (char c in input)
            //    {
            //        if (c == '(' || c == '{' || c == '[')
            //        {
            //            stack.Push(c);
            //        }
            //        else if (c == ')' || c == '}' || c == ']')
            //        {
            //            if (stack.Count == 0)
            //            {
            //                return false;
            //            }

            //            char top = stack.Pop();
            //            if ((c == ')' && top != '(') ||
            //                (c == '}' && top != '{') ||
            //                (c == ']' && top != '['))
            //            {
            //                return false;
            //            }
            //        }
            //    }

            //    return stack.Count == 0;
            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.
            //int[] array = { 1, 2, 2, 3, 4, 4, 5 };

            //int[] uniqueArray = RemoveDuplicates(array);

            //Console.WriteLine("Array after removing duplicates:");
            //foreach (int item in uniqueArray)
            //{
            //    Console.Write(item + " ");
            //}

            //static int[] RemoveDuplicates(int[] array)
            //{
            //    HashSet<int> set = new HashSet<int>();
            //    foreach (int item in array)
            //    {
            //        set.Add(item);
            //    }

            //    int[] result = new int[set.Count];
            //    set.CopyTo(result);

            //    return result;
            //}
            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.
            //    ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    RemoveOddNumbers(arrayList);
            //    Console.WriteLine();
            //    Console.WriteLine("ArrayList after removing odd numbers:");
            //    foreach (int item in arrayList)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //static void RemoveOddNumbers(ArrayList arrayList)
            //{
            //    for (int i = arrayList.Count - 1; i >= 0; i--)
            //    {
            //        if ((int)arrayList[i] % 2 != 0)
            //        {
            //            arrayList.RemoveAt(i);
            //        }
            //    }
            //}
            #endregion

            #region 7. Implement a queue that can hold different data types.
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //Console.WriteLine("Queue Data:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack. Then  search for a target integer in the stack.If the target is found,  indicating that the target was found how many elements before finding the target(“Target was found successfully the count = 5”).If the target is not found, print a message indicating the target was not found(“Target was not found”).
            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine("Enter the target integer:");
            //int target = int.Parse(Console.ReadLine());

            //FindTargetInStack(stack, target); 
            #endregion

            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            //var arr = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;
            //var result = FindSubArrayWithTargetSum(arr, target);
            //Console.WriteLine("[" + string.Join(", ", result) + "]"); 
            #endregion

            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order
            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int k = 3;
            //var result = ReverseFirstKElements(queue, k);
            //Console.WriteLine("[" + string.Join(", ", result) + "]"); 
            #endregion
        }
        #region Q8 Function
        //public static void FindTargetInStack(Stack<int> stack, int target)
        //{
        //    int count = 0;
        //    bool found = false;

        //    foreach (int element in stack)
        //    {
        //        count++;
        //        if (element == target)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (found)
        //    {
        //        Console.WriteLine($"Target was found successfully and the count = {count}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Target was not found");
        //    }
        //} 
        #endregion
        #region Q10 Function
        //public static List<int> FindSubArrayWithTargetSum(List<int> arr, int target)
        //{
        //    int currentSum = 0;
        //    int start = 0;

        //    for (int end = 0; end < arr.Count; end++)
        //    {
        //        currentSum += arr[end];

        //        while (currentSum > target && start <= end)
        //        {
        //            currentSum -= arr[start];
        //            start++;
        //        }

        //        if (currentSum == target)
        //        {
        //            return arr.GetRange(start, end - start + 1);
        //        }
        //    }

        //    return new List<int>();

        //} 
        #endregion
        #region Q11 Function
        //public static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        //{
        //    if (queue == null || k <= 0 || k > queue.Count)
        //    {
        //        return queue;
        //    }

        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < k; i++)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }

        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }

        //    for (int i = 0; i < queue.Count - k; i++)
        //    {
        //        queue.Enqueue(queue.Dequeue());
        //    }

        //    return queue;
        //} 
        #endregion
    }
}
