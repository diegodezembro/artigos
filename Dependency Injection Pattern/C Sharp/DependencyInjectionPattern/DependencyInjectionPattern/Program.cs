using System;
namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent parent = new Parent(new Child());
            Parent parent = new Parent();
            //parent.Child = new Child();
            parent.InjetarDependencia(new Child());
            parent.RealizarTarefa();
        }
    }
    interface IParent
    {
        void InjetarDependencia(IChild child);
    }
    //class Parent
    //{
    //    private IChild _child;
    //    public Parent(IChild child)
    //    {
    //        _child = child;
    //    }
    //    public void RealizarTarefa()
    //    {
    //        _child.RealizarTarefa();
    //    }
    //}
    //class Parent
    //{
    //    private IChild _child;
    //    //public Parent(IChild child)
    //    //{
    //    //    _child = child;
    //    //}
    //    public IChild Child
    //    {
    //        set
    //        {
    //            _child = value;
    //        }
    //    }
    //    public void RealizarTarefa()
    //    {
    //        _child.RealizarTarefa();
    //    }
    //}
    class Parent : IParent
    {
        private IChild _child;
        public void InjetarDependencia(IChild child)
        {
            this._child = child;
        }
        public void RealizarTarefa()
        {
            this._child.RealizarTarefa();
        }
    }
    interface IChild
    {
        void RealizarTarefa();
    }
    class Child : IChild
    {
        public void RealizarTarefa()
        {
            Console.WriteLine("Tarefa realizada!");
            Console.ReadKey();
        }
    }
}