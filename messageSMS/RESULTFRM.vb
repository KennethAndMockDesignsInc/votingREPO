Imports System.Data.SqlClient
Public Class RESULTFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim bsf As New BindingSource
    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadmalelist()
    End Sub
    Private Sub loadmalelist()
        Dim v As String
        If MetroToggle1.Checked = True Then
            v = "format((nullif(VOTES,0)/nullif(@TOTALVOTES,0))*100,'n2')+'%'"
        Else
            v = "format(VOTES,'n2')"
        End If
        Dim str As String = "
      UPDATE REGISTERTB SET VOTES = (SELECT COUNT(*) FROM VOTETB WHERE SMS = VOTE) where gender = 'Male'
      DECLARE @TOTALVOTES AS decimal(10,2) = (select count(*) from votetb where sms like '%M%')
      select TOP " & rownum.Text & "
      [FULLNAME]
,fullname as name
      ,VOTE
      ,[IMG]
      ," & v & " as VOTES
      from registertb where gender ='Male' ORDER BY CAST(VOTES AS DECIMAL) DESC"
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
                        MGRID.DataSource = bs
                        addbtn()

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub addbtn()

        For i As Integer = 0 To MGRID.RowCount - 1
            Dim str As String = "C:\Users\kmdim\Desktop\9wi67i2t.bmp"
            MGRID.Rows(i).Cells(0).Value = Image.FromFile(str)
            MGRID.Rows(i).Cells(1).Value = "No Name" + "" & vbCrLf & "" + "" & i + 1 & ""
            MGRID.Rows(i).Cells("votes").Style.Font = New Font("Tahoma", 20, FontStyle.Bold)
            MGRID.Rows(i).Cells("fullname").Style.Font = New Font("Tahoma", 12, FontStyle.Bold)
            MGRID.Rows(i).Cells("fullname").Style.ForeColor = Color.Black
            MGRID.Rows(i).Cells("fullname").Style.BackColor = Color.White
            MGRID.Rows(i).Cells("fullname").Style.SelectionBackColor = Color.White
            MGRID.Rows(i).Cells("fullname").Style.SelectionForeColor = Color.Black
        Next

        For i As Integer = mcount.Text - 1 To MGRID.RowCount - 1
            Dim str As String = MGRID.Rows(i).Cells("img").Value.ToString
            MGRID.Rows(i).Cells(0).Value = Image.FromFile(str)
            MGRID.Rows(i).Cells(1).Value = MGRID.Rows(i).Cells("VOTE").Value + "" & vbCrLf & "" + MGRID.Rows(i).Cells(2).Value + "" & vbCrLf & "" + "" & i + 1 & ""
        Next

        With MGRID
            .Columns("IMG").Visible = False
            .Columns("name").Visible = False
            .Columns("VOTE").Visible = False
            .Columns(0).Width = 200
            .Columns("fullname").Width = 180
            .Columns("votes").Width = 140
            .Columns("fullname").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("votes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub RESULTFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RESULTFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        refreshbtn.PerformClick()
        mcount.Text = MGRID.RowCount + 1
        refreshbtn.PerformClick()

        MetroTextButton1.PerformClick()
        fshow.Text = FGRID.RowCount + 1
        MetroTextButton1.PerformClick()
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        loadfemalelist()
    End Sub
    Private Sub loadfemalelist()
        Dim v As String
        If MetroToggle2.Checked = True Then
            v = "format((nullif(VOTES,0)/nullif(@TOTALVOTES,0))*100,'n2')+'%'"
        Else
            v = "format(VOTES,'n2')"
        End If
        Dim str As String = "
      UPDATE REGISTERTB SET VOTES = (SELECT COUNT(*) FROM VOTETB WHERE SMS = VOTE) where gender = 'Female'
      DECLARE @TOTALVOTES AS decimal(10,2) = (select count(*) from votetb where sms like '%F%')
      select TOP " & frownum.Text & "
      [FULLNAME]
      ,fullname as name,VOTE
      ,[IMG]
      ," & v & " as VOTES
      from registertb where gender ='Female' ORDER BY CAST(VOTES AS DECIMAL) DESC"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "registertb")
                        bsf.DataSource = ds
                        bsf.DataMember = "registertb"
                        FGRID.DataSource = bsf
                        addbtnf()

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub addbtnf()

        For i As Integer = 0 To FGRID.RowCount - 1
            Dim str As String = "C:\Users\kmdim\Desktop\gv3qbbiv.bmp"
            FGRID.Rows(i).Cells(0).Value = Image.FromFile(str)
            FGRID.Rows(i).Cells(1).Value = "No Name" + "" & vbCrLf & "" + "" & i + 1 & ""
            FGRID.Rows(i).Cells("votes").Style.Font = New Font("Tahoma", 20, FontStyle.Bold)
            FGRID.Rows(i).Cells("fullname").Style.Font = New Font("Tahoma", 12, FontStyle.Bold)
            FGRID.Rows(i).Cells("fullname").Style.ForeColor = Color.Black
            FGRID.Rows(i).Cells("fullname").Style.BackColor = Color.White
            FGRID.Rows(i).Cells("fullname").Style.SelectionBackColor = Color.White
            FGRID.Rows(i).Cells("fullname").Style.SelectionForeColor = Color.Black
        Next

        For i As Integer = fshow.Text - 1 To FGRID.RowCount - 1
            Dim str As String = FGRID.Rows(i).Cells("img").Value.ToString
            FGRID.Rows(i).Cells(0).Value = Image.FromFile(str)
            FGRID.Rows(i).Cells(1).Value = FGRID.Rows(i).Cells("VOTE").Value + "" & vbCrLf & "" + FGRID.Rows(i).Cells(2).Value + "" & vbCrLf & "" + "" & i + 1 & ""
        Next

        With FGRID
            .Columns("IMG").Visible = False
            .Columns("name").Visible = False
            .Columns("VOTE").Visible = False
            .Columns(0).Width = 200
            .Columns("fullname").Width = 180
            .Columns("votes").Width = 140
            .Columns("fullname").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("votes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

End Class