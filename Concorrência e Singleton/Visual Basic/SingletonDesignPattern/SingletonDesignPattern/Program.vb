Namespace SingletonDesignPattern
    Module Program
        Sub Main()
            Dim instancia1 As Singleton = Singleton.Instancia
            Dim instancia2 As Singleton = Singleton.Instancia
            Dim instancia3 As Singleton = Singleton.Instancia
            If (instancia1.Equals(instancia2) AndAlso instancia2.Equals(instancia3)) Then
                Console.WriteLine("Mesma instância!")
            End If
            Console.ReadKey()
        End Sub
    End Module
    'Class Singleton
    '    Private Shared _instancia As Singleton
    '    Protected Sub New()
    '        ' Construtor privado para evitar instâncias.
    '    End Sub
    '    Public Shared ReadOnly Property Instancia() As Singleton
    '        Get
    '            If (_instancia Is Nothing) Then
    '                _instancia = New Singleton()
    '            End If
    '            Return _instancia
    '        End Get
    '    End Property
    'End Class
    'Class Singleton
    '    Private Shared _instancia As Singleton
    '    Private Shared _bloqueio As Object = New Object()
    '    Protected Sub New()
    '        ' Construtor privado para evitar instâncias.
    '    End Sub
    '    Public Shared ReadOnly Property Instancia() As Singleton
    '        Get
    '            If (_instancia Is Nothing) Then
    '                SyncLock (_bloqueio)
    '                    _instancia = New Singleton()
    '                End SyncLock
    '            End If
    '            Return _instancia
    '        End Get
    '    End Property
    'End Class
    'Class Singleton
    '    Private Shared _instancia As Singleton
    '    Private Shared _bloqueio As Object = New Object()
    '    Protected Sub New()
    '        ' Construtor privado para evitar instâncias.
    '    End Sub
    '    Public Shared ReadOnly Property Instancia() As Singleton
    '        Get
    '            If (_instancia Is Nothing) Then
    '                SyncLock (_bloqueio)
    '                    If (_instancia Is Nothing) Then
    '                        _instancia = New Singleton()
    '                    End If
    '                End SyncLock
    '            End If
    '            Return _instancia
    '        End Get
    '    End Property
    'End Class
    Class Singleton
        Private Shared ReadOnly _instancia As Singleton = New Singleton()
        Private Sub New()
            ' Construtor privado para evitar instâncias.
        End Sub
        Public Shared ReadOnly Property Instancia() As Singleton
            Get
                Return _instancia
            End Get
        End Property
    End Class
End Namespace