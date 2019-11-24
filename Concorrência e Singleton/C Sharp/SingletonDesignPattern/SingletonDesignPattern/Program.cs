using System;
namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instancia1 = Singleton.Instancia;
            Singleton instancia2 = Singleton.Instancia;
            Singleton instancia3 = Singleton.Instancia;
            if (instancia1.Equals(instancia2) && instancia2.Equals(instancia3))
            {
                Console.WriteLine("Mesma instância!");
            }
            Console.ReadKey();
        }
    }
    //class Singleton
    //{
    //    private static Singleton _instancia;
    //    private Singleton()
    //    {
    //        // Construtor privado para evitar instâncias.
    //    }
    //    public static Singleton Instancia
    //    {
    //        get
    //        {
    //            if (_instancia == null)
    //            {
    //                _instancia = new Singleton();
    //            }
    //            return _instancia;
    //        }
    //    }
    //}
    //class Singleton
    //{
    //    private static Singleton _instancia;
    //    private static object _bloqueio = new object();
    //    private Singleton()
    //    {
    //        // Construtor privado para evitar instâncias.
    //    }
    //    public static Singleton Instancia
    //    {
    //        get
    //        {
    //            if (_instancia == null)
    //            {
    //                lock (_bloqueio)
    //                {
    //                    _instancia = new Singleton();
    //                }
    //            }
    //            return _instancia;
    //        }
    //    }
    //}
    //class Singleton
    //{
    //    private static Singleton _instancia;
    //    private static object _bloqueio = new object();
    //    private Singleton()
    //    {
    //        // Construtor privado para evitar instâncias.
    //    }
    //    public static Singleton Instancia
    //    {
    //        get
    //        {
    //            if (_instancia == null)
    //            {
    //                lock (_bloqueio)
    //                {
    //                    if (_instancia == null)
    //                    {
    //                        _instancia = new Singleton();
    //                    }
    //                }
    //            }
    //            return _instancia;
    //        }
    //    }
    //}
    class Singleton
    {
        private static readonly Singleton _instancia = new Singleton(); 
        private Singleton()
        {
            // Construtor privado para evitar instâncias.
        }
        public static Singleton Instancia
        {
            get
            {
                return _instancia;
            }
        }
    }
}