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
        }
    }
}
