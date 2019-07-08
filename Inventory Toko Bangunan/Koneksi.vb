Imports MySql.Data.MySqlClient

Module Koneksi
    ReadOnly server As String = "localhost"
    ReadOnly port As String = "3307"
    ReadOnly id As String = "root"
    ReadOnly pass As String = "Citraland2018"
    ReadOnly db As String = "anugerah_jaya"

    Public con As New MySqlConnection("server=" & server & "; port=" & port & "; uid=" & id & "; password=" & pass & "; database=" & db & "")
    Public cmd As New MySqlCommand
    Public adap As New MySqlDataAdapter
End Module
