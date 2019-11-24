Namespace DependencyInjectionPattern
    Module Program
        Sub Main()
            'Dim parent As Parent = New Parent(New Child())
            Dim parent As Parent = New Parent()
            'parent.Child = New Child()
            parent.InjetarDependencia(New Child())
            parent.RealizarTarefa()
        End Sub
    End Module
    Interface IParent
        Sub InjetarDependencia(ByVal child As IChild)
    End Interface
    'Class Parent
    '    Private _child As IChild
    '    Sub New(ByVal child As IChild)
    '        _child = child
    '    End Sub
    '    Public Sub RealizarTarefa()
    '        _child.RealizarTarefa()
    '    End Sub
    'End Class
    'Class Parent
    '    Private _child As IChild
    '    'Sub New(ByVal child As IChild)
    '    '    _child = child
    '    'End Sub
    '    Public WriteOnly Property Child() As IChild
    '        Set(ByVal value As IChild)
    '            _child = value
    '        End Set
    '    End Property
    '    Public Sub RealizarTarefa()
    '        _child.RealizarTarefa()
    '    End Sub
    'End Class
    Class Parent
        Implements IParent
        Private _child As IChild
        Sub InjetarDependencia(ByVal child As IChild) Implements IParent.InjetarDependencia
            Me._child = child
        End Sub
        Public Sub RealizarTarefa()
            Me._child.RealizarTarefa()
        End Sub
    End Class
    Interface IChild
        Sub RealizarTarefa()
    End Interface
    Class Child
        Implements IChild
        Sub RealizarTarefa() Implements IChild.RealizarTarefa
            Console.WriteLine("Tarefa realizada!")
            Console.ReadKey()
        End Sub
    End Class
End Namespace