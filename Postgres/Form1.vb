Imports System.Data.SQLite
Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String

    Private Sub PopListview()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Residence Hall", 129)
            .Columns.Add("Address", 130)
            .Columns.Add("Telephone", 80)
            .Columns.Add("Manager", 100)

        End With
        openCon()
        sql = "Select * from tblhall order by idhall"
        cmd = New SQLiteCommand(sql, cn)
        dr = cmd.ExecuteReader

        Do While dr.Read() = True
            lv = New ListViewItem(dr("idhall").ToString)
            lv.SubItems.Add(dr("hallname"))
            lv.SubItems.Add(dr("halladdr"))
            lv.SubItems.Add(dr("halltel"))
            lv.SubItems.Add(dr("hallman"))
            ListView1.Items.Add(lv)
        Loop
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopListview()

        DisableInputs()
        ToggleButtons(False)
    End Sub

    Private Sub EnableInputs()
        HallName.Enabled = True
        Address.Enabled = True
        TelNo.Enabled = True
        HallMngr.Enabled = True
    End Sub

    Private Sub DisableInputs()
        HallName.Enabled = False
        Address.Enabled = False
        TelNo.Enabled = False
        HallMngr.Enabled = False
    End Sub

    Private Sub ToggleButtons(enable As Boolean)
        save.Enabled = enable
        Close.Enabled = enable
        Newbtn.Enabled = Not enable
        Delete.Enabled = Not enable
        Edit.Enabled = Not enable
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        EnableInputs()
        ToggleButtons(True)
    End Sub

    Private Sub Newbtn_Click(sender As Object, e As EventArgs) Handles Newbtn.Click
        EnableInputs()
        ToggleButtons(True)
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click


        DisableInputs()
        ToggleButtons(False)

        HallName.Clear()
        Address.Clear()
        TelNo.Clear()
        HallMngr.Clear()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Dispose()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        DisableInputs()
        ToggleButtons(False)

        HallName.Clear()
        Address.Clear()
        TelNo.Clear()
        HallMngr.Clear()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        DisableInputs()
        ToggleButtons(False)
    End Sub
End Class
