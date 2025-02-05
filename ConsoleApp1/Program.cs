namespace ConsoleApp1
{
    internal class Program
    {
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (!IsMatchingPair(top, ch))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
        static void Main(string[] args)
        {
            #region Question01
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //ReverseQueue(queue);
            //Console.WriteLine("Reversed Queue: ");
            //foreach (int q in queue)
            //{
            //    Console.WriteLine(q);
            //} 
            #endregion

            #region Question02
            //string? input = Console.ReadLine();
            //if (IsBalanced(input))
            //{
            //    Console.WriteLine("Balanced");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced");
            //} 
            #endregion
        }
    }
}
