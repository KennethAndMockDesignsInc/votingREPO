Imports System.Data.SqlClient
Public Class home
    Dim sql As New sql
    Private Sub newPNL_Click(sender As Object, e As EventArgs) Handles newPNL.Click
        listFRM.ShowDialog()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Form1.ShowDialog()
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        RESULTFRM.ShowDialog()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loa()
        Timer1.Start()
    End Sub
    Public Sub loa()
        Dim str As String = "select * from registertb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "registertb")
                        ComboBox1.DataSource = ds.Tables("registertb")
                        ComboBox1.DisplayMember = "IMG"
                        ComboBox2.DataSource = ds.Tables("registertb")
                        ComboBox2.DisplayMember = "VOTE"
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim max As Integer = ComboBox1.Items.Count - 1
        Dim selected As Integer = ComboBox1.SelectedIndex
        If ComboBox1.SelectedIndex = max Then
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
        Else
            ComboBox1.SelectedIndex = selected + 1
            ComboBox2.SelectedIndex = selected + 1
        End If
        PictureBox1.ImageLocation = ComboBox1.Text
        KryptonLabel8.Text = ComboBox2.Text
        restarttimer()
    End Sub
    Public Sub restarttimer()
        Timer1.Stop()
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub
End Class