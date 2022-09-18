Public Module Bring
    Public Sub Form_Load()
        Dim txtLine As String
        Dim Spr() As String

        FileOpen(1, Path, OpenMode.Input)
        Try
            Do While Not EOF(1)
                Input(1, txtLine)
                i += 1
            Loop

            If Spr Is "\0" Then
                Spr = txtLine.Split("$")
                sol(i).Name = Spr(0)
                sol(i).Age = Spr(1)
                sol(i).Num = Spr(2)
                sol(i).Cls = Spr(3)
                sol(i).Aff = Spr(4)
                sol(i).Os = Spr(5)
                sol(i).Stat = Spr(6)
                sol(i).Pic = Spr(7)
            End If

            FileClose(1)
        Catch
            FileClose(1)
        End Try
    End Sub

End Module

