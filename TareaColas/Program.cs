namespace TareaColas
{
    using System;
    using System.Collections.Generic;

    public class CustomQueue<T>
    {
        // Lista interna para almacenar los elementos de la cola
        private List<T> _queue;

        // Constructor
        public CustomQueue()
        {
            _queue = new List<T>();
        }

        // Enqueue: Agrega un elemento al final de la cola
        public void Enqueue(T item)
        {
            _queue.Add(item);
        }

        // Dequeue: Remueve y devuelve el primer elemento de la cola
        public T Dequeue()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            T item = _queue[0];
            _queue.RemoveAt(0); // Remover el primer elemento
            return item;
        }

        // Peek: Devuelve el primer elemento sin removerlo
        public T Peek()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return _queue[0];
        }

        // Count: Devuelve el número de elementos en la cola
        public int Count()
        {
            return _queue.Count;
        }

        // Clear: Limpia todos los elementos de la cola
        public void Clear()
        {
            _queue.Clear();
        }

        // GetFirst:Devuelve el primer elemento de la cola
        public T GetFirst()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return _queue[0];
        }

        // GetLast: Devuelve el último elemento de la cola
        public T GetLast()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("La cola está vacía.");
            }

            return _queue[_queue.Count - 1];
        }

        // GetAll: Devuelve todos los elementos de la cola en una lista
        public List<T> GetAll()
        {
            return new List<T>(_queue); // Retorna una copia de la lista
        }
    }

    // Ejemplo de uso:
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomQueue<object> queue = new CustomQueue<object>();

            queue.Enqueue("Primer elemento");
            queue.Enqueue(42);
            queue.Enqueue(3.14);

            Console.WriteLine("Primer elemento (Peek): " + queue.Peek()); // Primer elemento
            Console.WriteLine("Número de elementos (Count): " + queue.Count()); // 3

            Console.WriteLine("Elemento removido (Dequeue): " + queue.Dequeue()); // Primer elemento
            Console.WriteLine("Número de elementos después de Dequeue (Count): " + queue.Count()); // 2

            Console.WriteLine("Primer elemento (GetFirst): " + queue.GetFirst()); // 42
            Console.WriteLine("Último elemento (GetLast): " + queue.GetLast()); // 3.14

            List<object> allItems = queue.GetAll();
            Console.WriteLine("Todos los elementos:");
            foreach (var item in allItems)
            {
                Console.WriteLine(item);
            }

            queue.Clear();
            Console.WriteLine("Número de elementos después de Clear (Count): " + queue.Count()); // 0
        }
    }

}
