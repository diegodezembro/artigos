Imports System
Namespace CallbackDesignPattern
    Public Delegate Sub Notificacao(ByVal mensagem As String)
    Module Program
        Sub Main()
            Dim subject As Subject = New Subject()
            AddHandler subject.EventoNotificacao, AddressOf New Observer().Notificar
            subject.RealizarTarefa()
        End Sub
    End Module
    Friend MustInherit Class Mediator
        Public Event EventoNotificacao As Notificacao
        Protected Sub Notificar(ByVal mensagem As String)
            RaiseEvent EventoNotificacao(mensagem)
        End Sub
        Public MustOverride Sub RealizarTarefa()
    End Class
    Friend Class Subject
        Inherits Mediator
        Public Overrides Sub RealizarTarefa()
            ' TODO: Adicionar lógica...
            MyBase.Notificar("Notificação...")
        End Sub
    End Class
    Friend Class Observer
        Public Sub Notificar(ByVal mensagem As String)
            Console.WriteLine(mensagem)
            Console.ReadKey()
        End Sub
    End Class
End Namespace