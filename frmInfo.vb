Public Class frmInfo

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub frmInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblInfo.Text = "1. Click on a square to try and catch Horace!" & vbCrLf
        lblInfo.Text += vbCrLf & "2. If you click on the square he lands on you will catch him." & vbCrLf
        lblInfo.Text += vbCrLf & "3. However, if he lands on the square you just clicked on, he will jump on you and you lose."
        Me.Refresh()
    End Sub
End Class