Imports System.Data.OleDb
Public Class Form1

    Dim baglan As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=bilgiler.accdb")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BilgilerDataSet.Tablo1' table. You can move, or remove it, as needed.
        Me.Tablo1TableAdapter.Fill(Me.BilgilerDataSet.Tablo1)
        guncele()
    End Sub

    Sub guncele()
        Dim da As New OleDbDataAdapter("SELECT * FROM TABLO1", baglan)
        Dim tablo As New DataTable
        da.Fill(tablo)
        DataGridView2.DataSource = tablo
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Dim da As New OleDbDataAdapter("select ADI,SOYADI,GELİR,GİDER from tablo1 ORDER BY ADI ASC", baglan)
            Dim tablo As New DataTable
            da.Fill(tablo)
            DataGridView2.DataSource = tablo
        End If

        If CheckBox2.Checked Then
            Dim da As New OleDbDataAdapter("select ADI,SOYADI,CINSIYET from tablo1 ORDER BY ADI ASC", baglan)
            Dim tablo As New DataTable
            da.Fill(tablo)
            DataGridView2.DataSource = tablo
        End If

        If CheckBox3.Checked Then
            Dim da As New OleDbDataAdapter("SELECT * FROM TABLO1", baglan)
            Dim tablo As New DataTable
            da.Fill(tablo)
            DataGridView2.DataSource = tablo
        End If




    End Sub
End Class
