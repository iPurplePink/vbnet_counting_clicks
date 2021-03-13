Public Class Form1

    Private Sub Backbutton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = My.Resources.whto
    End Sub
    Private Sub Backbutton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackgroundImage = My.Resources.blo
    End Sub
    Private Sub Backbutton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = My.Resources.orng
    End Sub

    Private Sub Backbutton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = My.Resources.blo
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        ListBox1.Items.Clear()
        Timer1.Start()
        Timer2.Start()

        Label3.Text = "quick clicks"
        Label1.Text = "3"

        Button6.Visible = False
        Button7.Visible = False
        Label4.Visible = False


        Button1.Location = New Point(69, 64)
        Button1.Height = 75
        Button1.Width = 75

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        ListBox1.Items.Clear()
        Timer1.Start()
        Timer2.Start()

        Label3.Text = "arcade"
        Label1.Text = "3"
        Label2.Text = "0"

        Button6.Visible = False
        Button7.Visible = False
        Label4.Visible = False

        Randomize()
        Dim count As Integer = ListBox2.Items.Count
        Dim random As New Random
        Me.ListBox2.SelectedIndex = random.Next(0, count)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add("1")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text -= 1

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If Label3.Text = "quick clicks" Then
            Timer1.Stop()
            Timer2.Stop()
            Label1.Text = ""
            Timer3.Interval = 6900
            Timer3.Start()
            Button1.Visible = True
        End If

        If Label3.Text = "arcade" Then
            Timer1.Stop()
            Timer2.Stop()
            Label1.Text = ""
            Timer4.Interval = 3575
            Timer4.Start()
            Button1.Visible = True
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Button1.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer3.Stop()

        Button7.Visible = True
        Label4.Visible = True

        Dim score As Integer

        For Each Str As String In ListBox1.Items
            score = score + CInt(Str)
        Next
        Label1.Text = score
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label2.Text += 1

        Randomize()
        Dim count As Integer = ListBox2.Items.Count
        Dim random As New Random
        Me.ListBox2.SelectedIndex = random.Next(0, count)

        If Label2.Text = "3" Then
            Timer4.Stop()
            Timer3.Interval = 3575
            Timer3.Start()

        End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Select Case ListBox2.SelectedIndex
            Case 0
                Button1.Location = New Point(11, 14)
            Case 1
                Button1.Location = New Point(11, 85)
            Case 2
                Button1.Location = New Point(11, 170)
            Case 3
                Button1.Location = New Point(126, 32)
            Case 4
                Button1.Location = New Point(127, 163)
            Case 5
                Button1.Location = New Point(228, 14)
            Case 6
                Button1.Location = New Point(228, 85)
            Case 7
                Button1.Location = New Point(228, 176)
            Case 8
                Button1.Location = New Point(326, 14)
            Case 9
                Button1.Location = New Point(326, 95)
            Case 10
                Button1.Location = New Point(337, 170)
            Case 11
                Button1.Location = New Point(425, 13)
            Case 12
                Button1.Location = New Point(427, 105)
            Case 13
                Button1.Location = New Point(438, 176)
            Case 14
                Button1.Location = New Point(544, 4)
            Case 15
                Button1.Location = New Point(544, 104)
            Case 16
                Button1.Location = New Point(544, 176)
        End Select


    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub
End Class
