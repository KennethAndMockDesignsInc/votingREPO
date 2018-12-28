Imports System
Imports System.IO
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class Form1
    Dim sql As New sql
    Dim rcvdata As String = ""
    Dim strSelectedAssignCode As String
    Dim index As String = ""
    Dim sqlcmdme As New SqlCommand
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myport.Text = Trim(Mid(ComboBox1.Text, 1, 5))
    End Sub

    Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click
        Me.connect.Enabled = False
        disconnect.Enabled = True
        connectoport()
        LoadMessages()
    End Sub
    Public Sub connectoport()
        SerialPort1.Close()
        Try
            With SerialPort1
                .PortName = myport.Text
                .BaudRate = 9600
                .Parity = Ports.Parity.None
                .DataBits = 8
                .StopBits = Ports.StopBits.One
                .Handshake = Ports.Handshake.None
                .RtsEnable = True
                .DtrEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
                .WriteLine("AT+CNMI=1,2,0,0,0" & vbCrLf)
            End With
            If SerialPort1.IsOpen Then
                KryptonLabel4.Text = "Connected"
            Else
                KryptonLabel4.Text = "Error"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoadMessages()
        Try
            With SerialPort1
                rcvdata = ""
                .Write("AT" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGF=1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+CPMS=""SM""" & vbCrLf) 'SM ME MT BM SR
                Threading.Thread.Sleep(1000)
                .Write("AT+CMGL=""ALL""" & vbCrLf)
                Threading.Thread.Sleep(1000)
                ReadMsg()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ReadMsg()
        Try
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            Dim lineoftext As String
            Dim i As Integer = 1
            Dim arytextfile() As String
            lineoftext = rcvdata.ToString
            arytextfile = Split(lineoftext, "+CMGL", , CompareMethod.Text)
            For i = 1 To UBound(arytextfile)
                Dim input As String = arytextfile(i)
                Dim result() As String
                Dim pattern As String = "(:)|(,"")|("","")"
                result = Regex.Split(input, pattern)
                Dim lvi As New ListViewItem
                Dim concat() As String
                Dim my_string, position As String
                my_string = result(6)
                position = my_string.Length - 2
                my_string = my_string.Remove(position, 2)
                concat = New String() {result(8) & result(9) & result(10) & result(11) & result(12).Substring(0, 2)}
                Dim lineoftexts As String
                Dim arytextfiles() As String
                lineoftexts = arytextfile(i)
                arytextfiles = Split(lineoftexts, "+32", , CompareMethod.Text)
                ComboBox2.Items.Add(arytextfiles(1))
                ComboBox3.Items.Add(my_string)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub disconnect_Click(sender As Object, e As EventArgs) Handles disconnect.Click
        SerialPort1.Close()
        Me.disconnect.Enabled = False
        connect.Enabled = True
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = ""
        Dim numbytes As Integer = SerialPort1.BytesToRead

        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)
        Next
        test(datain)
    End Sub
    Private Sub test(ByVal indata As String)
        rcvdata &= indata
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        real()
    End Sub
    Private Sub real()
        ComboBox1.Items.Clear()
        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            ComboBox1.Items.Add(ports(i))
            ComboBox1.SelectedIndex = 0
        Next
        connectoport()
        LoadMessages()
    End Sub
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

            For Each queryObject As ManagementObject In searcher.Get()
                If queryObject("Status") = "OK" Then
                    modems = modems & (queryObject("AttachedTo") & " - " & queryObject("Description") & "***")
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occured while querying for WMI data: ", MsgBoxStyle.Critical, "Error")
            Return ""
        End Try
        Return modems
    End Function
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click

        real()
        insertdata()
    End Sub
    Public Sub insertdata()

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = ComboBox2.Items.Count

        For i As Integer = 0 To ComboBox2.Items.Count - 1

            Dim contact As String = ComboBox3.Items(i).ToString
            Dim vote As String = ComboBox2.Items(i).ToString.Replace("OK", "")

            vote = vote.Replace("'", "")
            vote = vote.Replace("""", "")
            vote = vote.Replace(vbCrLf, "")
            vote = vote.Replace("OK", "")

            Dim validate As String = "select * from registertb where vote = @vote"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(validate, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@vote", vote)
                        Using rd As SqlDataReader = sqlcmd.ExecuteReader
                            If rd.HasRows = True Then
                                rd.Close()

                                If vote.Contains("M") Then
                                    Dim VOTEDMALE As String = "select * from votetb where sms like '%M%' and contact = @contact"
                                    Dim cmd As SqlCommand = New SqlCommand(VOTEDMALE, sqlcon)
                                    cmd.Parameters.AddWithValue("@contact", contact)
                                    Dim readm As SqlDataReader = cmd.ExecuteReader
                                    If readm.HasRows = True Then
                                        readm.Close()
                                    Else
                                        readm.Close()
                                        Dim insertm As String = "insert into votetb (contact,sms)values(@contact,@vote)"
                                        sqlcmdme = New SqlCommand(insertm, sqlcon)
                                        sqlcmdme.Parameters.AddWithValue("@contact", contact)
                                        sqlcmdme.Parameters.AddWithValue("@vote", vote)
                                        sqlcmdme.ExecuteNonQuery()
                                    End If
                                ElseIf vote.Contains("F") Then
                                    Dim VOTEDMALE As String = "select * from votetb where sms like '%F%' and contact = @contact"
                                    Dim cmd As SqlCommand = New SqlCommand(VOTEDMALE, sqlcon)
                                    cmd.Parameters.AddWithValue("@contact", contact)
                                    Dim readm As SqlDataReader = cmd.ExecuteReader
                                    If readm.HasRows = True Then
                                        readm.Close()
                                    Else
                                        readm.Close()
                                        Dim insertm As String = "insert into votetb (contact,sms)values(@contact,@vote)"
                                        sqlcmdme = New SqlCommand(insertm, sqlcon)
                                        sqlcmdme.Parameters.AddWithValue("@contact", contact)
                                        sqlcmdme.Parameters.AddWithValue("@vote", vote)
                                        sqlcmdme.ExecuteNonQuery()
                                    End If
                                End If
                            Else
                                rd.Close()
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
            ProgressBar1.Value += 1

        Next
        MsgBox("DONE")
    End Sub
End Class
