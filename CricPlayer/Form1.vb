Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Form1
    Sub countryName()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select DISTINCT country from players", conn)
        Dim cmd As New OleDbCommand()
        Dim ds As New DataSet()
        adp.Fill(ds, "players")
        cntName.DataSource = ds.Tables("players")
        cntName.ValueMember = "country"
        cntName.DisplayMember = "country"
        conn.Close()
    End Sub
    Sub view()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from players order by country", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "players")
        GridView.DataSource = ds.Tables("players")
        conn.Close()
        txtname.Clear()
        txtnom.Clear()
        txtnor.Clear()
        txtcntr.Clear()
    End Sub
    Private Sub txtins_Click(sender As Object, e As EventArgs) Handles btnins.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into players values('" & txtname.Text & "','" & txtcntr.Text & "'," & txtnom.Text & "," & txtnor.Text & ")"
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub txtdsp_Click(sender As Object, e As EventArgs) Handles btndsp.Click
        view()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        view()
        countryName()
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update players set country='" & txtcntr.Text & "', no_of_matches=" & txtnom.Text & ", no_of_runs=" & txtnor.Text & " where name= '" & txtname.Text & "' "
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete * from players where name='" & txtname.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub cntName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cntName.SelectedIndexChanged
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from players where country='" & cntName.Text & "' ", conn)
        Dim cmd As New OleDbCommand()
        Dim ds As New DataSet()
        adp.Fill(ds, "players")
        GridView.DataSource = ds.Tables("players")
        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsrc.TextChanged

    End Sub

    Private Sub src_Click(sender As Object, e As EventArgs) Handles src.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\CricPlayer\CricPlayerDB.accdb")
        conn.Open()
        Dim sql As String = " select * from players where name='" & txtsrc.Text & "' "
        Using cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                txtname.Text = reader("name").ToString()
                txtcntr.Text = reader("country").ToString()
                txtnom.Text = reader("no_of_matches").ToString()
                txtnor.Text = reader("no_of_runs").ToString()
            End While
        End Using
        conn.Close()
    End Sub
End Class
