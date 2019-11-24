using System;
namespace CallbackDesignPattern
{
    public delegate void Notificacao(string mensagem);
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.EventoNotificacao += new Notificacao(new Observer().Notificar);
            subject.RealizarTarefa();
        }
    }
    abstract class Mediator
    {
        public event Notificacao EventoNotificacao;
        protected void Notificar(string mensagem)
        {
            if (EventoNotificacao != null)
            {
                EventoNotificacao.Invoke(mensagem);
            }
        }
        public abstract void RealizarTarefa();
    }
    class Subject : Mediator
    {
        public override void RealizarTarefa()
        {
            // TODO: Adicionar lógica...
            base.Notificar("Notificação...");
        }
    }
    class Observer
    {
        public void Notificar(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}