Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports MetroFramework

Public Class listFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Public id As String
    Private Sub listFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        registerFRM.Text = "New"
        registerFRM.PATH.Text = ""
        registerFRM.FULLNAME.Text = ""
        registerFRM.tovote.Text = ""
        registerFRM.gender.Text = ""
        registerFRM.savebtn.Text = "add"
        registerFRM.ShowDialog()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadlist()
    End Sub
    Private Sub loadlist()

        Dim str As String = "
      select [ID]
      ,[FULLNAME]
      ,[GENDER]
      ,[VOTE] as [TO VOTE],IMG
      from registertb ORDER BY VOTE ASC"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "registertb")
                        bs.DataSource = ds
                        bs.DataMember = "registertb"
                        GRID.DataSource = bs
                        addbtn()
                        With GRID
                            .Columns("ID").Visible = False
                            .Columns("IMG").Visible = False
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub addbtn()
        Try
            For i As Integer = 0 To GRID.RowCount - 1
                'Dim wc As New WebClient
                'System.Net.ServicePointManager.Expect100Continue = False
                'Dim bytes As Byte() = wc.DownloadData("" & GRID.Rows(i).Cells(6).Value.ToString & "")
                'Dim ms As New MemoryStream(bytes)
                'GRID.Rows(i).Cells(0).Value = Image.FromStream(ms)
                Dim str As String = GRID.Rows(i).Cells("img").Value.ToString
                GRID.Rows(i).Cells(0).Value = Image.FromFile(str)
            Next
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub GRID_SelectionChanged(sender As Object, e As EventArgs) Handles GRID.SelectionChanged
        Dim SELECTEDITEMS As DataGridViewSelectedRowCollection = GRID.SelectedRows
        For Each ROW As DataGridViewRow In SELECTEDITEMS
            id = ROW.Cells("ID").Value.ToString
            registerFRM.PATH.Text = ROW.Cells("img").Value.ToString
            registerFRM.FULLNAME.Text = ROW.Cells("FULLNAME").Value.ToString
            registerFRM.tovote.Text = ROW.Cells("to vote").Value.ToString
            registerFRM.gender.Text = ROW.Cells("gender").Value.ToString
        Next
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        registerFRM.Text = "Editing"
        registerFRM.savebtn.Text = "save"
        registerFRM.ShowDialog()
    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        If MetroMessageBox.Show(Me, "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
            Return
        End If
        Dim str As String = "delete from registertb where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshbtn.PerformClick()
    End Sub

    Private Sub listFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshbtn.PerformClick()
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
    End Sub


End Class