using System;

namespace Generics
{
    class Program
    { 
        static void Main(string[] args)
        {
            Add<int>(100);
            int result = Add1<int>(100);
            Console.WriteLine(result);
            Machine<int> M = new Machine<int>();
            M.Save(10);
            Console.WriteLine(M.Load());
        }
        public static void Add<T>(T a)
        {
            T c =  a;
            Console.WriteLine(c);
        }
        static B Add1<B>(B a)
        {
            B c = a;
            return c;
        }
    }
    class Machine<M>
    {
        M saved;
        public void Save(M item)
        {
            saved = item;
        }
        public M Load()
        {
            return saved;
        }
    }
    
}
