Public Module source
    Public i As Integer = 0
    Public j As Integer = 0
    Public txtLine As String
    Public Spr() As String
    Public sol(100) As Info
    Public Path As String = IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "datasol.txt")
    Public srcctt As String
    Public Structure Info
        Public Name As String
        Public Age As Integer
        Public Num As String
        Public Cls As String
        Public Aff As String
        Public Os As String
        Public Stat As String
        Public Pic As String
    End Structure

End Module
