Imports System.IO

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles search.Click
        load()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'src1p.Visible = False
        'src2p.Visible = False
        'src3p.Visible = False
        'src4p.Visible = False

        load()
    End Sub

    Private Sub load()
        Dim k As Integer
        i = 0
        FileOpen(1, Path, OpenMode.Input)
        Try
            Do While Not EOF(1)
                Input(1, txtLine)
                If Spr IsNot "\0" Then
                    Spr = txtLine.Split("/")
                    sol(i).Name = Spr(0)
                    sol(i).Age = Spr(1)
                    sol(i).Num = Spr(2)
                    sol(i).Cls = Spr(3)
                    sol(i).Aff = Spr(4)
                    sol(i).Os = Spr(5)
                    sol(i).Stat = Spr(6)
                    sol(i).Pic = Spr(7)
                End If
                i += 1
            Loop

            FileClose(1)
        Catch
            FileClose(1)
        End Try

        If i Mod 10 <> 0 Then
            k = (i / 10 + 1)
        Else
            k = i / 10
        End If

        For j = 0 To 9
            Lv01.Items.Add(j + 1)
            Lv01.Items(j).SubItems.Add(sol(j).Name)
            Lv01.Items(j).SubItems.Add(sol(j).Age)
            Lv01.Items(j).SubItems.Add(sol(j).Num)
            Lv01.Items(j).SubItems.Add(sol(j).Cls)
            Lv01.Items(j).SubItems.Add(sol(j).Aff)
            Lv01.Items(j).SubItems.Add(sol(j).Os)
            Lv01.Items(j).SubItems.Add(sol(j).Stat)
        Next j

        Lv01.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Dim cc As ListView.ColumnHeaderCollection = Lv01.Columns

        For j = 0 To cc.Count - 1
            Dim icolWidth As Integer = TextRenderer.MeasureText(cc(j).Text, Lv01.Font).Width + 10
            If icolWidth > cc(j).Width Then
                cc(j).Width = icolWidth
            End If
        Next
    End Sub




    Private Sub Form3_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Lv01.Top = 100
        Lv01.Left = 10
        Lv01.Height = Me.Height - 300
        Lv01.Width = Me.Width - 35

        Lbpanel.Top = Me.Height - 100
        Lbpanel.Left = 300
        Lbpanel.Height = Me.Height - 10
        Lbpanel.Width = Me.Width - 600
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles L1.Click
        L1.ForeColor = Color.White
        L2.ForeColor = Color.Black
        L3.ForeColor = Color.Black
        L4.ForeColor = Color.Black
        L5.ForeColor = Color.Black


        For j = 0 To 9
            Lv01.Items(j).SubItems.Clear()
            Lv01.Items(j).SubItems.Add(sol(j).Name)
            Lv01.Items(j).SubItems.Add(sol(j).Age)
            Lv01.Items(j).SubItems.Add(sol(j).Num)
            Lv01.Items(j).SubItems.Add(sol(j).Cls)
            Lv01.Items(j).SubItems.Add(sol(j).Aff)
            Lv01.Items(j).SubItems.Add(sol(j).Os)
            Lv01.Items(j).SubItems.Add(sol(j).Stat)
        Next j
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles L2.Click
        L1.ForeColor = Color.Black
        L2.ForeColor = Color.White
        L3.ForeColor = Color.Black
        L4.ForeColor = Color.Black
        L5.ForeColor = Color.Black

        For j = 10 To 19
            Lv01.Items(j - 10).SubItems.Clear()
            'Lv01.Items(j - 10).SubItems.Add(j + 1) 
            Lv01.Items(j - 10).SubItems.Add(sol(j).Name)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Age)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Num)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Cls)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Aff)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Os)
            Lv01.Items(j - 10).SubItems.Add(sol(j).Stat)
        Next j

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles L3.Click
        L1.ForeColor = Color.Black
        L2.ForeColor = Color.Black
        L3.ForeColor = Color.White
        L4.ForeColor = Color.Black
        L5.ForeColor = Color.Black
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles L4.Click
        L1.ForeColor = Color.Black
        L2.ForeColor = Color.Black
        L3.ForeColor = Color.Black
        L4.ForeColor = Color.White
        L5.ForeColor = Color.Black
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles L5.Click
        L1.ForeColor = Color.Black
        L2.ForeColor = Color.Black
        L3.ForeColor = Color.Black
        L4.ForeColor = Color.Black
        L5.ForeColor = Color.White
    End Sub

    Private Sub srcplus_Click(sender As Object, e As EventArgs) Handles srcplus.Click

        If searchbar.Text <> "" Then
            srcctt = searchbar.Text
            src1.Text = srcctt
            src1p.Visible = True
            src1x.Left = src1.Left + src1.Width + 5
        End If

    End Sub

    Private Sub src1x_Click(sender As Object, e As EventArgs) Handles src1x.Click

        src1p.Visible = False

    End Sub

End Class