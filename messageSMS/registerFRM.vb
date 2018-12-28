Imports System.Data.SqlClient
Public Class registerFRM
    Dim sql As New sql
    Private Sub registerFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        home.loa()
        Me.Dispose()
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs) Handles metroTextButton1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PATH.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = PATH.Text
        End If
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If Me.Text = "New" Then
            add()
            listFRM.refreshbtn.PerformClick()
        ElseIf Me.Text = "Editing" Then
            updating()
            listFRM.refreshbtn.PerformClick()
        End If
    End Sub
    Public Sub add()
        Dim str As String = "
                            declare @id as integer = (select isnull(max(id),0)+1 from registertb)
                            insert into registertb (id,fullname,img,vote,gender)values(@id,@fullname,@img,@vote,@gender)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@fullname", FULLNAME.Text)
                    sqlcmd.Parameters.AddWithValue("@img", PATH.Text)
                    sqlcmd.Parameters.AddWithValue("@gender", gender.Text)
                    sqlcmd.Parameters.AddWithValue("@vote", tovote.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub updating()
        Dim str As String = "update registertb set img=@img,fullname=@fullname,vote=@vote,gender=@gender where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@fullname", FULLNAME.Text)
                    sqlcmd.Parameters.AddWithValue("@img", PATH.Text)
                    sqlcmd.Parameters.AddWithValue("@id", listFRM.id)
                    sqlcmd.Parameters.AddWithValue("@gender", gender.Text)
                    sqlcmd.Parameters.AddWithValue("@vote", tovote.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub PATH_TextChanged(sender As Object, e As EventArgs) Handles PATH.TextChanged
        PictureBox1.ImageLocation = PATH.Text
    End Sub
End Class