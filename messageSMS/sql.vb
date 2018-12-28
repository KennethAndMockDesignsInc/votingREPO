Imports System.Data.SqlClient
Public Class sql
    Public sqlcon As New SqlConnection With {.ConnectionString = "data source='KMDI-ACER-E15\KMDISQLSERVER';
                                                                   initial catalog='partydb';
                                                                   network library='DBMSSOCN';
                                                                   user id='kmdiadmin';
                                                                   password='kmdiadmin';"}
    Public sqlcon1str As String = sqlcon.ConnectionString.ToString
End Class
