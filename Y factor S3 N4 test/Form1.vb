Public Class Form1

    Dim displayList As String = ""
    Private Sub Test1_Click(sender As Object, e As EventArgs) Handles Test1.Click
        Dim contName1 As String
        Dim cont1j1 As Char
        Dim cont1j2 As Char
        Dim cont1j3 As Char
        Dim cont1j4 As Char
        Dim ans As String
        Dim score As Integer
        Dim HasWon As Boolean

        contName1 = Name1.Text
        cont1j1 = comboJ1.Text
        cont1j2 = comboJ2.Text
        cont1j3 = ComboJ3.Text
        cont1j4 = ComboJ4.Text
        score = getScore(cont1j1, cont1j2, cont1j3, cont1j4)
        HasWon = (score >= 2)

        If HasWon Then
            ans = "Well Done " & contName1 & " you have " & score & " votes and are through to the next round "
        Else
            ans = "Too Bad " & contName1 & " you have " & score & " votes and are NOT through to the next round "
        End If

        displayList = displayList & ans & vbNewLine

        results.Text = displayList
        clearInputs()
        'Maybe put up message box with ans

    End Sub

    Private Function getScore(j1, j2, j3, j4)
        Dim score = 0
        If j1 = "Y" Then
            score = score + 1
        End If
        If j2 = "Y" Then
            score = score + 1
        End If
        If j3 = "Y" Then
            score = score + 1
        End If
        If j4 = "Y" Then
            score = score + 1
        End If
        Return score
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub clearInputs()
        Name1.Text = ""
        comboJ1.Text = ""
        comboJ2.Text = ""
        ComboJ3.Text = ""
        ComboJ4.Text = ""


    End Sub



End Class
