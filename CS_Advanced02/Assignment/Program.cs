using System.Collections;
using System.Globalization;

namespace Assignment
{
    internal class Program
    {
        static bool IsPalindrome(string str)
        {
            bool flag = false;
            int size = (str.Length - 1) / 2;
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < size; i++)
                {
                    flag = str[i] == str[str.Length - i - 1];
                }
            }
            return flag;
        }
        static int Greater(int[] arr, int value)
        {
            int count = 0;
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > value)
                        count++;
                }
            }
            return count;
        }
        static void ReverseQueue(Queue<int> values)
        {
            Stack<int> stack = new Stack<int>(values);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
        static T[] RemoveDuplicate<T>(T[] arr)
        {
            HashSet<T> result = new HashSet<T>(arr);
            return result.ToArray();
        }


        static void RemoveOdd(ArrayList list)
        {
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if ((int)list[i] % 2 != 0)
                        list.RemoveAt(i);
                }
            }
        }

        static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            Stack<int> tempStack = new Stack<int>(stack);

            while (tempStack.Count > 0)
            {
                count++;
                if (tempStack.Pop() == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
            }

            Console.WriteLine("Target was not found");
        }

        static Queue<int> Reverse(Queue<int> items, int k)
        {
            if (items != null || k <= 0 || k > items.Count)
            {
                Stack<int> stack = new Stack<int>();
                Queue<int> queue = new Queue<int>();
                for (int i = 0; i < k; i++)
                {
                    stack.Push(items.Dequeue());
                }
                for (int i = 0; i < k; i++)
                {
                    queue.Enqueue(stack.Pop());
                }
                int index = items.Count - k;
                for (int i = index; i < items.Count; i++)
                {
                    queue.Enqueue(items.Dequeue());
                }
                return queue;
            }
            return null;
        }

        static int[] Intersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> items = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in arr1)
            {
                if (items.ContainsKey(num))
                    items[num]++;
                else
                    items[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (items.ContainsKey(num) && items[num] > 0)
                {
                    result.Add(num);
                    items[num]--;
                }
            }

            return result.ToArray();
        }

        static bool IsBalance(string str)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                {'}','{'},
                {']','['},
                {')','('}
            };
            Stack<char> stack = new Stack<char>();
            foreach (char item in str)
            {
                if (item == '[' || item == '{' || item == '(')
                {
                    stack.Push(item);
                }
                else if (brackets[item] != stack.Pop())
                {
                    return false;
                }
                
            }
            return stack.Count == 0;
        }
        static void DisplayList(ICollection collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            #region Q1
            //int arrSize, querySize;
            //do
            //{
            //    Console.Write("Enter the Size Of Array: ");
            //} while (!int.TryParse(Console.ReadLine(), out arrSize) || arrSize <= 0);
            //do
            //{
            //    Console.Write("Enter the Size Of Queries: ");
            //} while (!int.TryParse(Console.ReadLine(), out querySize) || querySize <= 0);

            //int[] arr = new int[arrSize];
            //int[] query = new int[querySize];

            //for (int i = 0; i < arrSize; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Array Number({i + 1}): ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //for (int i = 0; i < querySize; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Query Number({i + 1}): ");
            //    } while (!int.TryParse(Console.ReadLine(), out query[i]));
            //}

            //for (int i = 0; i < querySize; i++)
            //{
            //    Console.WriteLine($"Numbers Greater Than ({query[i]}): {Greater(arr, query[i])}");
            //} 
            #endregion

            #region Q2
            //int arrSize;
            //do
            //{
            //    Console.Write("Enter the Size Of Array: ");
            //} while (!int.TryParse(Console.ReadLine(), out arrSize) || arrSize <= 0);
            
            //int[] arr = new int[arrSize];
            
            //for (int i = 0; i < arrSize; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Array Number({i + 1}): ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            
            //if (IsPalindrome(string.Join("", arr)))
            //    Console.WriteLine("Numbers is Palindrome");
            //else
            //    Console.WriteLine("Numbers is not Palindrome"); 
            #endregion
                
            #region Q3
            //Queue<int> items = new Queue<int>();
            //int num;
            //do
            //{
            //    Console.Write("Enter the Number Of Integerts: ");
            //} while (!int.TryParse(Console.ReadLine(), out num) || num <= 0);
            //for (int i = 0; i < num; i++)
            //{
            //    int buffer;
            //    do
            //    {
            //        Console.Write($"Enter the Number({i + 1}): ");
            //    } while (!int.TryParse(Console.ReadLine(), out buffer));
            //    items.Enqueue(buffer);
            //}

            //ReverseQueue(items);
            #endregion

            #region Q4
            //string brackets = "[()]{}";
            //if (IsBalance(brackets))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced"); 
            #endregion

            #region Q5
            //int[] arr = { 1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10 };
            //int[] arr2 = RemoveDuplicate<int>(arr);
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write($"{arr2[i]} ");
            //}
            //string[] names = { "Ahmed" ,"Ahmed", "Abdelrahman", "Abdelrahman", "Omar"};
            //string[] names2 = RemoveDuplicate<string>(names);
            //for (int i = 0;i < names2.Length;i++)
            //{
            //    Console.Write($"{names2[i]} ");
            //}

            #endregion

            #region Q6
            //ArrayList arr = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //RemoveOdd(arr);
            //DisplayList(arr); 
            #endregion

            #region Q7
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //DisplayList(queue); 
            #endregion

            #region Q8
            //int arrSize;
            //do
            //{
            //    Console.Write("Enter the Size Of Array: ");
            //} while (!int.TryParse(Console.ReadLine(), out arrSize) || arrSize <= 0);

            //int[] arr = new int[arrSize];

            //for (int i = 0; i < arrSize; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Array Number({i + 1}): ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));
            //}
            //int target;
            //do
            //{
            //    Console.Write("Enter the Target: ");
            //} while (!int.TryParse(Console.ReadLine(), out target));
            //SearchInStack(new Stack<int>(arr),target); 
            #endregion

            #region Q9
            //int arr1Size, arr2Size;
            //do
            //{
            //    Console.Write("Enter the Size Of Array 1: ");
            //} while (!int.TryParse(Console.ReadLine(), out arr1Size) || arr1Size <= 0);
            //do
            //{
            //    Console.Write("Enter the Size Of Array 2: ");
            //} while (!int.TryParse(Console.ReadLine(), out arr2Size) || arr2Size <= 0);

            //int[] arr1 = new int[arr1Size];
            //int[] arr2 = new int[arr2Size];

            //for (int i = 0; i < arr1Size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Element ({i + 1}) Of Array 1: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr1[i]));
            //}
            //for (int i = 0; i < arr2Size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Element ({i + 1}) Of Array 2: ");
            //    } while (!int.TryParse(Console.ReadLine(), out arr2[i]));
            //}

            //int[] result = Intersection(arr1, arr2);
            //DisplayList(result); 
            #endregion

            #region Q11
            //Queue<int> queue = new Queue<int>();

            //int num, value,k;
            //do
            //{
            //    Console.Write("Enter the Number Of Elements: ");
            //} while (!int.TryParse(Console.ReadLine(), out num) || num <= 0);
            //for (int i = 0; i < num; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter the Element {i + 1}: ");
            //    } while (!int.TryParse(Console.ReadLine(), out value));
            //    queue.Enqueue(value);
            //}
            //do
            //{
            //    Console.Write("Enter the Number Of Reverse(K): ");
            //} while (!int.TryParse(Console.ReadLine(), out k) || k <= 0);
            //Queue<int> result = Reverse(queue,k);

            //DisplayList(result); 
            #endregion

        }
    }
}
